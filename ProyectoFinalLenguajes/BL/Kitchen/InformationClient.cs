using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Kitchen
{
    public class InformationClient
    {
        public int OrderCode { get; set; }
        public string ClientName { get; set; }
        public string OrderState { get; set; }
        List<string> dishOrder { get; set; }

        public InformationClient() { }
        public InformationClient(int code, string name, string OrderState, List<string> dishes)
        {
            this.OrderCode = code;
            this.ClientName = name;
            this.OrderState = OrderState;
            this.dishOrder = dishes;
        }
    }
}
