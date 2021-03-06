﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TO;
using DAO.Administration;

namespace BL.Admistration
{
    public class BLDish
    {
        public int Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
        public bool State { set; get; }
        public string Picture { set; get; }
        
        ArrayList DishesLists = new ArrayList();
        public BLDish()
        {

        }

        public BLDish(int code, string name, string description, decimal price, bool state, string picture)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.State = state;
            this.Picture = picture;
        }

        public BLDish(string name, string description, decimal price, bool state, string picture)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.State = state;
            this.Picture = picture;
        }

        public ArrayList DishesList()
        {
            DAODish dv = new DAODish();
            List<Dish> list = dv.DishesList();
            foreach (Dish dish in list)
            {
                BLDish bldhs = new BLDish(dish.DishCode, dish.DishName, dish.DishDescription, dish.DishPrice, dish.DishAvailable, dish.DishPhoto);
                DishesLists.Add(bldhs);
            }
            return DishesLists;
        }

        public void updateDishes(BLDish bldish)
        {
            DishesList();
            DAODish dv = new DAODish();
            foreach (BLDish dish in DishesLists)
            {
                if (dish.Code == bldish.Code)
                {
                    Dish todish = new Dish() { DishCode = bldish.Code, DishName = bldish.Name, DishDescription = bldish.Description, DishPrice = bldish.Price, DishAvailable = bldish.State, DishPhoto = bldish.Picture };
                    dv.updateDish(todish);
                    return;
                }

            }
        }

        public void ChangeState(int code)
        {
            DAODish dv = new DAODish();
            Dish dish = dv.ChargeDish(code);
            if (dish.DishAvailable)
            {
                dish.DishAvailable = false;            }
            else
            {
                dish.DishAvailable = true;
                 }
            dv.updateDish(dish);

        }

        public void addDish(BLDish bldish)
        {
            DAODish dv = new DAODish();
            Dish todish = new Dish() { DishCode = bldish.Code, DishName = bldish.Name, DishDescription = bldish.Description, DishPrice = bldish.Price, DishAvailable = bldish.State, DishPhoto = bldish.Picture };
            dv.addDish(todish);
        }

        public void deleteDish(int code)
        {
            DAODish dish = new DAODish();
            dish.DeleteDish(code);
            DishesLists = new ArrayList();
            DishesList();
        }

        public BLDish ChargeDish(int code)
        {
            DAODish dv = new DAODish();
            Dish dish = dv.ChargeDish(code);
            BLDish bldish = new BLDish(dish.DishCode, dish.DishName, dish.DishDescription, dish.DishPrice, dish.DishAvailable, dish.DishPhoto);
            return bldish;
        }



        public string getNameDish(int code)
        {
            DAODish dv = new DAODish();
            return dv.ChargeDish(code).DishName.ToString();
        }
        public ArrayList chargeRelatedDishes(string word)
        {
            DAODish dv = new DAODish();
            List<Dish> dishes = dv.ChargeRelatedDish(word);
            ArrayList array = new ArrayList();
            foreach (var item in dishes)
            {
                BLDish blDish = new BLDish(item.DishCode, item.DishName, item.DishDescription, item.DishPrice, item.DishAvailable, item.DishPhoto);
                array.Add(blDish);
            }
            return array;
        }

        public List<string> ListDishString()
        {
            List<string> stringList = new List<string>();
            ArrayList list = DishesList();
            foreach (BLDish dish in list)
            {
                string state = "";
                if (dish.State)
                {
                    state = "enable";
                }
                else
                {
                    state = "disable";
                }

                stringList.Add("Code: " + dish.Code + " ,Name: " + dish.Name + " ,Description: " + dish.Description + " ,State: " + state +".");
            }
            return stringList;
        }

    }

}
