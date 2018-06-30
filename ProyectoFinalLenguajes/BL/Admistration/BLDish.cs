using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TAO.Administration;
using DAO.Administration;

namespace BL.Admistration
{
    public class BLDish
    {
        public int Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public double Price { set; get; }
        public string State { set; get; }
        public string Picture { set; get; }

        ArrayList DishesLists = new ArrayList();
        public BLDish()
        {

        }

        public BLDish(int code, string name, string description, double price, string state, string picture)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.State = state;
            this.Picture = picture;
        }

        public ArrayList DishesList()
        {
            DAODish dv = new DAODish();
            List<TODish> list = dv.DishesList();
            foreach (TODish dish in list)
            {
                BLDish bldhs = new BLDish(dish.Code, dish.Name, dish.Description, dish.Price, dish.State, dish.Picture);
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
                    TODish todish = new TODish(bldish.Code, bldish.Name, bldish.Description, bldish.Price, bldish.State, bldish.Picture);
                    dv.updateDish(todish);
                    return;
                }

            }

        }

        public void addDish(BLDish bldish)
        {
            DAODish dv = new DAODish();
            TODish todish = new TODish(bldish.Code, bldish.Name, bldish.Description, bldish.Price, bldish.State, bldish.Picture);
            dv.addDish(todish);
        }

        public void deleteDish(int code)
        {
            DAODish dish = new DAODish();
            dish.DeleteDish(code);
            DishesLists = new ArrayList();
            DishesList();
        }

        public ArrayList ChargeDish(int code)
        {
            ArrayList onlyDish = new ArrayList();
            DAODish dv = new DAODish();
            TODish dish = dv.ChargeDish(code);
            BLDish bldish = new BLDish(dish.Code, dish.Name, dish.Description, dish.Price, dish.State, dish.Picture);
            onlyDish.Add(bldish);
            return onlyDish;
        }
    }
}
