using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Admistration
{
   public class BLClient
    {
        public string ClientEmail { get; set; }
        public string ClientName { get; set; }
        public string ClientPassword { get; set; }
        public int ClientAvailable { get; set; }

        public BLClient(string ClientEmail, string ClientName, string ClientPassword, int ClientAvailable) {
            this.ClientEmail = ClientEmail;
            this.ClientName = ClientName;
            this.ClientPassword = ClientPassword;
            this.ClientAvailable = ClientAvailable;
        }

        public BLClient() { }

    }
}
