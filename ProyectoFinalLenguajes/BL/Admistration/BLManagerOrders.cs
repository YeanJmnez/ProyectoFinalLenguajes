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

        public List<BLManagerOrders> CompleteOrderList()
        {
            List<BLManagerOrders> OrderList = new List<BLManagerOrders>();
            DAOClientOrders DaoOrder = new DAOClientOrders();

            foreach (ClientOrder clientorder in DaoOrder.listOrder())
            {
                    BLManagerOrders Order = new BLManagerOrders(clientorder.OrderCode, clientorder.OrderState, clientorder.TotalPrice, clientorder.DateHourIn, clientorder.DeliveryAddress, clientorder.ClientEmail);
                    OrderList.Add(Order);   
            }
            return OrderList;
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
            List<BLManagerOrders> ListByStatus = new List<BLManagerOrders>();
            DAOClientOrders DaoOrder = new DAOClientOrders();

            foreach (ClientOrder clientorder in DaoOrder.listOrder())
            {
                if (clientorder.OrderState.Equals(status))
                {
                    BLManagerOrders Order = new BLManagerOrders(clientorder.OrderCode, clientorder.OrderState, clientorder.TotalPrice, clientorder.DateHourIn, clientorder.DeliveryAddress, clientorder.ClientEmail);
                    ListByStatus.Add(Order);
                } 
            }
            return ListByStatus;
        }

        public List<BLManagerOrders> ListByDate(DateTime Initialdate, DateTime finalDate)
        {
            List<BLManagerOrders> ListDate = new List<BLManagerOrders>();
            DAOClientOrders DaoOrder = new DAOClientOrders();

            foreach (ClientOrder clientorder in DaoOrder.listOrder())
            {
                if ((clientorder.DateHourIn >= Initialdate) && (clientorder.DateHourOut <= finalDate))
                {
                    BLManagerOrders Order = new BLManagerOrders(clientorder.OrderCode, clientorder.OrderState, clientorder.TotalPrice, clientorder.DateHourIn, clientorder.DeliveryAddress, clientorder.ClientEmail);
                    ListDate.Add(Order);
                }
            }
            return ListDate;
        }

        public List<string> ListClientEmail(string email)
        {
            List<string> stringList = new List<string>();
            List<BLManagerOrders> list = ListByClientEmail(email);
            foreach (BLManagerOrders order in list)
            {
                stringList.Add("Order Code: " + order.OrderCode + ", Client: " + order.ClientEmail + ", Total Price: " + order.TotalPrice + 
                    ", Date: " + order.DateHourIn + ", Status: " + order.OrderState);
            }
            return stringList;
        }

        public List<string> ListOrderStatus(string status)
        {
            List<string> stringList = new List<string>();
            List<BLManagerOrders> list = ListByOrderStatus(status);
            foreach (BLManagerOrders order in list)
            {
                stringList.Add("Order Code: " + order.OrderCode + ", Client: " + order.ClientEmail + ", Total Price: " + order.TotalPrice +
                    ", Date: " + order.DateHourIn + ", Status: " + order.OrderState);
            }
            return stringList;
        }

        public List<string> ListOrderDate(DateTime Initialdate, DateTime finalDate)
        {
            List<string> stringList = new List<string>();
            List<BLManagerOrders> list = ListByDate(Initialdate, finalDate);
            foreach (BLManagerOrders order in list)
            {
                stringList.Add("Order Code: " + order.OrderCode + ", Client: " + order.ClientEmail + ", Total Price: " + order.TotalPrice +
                    ", Date: " + order.DateHourIn + ", Status: " + order.OrderState);
            }
            return stringList;
        }

        public List<string> ListMultiOrder(string email, string status, DateTime Initialdate, DateTime finalDate, int option)
        {
            List<string> stringList = new List<string>();
            List<BLManagerOrders> list = ListUniversalOrder(email, status, Initialdate, finalDate, option);
            foreach (BLManagerOrders order in list)
            {
                stringList.Add("Order Code: " + order.OrderCode + ", Client: " + order.ClientEmail + ", Total Price: " + order.TotalPrice +
                    ", Date: " + order.DateHourIn + ", Status: " + order.OrderState);
            }
            return stringList;
        }

        public string ChangeOrderStatus(string code, string status)
        {
            string transaction = "The status Order is already changed";
            DAOClientOrders DcOrders = new DAOClientOrders();
            ClientOrder order = new ClientOrder();
            DcOrders.ChangeStateOrder(Int32.Parse(code), status);
            return transaction;
        }

        public List<BLManagerOrders> ListUniversalOrder(string email, string status, DateTime Initialdate, DateTime finalDate, int option)
        {
            List<BLManagerOrders> ListOrder = new List<BLManagerOrders>();
            switch (option)
            {
                case 1:

                    List<BLManagerOrders> ListOrderEmail = ListByClientEmail(email);
                    
                    foreach(BLManagerOrders order in ListOrderEmail)
                    {
                        if(order.OrderState.Equals(status))
                        {
                            ListOrder.Add(order);
                        }
                    }
                    break;
                case 2:
                    List<BLManagerOrders> ListOrderStatus = ListByOrderStatus(status);

                    foreach (BLManagerOrders order in ListOrderStatus)
                    {
                        if (order.ClientEmail.Equals(email))
                        {
                            ListOrder.Add(order);
                        }
                    }
                    break;
                case 3:
                    List<BLManagerOrders> ListOrderDate = ListByDate(Initialdate, finalDate);

                    foreach (BLManagerOrders order in ListOrderDate)
                    {
                        if (order.ClientEmail.Equals(email))
                        {
                            ListOrder.Add(order);
                        }
                    }
                    break;
                case 4:
                    List<BLManagerOrders> ListOrderDate2 = ListByDate(Initialdate, finalDate);

                    foreach (BLManagerOrders order in ListOrderDate2)
                    {
                        if (order.OrderState.Equals(status))
                        {
                            ListOrder.Add(order);
                        }
                    }
                    break;
                case 5:
                    List<BLManagerOrders> ListMultiOrder = ListByDate(Initialdate, finalDate);

                    foreach (BLManagerOrders order in ListMultiOrder)
                    {
                        if (order.ClientEmail.Equals(email) && order.OrderState.Equals(status))
                        {
                            ListOrder.Add(order);
                        }
                    }
                    break;
                default:
                    break;
            }
            return ListOrder;
        }
    }
}
    


