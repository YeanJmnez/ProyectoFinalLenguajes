using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO.Kitchen
{
    public class DAOClientOrders
    {

        public List<ClientOrder> listOrder()
        {
            List<ClientOrder> list = new List<ClientOrder>();
            using (DB_Project db = new DB_Project())
            {
                var listDB = (from ClientOrder in db.ClientOrder
                              where !(ClientOrder.OrderState == "committed" || ClientOrder.OrderState == "canceled")
                              orderby (ClientOrder.DateHourIn) descending
                              select ClientOrder).Take(10);


                foreach (var item in listDB)
                {
                    list.Add(new ClientOrder()
                    {
                        OrderCode = item.OrderCode,
                        OrderState = item.OrderState,
                        TotalPrice = item.TotalPrice,
                        DateHourIn = item.DateHourIn,
                        DeliveryAddress = item.DeliveryAddress,
                        ClientEmail = item.ClientEmail
                    });
                }

                foreach (ClientOrder item in list)
                {
                    item.listOrders = (from OrderDetail in db.OrderDetail
                                       where OrderDetail.OrderCode == item.OrderCode
                                       select OrderDetail).ToList();
                }
            }
            return list;
        }


        public void ChangeStateOrder(int OrderCode, string state)
        {
            using (DB_Project db = new DB_Project())
            {
                ClientOrder client = db.ClientOrder.Find(OrderCode);

                if (client != null)
                {
                    client.OrderState = state;
                    db.SaveChanges();
                }
            }


        }
       
    }
}
