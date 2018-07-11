using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Kitchen;
using TO;

namespace BL.Admistration
{
    public class BLManagerOrders
    {

        public int OrderCode { get; set; }
        public string OrderState { get; set; }
        public decimal TotalPrice { get; set; }
        public System.DateTime DateHourIn { get; set; }
        public string DeliveryAddress { get; set; }
        public string ClientEmail { get; set; }


        public BLManagerOrders() { }

        public BLManagerOrders(int code, string orderState, decimal TotalPrice, DateTime DateHourIn, string DeliveryAddress, string ClientEmail)
        {
            this.OrderCode = code;
            this.OrderState = orderState;
            this.TotalPrice = TotalPrice;
            this.DateHourIn = DateHourIn;
            this.DeliveryAddress = DeliveryAddress;
            this.ClientEmail = ClientEmail;
        }
    
    public List<BLManagerOrders> ListByClientEmail(string email)
        {
            List<BLManagerOrders> ListByEmail = new List<BLManagerOrders>();
            DAOClientOrders DaoOrder = new DAOClientOrders();

            foreach (ClientOrder clientorder in DaoOrder.listOrder())
            {
                if (clientorder.ClientEmail.Equals(email))
                {
                    BLManagerOrders Order = new BLManagerOrders(clientorder.OrderCode, clientorder.OrderState, clientorder.TotalPrice, clientorder.DateHourIn, clientorder.DeliveryAddress, clientorder.ClientEmail);
                    ListByEmail.Add(Order);
                }
            }
            return ListByEmail;
        }

        public List<BLManagerOrders> ListByOrderStatus(string status)
        {
            List<BLManagerOrders> ListByEmail = new List<BLManagerOrders>();
            DAOClientOrders DaoOrder = new DAOClientOrders();

            foreach (ClientOrder clientorder in DaoOrder.listOrder())
            {
                if (clientorder.OrderState.Equals(status))
                {
                    BLManagerOrders Order = new BLManagerOrders(clientorder.OrderCode, clientorder.OrderState, clientorder.TotalPrice, clientorder.DateHourIn, clientorder.DeliveryAddress, clientorder.ClientEmail);
                    ListByEmail.Add(Order);
                } 
            }
            return ListByEmail;
        }

        //public List<BLManagerOrders> ListByDate(string status)
        //{
        //    List<BLManagerOrders> ListByEmail = new List<BLManagerOrders>();
        //    DAOClientOrders DaoOrder = new DAOClientOrders();

        //    foreach (ClientOrder clientorder in DaoOrder.listOrder())
        //    {
        //        if (clientorder.OrderState.Equals(status))
        //        {
        //            BLManagerOrders Order = new BLManagerOrders(clientorder.OrderCode, clientorder.OrderState, clientorder.TotalPrice, clientorder.DateHourIn, clientorder.DeliveryAddress, clientorder.ClientEmail);
        //            ListByEmail.Add(Order);
        //        }
        //    }
        //    return ListByEmail;
        //}
    }
}
