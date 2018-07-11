using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL.Admistration;

namespace GUI.WSClient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WSClient" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WSClient.svc or WSClient.svc.cs at the Solution Explorer and start debugging.
    public class WSClient : IWSClient
    {
        public void AddNewWSClient(string email, string name, string password)
        {
            BLClient client = new BLClient(email, name, password, true);
        }

        public void UpdateWSClient(string name, string password)
        {
            BLClient client = new BLClient(name, password);
        }

        public List<BLDish> FilterDishes(int code)
        {
            BLClient Cl = new BLClient();
            return Cl.FilterDishes(code);
        }

        public List<BLDish> DishesList()
        {
            BLClient Cl = new BLClient();
            return Cl.DishesList();
        }

        public List<BLDish> GetSelectedDishes(List<string> Codes)
        {
            BLClient Cl = new BLClient();
            List<BLDish> allDishes = Cl.DishesList();
            List<BLDish> allSelectedDishes = new List<BLDish>();

            foreach (string dishCode in Codes) {
                foreach (BLDish dish in allDishes)
                {
                    if (dishCode.Equals(dish.Code))
                    {
                        allSelectedDishes.Add(dish);
                    }
                }
            }

            return allSelectedDishes;
        }
    }
}
