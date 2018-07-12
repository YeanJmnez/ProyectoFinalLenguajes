using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;

namespace DAO.Administration
{
    public class DAOClient
    {

        public List<Client> ClientList()
        {
            List<Client> Clientes = new List<Client>();
            using (DB_Project db = new DB_Project())
            {
                Clientes = db.Client.ToList();
            }
            return Clientes;
        }

        public void updateClient(Client client)
        {
            try
            {
                using (DB_Project db = new DB_Project())
                {
                    Client cliente = db.Client.Find(client.ClientEmail);
                    if (client != null)
                    {
                        cliente.ClientName = client.ClientEmail;
                        cliente.ClientPassword = client.ClientPassword;
                        cliente.ClientAvailable = client.ClientAvailable;
                        db.SaveChanges();
                    }

                }
            }
            catch
            {

            }
        }

        public void addClient(Client client, Address address)
        {
            try
            {
                using (DB_Project db = new DB_Project())
                {
                    db.Client.Add(client);
                    db.Address.Add(address);
                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }
        public void updateStateClient(Client client)
        {
            try
            {
                using (DB_Project db = new DB_Project())
                {
                    Client cliente = db.Client.Find(client.ClientEmail);
                    if (client != null)
                    {
                        cliente.ClientAvailable = client.ClientAvailable;
                        db.SaveChanges();
                    }

                }
            }
            catch
            {

            }
        }

        public void DeleteClient(String email)
        {
            using (DB_Project db = new DB_Project())
            {
                var client = db.Client.Find(email);
                if (client != null)
                {
                    db.Client.Attach(client);
                    db.Client.Remove(client);
                    db.SaveChanges();
                }
            }
        }

        public Client ChargeClient(String email)
        {
            using (DB_Project db = new DB_Project())
            {
                var client = db.Client.Find(email);
                var Address = db.Address.Find(email);
                //client.ClientAddress = Address.PhysicalAddress;
                return client;
            }
        }
    }
}
