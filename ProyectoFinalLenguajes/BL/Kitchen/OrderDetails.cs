using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Kitchen
{
    public class OrderDetails
    {

        public int OrderCode { get; set; }
        public int DishCode { get; set; }
        public decimal DishPrice { get; set; }
        public int DishQuantity { get; set; }
        public decimal SubTotal { get; set; }


        public OrderDetails() { }
        public OrderDetails(int orderCode, int dishCode, decimal dishPrice, int dishQuantity, decimal subtotal)
        {
            this.OrderCode = orderCode;
            this.DishCode = dishCode;
            this.DishPrice = dishPrice;
            this.DishQuantity = dishQuantity;
            this.SubTotal = subtotal;
        }
    }
}
