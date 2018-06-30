using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO;
using System.Data.SqlClient;

namespace DAO.Administration
{
    public class DAOClient
    {

        public List<Client> ClientList()
        {
            List<Client> Clientes = new List<Client>();
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                Clientes = db.Clients.ToList();
            }
            return Clientes;
        }

        public void updateClient(Client client)
        {
            try
            {
                using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
                {
                    Client cliente = db.Clients.Find(client.ClientEmail);
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

        public void addClient(Client client)
        {
            try
            {
                using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
                {
                    db.Clients.Add(client);
                    db.Addresses.Add(new Address() { ClientEmail = client.ClientEmail, PhysicalAddress = client.ClientAddress });
                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }

        public void DeleteClient(String email)
        {
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                var client = db.Clients.Find(email);
                if (client != null)
                {
                    db.Clients.Attach(client);
                    db.Clients.Remove(client);
                    db.SaveChanges();
                }
            }
        }

        public Client ChargeClient(String email)
        {
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                var client = db.Clients.Find(email);
                var Address = db.Addresses.Find(email);
                client.ClientAddress = Address.PhysicalAddress;
                return client;
            }
        }
    }
}
