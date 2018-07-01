using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TAO;
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
            List<TAO.Dish> list = dv.DishesList();
            foreach (TAO.Dish dish in list)
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

        public void addDish(BLDish bldish)
        {
            DAODish dv = new DAODish();
            Dish todish = new Dish() { DishCode = bldish.Code, DishName = bldish.Name, DishDescription = bldish.Description, DishPrice = bldish.Price, DishAvailable = bldish.State, DishPhoto = bldish.Picture };
            dv.addDish(todish);
        }

        public void deleteDish(string code)
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
    }
}
