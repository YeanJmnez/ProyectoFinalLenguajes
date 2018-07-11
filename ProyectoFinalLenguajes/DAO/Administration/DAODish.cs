using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TO;
using System.Data.SqlClient;

namespace DAO.Administration
{
    public class DAODish
    {
        public List<Dish> DishesList()
        {
            List<Dish> listDish = new List<Dish>();
            using (DB_Project db = new DB_Project())
            {
                listDish = db.Dish.ToList();
            }
            return listDish;
        }

        public void updateDish(Dish dish)
        {
            try
            {
                using (DB_Project db = new DB_Project())
                {
                    Dish dis = db.Dish.Find(dish.DishCode);
                    if (dis != null)
                    {
                        dis.DishName = dish.DishName;
                        dis.DishDescription = dish.DishDescription;
                        dis.DishPrice = dish.DishPrice;
                        dis.DishAvailable = dish.DishAvailable;
                        dis.DishPhoto = dish.DishPhoto;
                        db.SaveChanges();
                    }

                }
            }
            catch
            {

            }
        }

        public void addDish(Dish dish)
        {
            try
            {
                using (DB_Project db = new DB_Project())
                {
                    db.Dish.Add(dish);
                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }

        public void DeleteDish(int code)
        {
            using (DB_Project db = new DB_Project())
            {
                Dish dish = db.Dish.Find(code);
                if (dish != null)
                {
                    db.Dish.Attach(dish);
                    db.Dish.Remove(dish);
                    db.SaveChanges();
                }
            }
        }



        public Dish ChargeDish(int code)
        {
            using (DB_Project db = new DB_Project())
            {
                var dish = db.Dish.Find(code);
                return dish;
            }
        }

        public List<Dish> ChargeRelatedDish(string word)
        {
            using (DB_Project db = new DB_Project())
            {
                IQueryable<Dish> results = from dish in db.Dish where (dish.DishName == word || dish.DishDescription.Contains(word)) select dish;
                List<Dish> list = results.ToList();
                return list;
            }
        }

        public DAODish() {
        }



    }

}
