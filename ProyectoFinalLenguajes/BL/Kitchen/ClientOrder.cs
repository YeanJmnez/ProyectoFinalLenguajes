using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Kitchen
{
    public class ClientOrder
    {

        public int OrderCode { get; set; }
        public string OrderState { get; set; }
        public decimal TotalPrice { get; set; }
        public System.DateTime DateHourIn { get; set; }
        public Nullable<System.DateTime> DateHourOut { get; set; }
        public string DeliveryAddress { get; set; }
        public string ClientEmail { get; set; }
        public List<OrderDetails> listOrderDetails { get; set; }

        public ClientOrder() { }
        public ClientOrder(int code, string orderState, decimal TotalPrice, DateTime DateHourIn, string DeliveryAddress, string ClientEmail)
        {
            this.OrderCode = code;
            this.OrderState = orderState;
            this.TotalPrice = TotalPrice;
            this.DateHourIn = DateHourIn;
            this.DeliveryAddress = DeliveryAddress;
            this.ClientEmail = ClientEmail;
        }

        public ClientOrder(int code, string orderState, decimal TotalPrice, DateTime DateHourIn, string DeliveryAddress, string ClientEmail, List<OrderDetails> listOrderDetails)
        {
            this.OrderCode = code;
            this.OrderState = orderState;
            this.TotalPrice = TotalPrice;
            this.DateHourIn = DateHourIn;
            this.DeliveryAddress = DeliveryAddress;
            this.ClientEmail = ClientEmail;
            this.listOrderDetails = listOrderDetails;
        }
    }
}
