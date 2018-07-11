﻿using System;
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
        List<OrderDetail> TemporaryDishList = new List<OrderDetail>();

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

        public List<BLClient> ChargeClientLists()
        {
            DAOClient doc = new DAOClient();

            List<Client> ClientList = new List<Client>();
            List<BLClient> ListC = new List<BLClient>();

            ClientList = doc.ClientList();

            foreach (Client client in ClientList)
            {
                BLClient bldCt = new BLClient(client.ClientEmail, client.ClientName, client.ClientPassword, client.ClientAvailable);
                ListC.Add(bldCt);
            }

            return ListC;
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

        public string getNameClient(string email)
        {
            DAOClient client = new DAOClient();
            return client.ChargeClient(email).ClientName.ToString();
        }

        public List<BLDish> DishesList()
        {
            List<BLDish> ListD = new List<BLDish>();
            BLDish bld = new BLDish();
            foreach (BLDish dish in bld.DishesList())
            {
                if (dish.State == true)
                {
                    ListD.Add(dish);
                }
            }
            return ListD;
        }

        public List<BLDish> FilterDishes(int code)
        {
            List<BLDish> ListD = DishesList();
            List<BLDish> dishToReturn = new List<BLDish>();
            BLDish bld = new BLDish();

            foreach (BLDish dish in bld.DishesList())
            {
                if (dish.Code == code)
                {
                    dishToReturn.Add(dish);
                }
            }
            return dishToReturn;
        }

        public void ShoppingDishCar(BLDish bldish, int quantity)
        {
            OrderDetail TemporaryOrder = new OrderDetail();
            TemporaryOrder.DishCode = bldish.Code;
            TemporaryOrder.DishPrice = bldish.Price;
            TemporaryOrder.DishQuantity = quantity;
            TemporaryOrder.SubTotal = CalculateSubtotalOrderDetail(quantity, bldish.Price);
            TemporaryOrder.Dish = GetDish(bldish);
            TemporaryDishList.Add(TemporaryOrder);
        }

        public decimal CalculateSubtotalOrderDetail(int quantity, decimal unitPrice)
        {
            decimal mount = quantity * unitPrice;
            return mount;
        }

        public Dish GetDish(BLDish bldish)
        {
            BLDish bldsh = new BLDish();
            bldsh = bldish.ChargeDish(bldish.Code);
            Dish dsh = new Dish();
            dsh.DishCode = bldsh.Code;
            dsh.DishName = bldsh.Name;
            dsh.DishDescription = bldsh.Description;
            dsh.DishPrice = bldsh.Price;
            dsh.DishPhoto = bldsh.Picture;
            dsh.DishAvailable = bldsh.State;
            return dsh;
        }

        public string enableStateDish(string email, bool state)
        {
            string transaction = "The client is already enabled";
            DAOClient dc = new DAOClient();
            Client cl = new Client();
            cl.ClientEmail = email;
            cl.ClientAvailable = state;
            dc.updateStateClient(cl);
            return transaction;
        }

        public string disableStateDish(string email, bool state)
        {
            string transaction = "The client is already disable";
            DAOClient dc = new DAOClient();
            Client cl = new Client();
            cl.ClientEmail = email;
            cl.ClientAvailable = state;
            dc.updateStateClient(cl);
            return transaction;
        }

        public List<string> ListUserClient()
        {
            List<string> stringList = new List<string>();
            List<BLClient> list = ChargeClientLists();
            string Available = "";
            foreach (BLClient user in list)
            {
                if (user.ClientAvailable == true)
                {
                    Available = "Habilitado";
                }
                else
                {
                    Available = "Deshabilitado";
                }
                stringList.Add("Email: " + user.ClientEmail + " ,Name: " + user.ClientName + " ,State: " + Available + ".");
            }
            return stringList;
        }
    }
}
