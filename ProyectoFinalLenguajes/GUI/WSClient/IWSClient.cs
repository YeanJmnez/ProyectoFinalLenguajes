using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BL.Admistration;

namespace GUI.WSClient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWSClient" in both code and config file together.
    [ServiceContract]
    public interface IWSClient
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void AddNewWSClient(string email, string name, string password);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void UpdateWSClient(string name, string password);

    }
}
