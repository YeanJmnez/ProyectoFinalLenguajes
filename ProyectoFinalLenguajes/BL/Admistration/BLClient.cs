using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;
using DAO.Administration;

namespace BL.Admistration
{
   public class BLClient
    {
        public string ClientEmail { get; set; }
        public string ClientName { get; set; }
        public string ClientPassword { get; set; }
        public bool ClientAvailable { get; set; }

        List<BLClient> ClientListBL = new List<BLClient>();


        public BLClient(string ClientEmail, string ClientName, string ClientPassword, bool ClientAvailable) {
            this.ClientEmail = ClientEmail;
            this.ClientName = ClientName;
            this.ClientPassword = ClientPassword;
            this.ClientAvailable = ClientAvailable;
        }

        public BLClient() {

        }

        public BLClient(string ClientName, string ClientPassword)
        {
            this.ClientEmail = ClientEmail;
            this.ClientName = ClientName;
            this.ClientPassword = ClientPassword;
            this.ClientAvailable = ClientAvailable;
        }

        public void ClientLists()
        {
            DAOClient doc = new DAOClient();

            List<Client> ClientList = new List<Client>();

            ClientList = doc.ClientList();

            foreach (Client client in ClientList)
            {
                BLClient bldCt = new BLClient(client.ClientEmail, client.ClientName, client.ClientPassword, client.ClientAvailable);
                ClientListBL.Add(bldCt);
            }
        }

        public bool VerifiyEmail(string email)
        {
            bool verification = false;

            if (ClientListBL.Count != 0)
            {
                foreach (BLClient blc in ClientListBL)
                {
                    if (blc.ClientEmail == email)
                    {
                        verification = true;
                        return verification;
                    }
                }
            }

            return verification;
        }

        public string AddNewClient(BLClient client)
        {
            ClientLists();
            string transsaction = "Ingreso exitoso del cliente";
            DAOClient dc = new DAOClient();
            
            if (VerifiyEmail(client.ClientEmail))
            {
                transsaction = "Ya existe una cuenta de cliente asociada al correo ingresado";
                return transsaction;
            }
            Client cl = new Client();
            cl.ClientEmail = client.ClientEmail;
            cl.ClientName = client.ClientName;
            cl.ClientPassword = client.ClientPassword;
            cl.ClientAvailable = client.ClientAvailable;
            dc.addClient(cl);
            return transsaction;
        }

        public string UpdateClient (BLClient client)
        {
            string update = "No se pudo realizar la actualización";
            ClientLists();
            DAOClient dc = new DAOClient();

            foreach (BLClient blc in ClientListBL)
            {
                if (blc.ClientEmail == client.ClientEmail)
                {
                    Client cl = new Client();
                    cl.ClientName = client.ClientName;
                    cl.ClientPassword = client.ClientPassword;
                    cl.ClientAvailable = client.ClientAvailable;
                    dc.updateClient(cl);
                    update = "Actualización exitosa de cliente";
                    return update;
                }
            }
            return update;
        }

    }
}
