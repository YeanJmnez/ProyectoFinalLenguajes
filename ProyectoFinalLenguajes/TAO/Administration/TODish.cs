using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAO.Administration
{
    public class TODish
    {
        public int Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public double Price { set; get; }
        public string State { set; get; }

        public string Picture { set; get; }

        public TODish()
        {

        }

        public TODish(int code, string name, string description, double price, string state, string picture)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.State = state;
            this.Picture = picture;
        }
    }
}
