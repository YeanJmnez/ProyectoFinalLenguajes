using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using BL.Kitchen;
using System.Text;

namespace GUI.WSRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWSRestKitchenModule" in both code and config file together.
    [ServiceContract]
    public interface IWSRestKitchenModule
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<InformationClient> ListKitchenModule();
    }
}
