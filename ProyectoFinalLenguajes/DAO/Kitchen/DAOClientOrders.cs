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
                list = db.ClientOrder.ToList();

                foreach (ClientOrder item in list) {
                    item.ListOrderDetails = (from OrderDetail in db.OrderDetail where OrderDetail.OrderCode == item.OrderCode
                                             select OrderDetail).ToList();
                }
            }
            return list;
        }
    }
}
