using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Kitchen;
using TO;

namespace BL.Kitchen
{
    public class ManagerOrder
    {
        public List<ClientOrder> listOrder()
        {
            List<ClientOrder> finalList = new List<ClientOrder>();
            DAOClientOrders daoOrders = new DAOClientOrders();

            List<TO.ClientOrder> clientOrder = daoOrders.listOrder();
            if (clientOrder != null)
            {
                foreach (TO.ClientOrder order in clientOrder)
                {
                    if (!(order.OrderState == "Anulado" || order.OrderState == "Entregado"))
                    {
                        finalList.Add(new ClientOrder(order.OrderCode, order.OrderState,
                            order.TotalPrice, order.DateHourIn, order.DeliveryAddress, order.ClientEmail, ConvertListOrderDetails(order.ListOrderDetails)));
                    }
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

    }
}
