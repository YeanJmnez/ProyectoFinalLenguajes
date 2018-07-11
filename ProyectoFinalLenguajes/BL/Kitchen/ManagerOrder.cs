﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Admistration;
using DAO.Kitchen;
using TO;

namespace BL.Kitchen
{
    public class ManagerOrder
    {
        public List<ClientOrder> ListOrders()
        {
            List<ClientOrder> finalList = new List<ClientOrder>();
            DAOClientOrders daoOrders = new DAOClientOrders();

            List<TO.ClientOrder> clientOrder = daoOrders.listOrder();

            if (clientOrder != null)
            {
                foreach (TO.ClientOrder order in clientOrder)
                {
                    finalList.Add(new ClientOrder(order.OrderCode, order.OrderState,
                        order.TotalPrice, order.DateHourIn, order.DeliveryAddress, order.ClientEmail, ConvertListOrderDetails(order.listOrders)));
                }
            }
            
            return finalList;


        }

        public List<OrderDetails> ConvertListOrderDetails(List<OrderDetail> orderDetails)
        {
            List<OrderDetails> listOrder = new List<OrderDetails>();
            if (orderDetails != null)
            {
                foreach (OrderDetail order in orderDetails)
                {
                    listOrder.Add(new OrderDetails(order.OrderCode, order.DishCode, order.DishPrice, order.DishQuantity, order.SubTotal));
                }
            }
            return listOrder;
        }

        public List<InformationClient> ListKitchenModule()
        {
            List<InformationClient> FinalList = new List<InformationClient>();
            List<ClientOrder> ListOrderByDate = ListOrders();
            foreach (ClientOrder item in ListOrderByDate)
            {
                FinalList.Add(new InformationClient(item.OrderCode, new BLClient().getNameClient(item.ClientEmail), item.OrderState, item.DateHourIn.ToString(), ListDish(item.listOrderDetails)));
            }
            return FinalList;
        }


        public int QuantityOrders()
        {
            return ListKitchenModule().Count;
        }

        public List<string> ListDish(List<OrderDetails> listOrderDetails)
        {
            List<string> list = new List<string>();
            foreach (OrderDetails item in listOrderDetails)
            {
                list.Add(new BLDish().getNameDish(item.DishCode));
            }
            return list;
        }

        public void ChangeStateOrder(int OrderCode, String state)
        {
            DAOClientOrders daoOrders = new DAOClientOrders();
            daoOrders.ChangeStateOrder(OrderCode, state);
        }
    }
}