using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL.Kitchen;

namespace GUI.WSRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WSRestKitchenModule" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WSRestKitchenModule.svc or WSRestKitchenModule.svc.cs at the Solution Explorer and start debugging.
    public class WSRestKitchenModule : IWSRestKitchenModule
    {
        public List<InformationClient> ListKitchenModule()
        {
            return new ManagerOrder().ListKitchenModule();
        }
    }
}
