using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TAO;
using System.Data.SqlClient;

namespace DAO.Administration
{
    public class DAODish
    {
        public List<Dish> DishesList()
        {
            List<Dish> listDish = new List<Dish>();
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                listDish = db.Dishes.ToList();
            }
            return listDish;
        }

        public void updateDish(Dish dish)
        {
            try
            {
                using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
                {
                    Dish dis = db.Dishes.Find(dish.DishCode);
                    if (dis != null)
                    {
                        dis.DishName = dish.DishName;
                        dis.DishDescription = dish.DishDescription;
                        dis.DishPrice = dish.DishPrice;
                        dis.DishAvailable = dish.DishAvailable;
                        db.DishPhotoes.Find(dish.DishCode).PhotoPath = dish.DishPhoto;
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
                using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
                {
                    db.Dishes.Add(dish);
                    DishPhoto photo = new DishPhoto();
                    photo.DishCode = dish.DishCode;
                    photo.PhotoPath = dish.DishPhoto;
                    db.DishPhotoes.Add(photo);
                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }

        public void DeleteDish(String code)
        {
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                Dish dish = db.Dishes.Find(code);
                DishPhoto photo = db.DishPhotoes.Find(code);
                if (dish != null)
                {
                    db.DishPhotoes.Attach(photo);
                    db.DishPhotoes.Remove(photo);
                    db.Dishes.Attach(dish);
                    db.Dishes.Remove(dish);
                    db.SaveChanges();
                }
            }
        }



        public Dish ChargeDish(int code)
        {
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                var dish = db.Dishes.Find(code);
                var photo = db.DishPhotoes.Find(code);
                dish.DishPhoto = photo.PhotoPath;
                return dish;
            }
        }

        public List<Dish> ChargeRelatedDish(string word)
        {
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                IQueryable<Dish> results = from dish in db.Dishes where (dish.DishName == word || dish.DishDescription.Contains(word)) select dish;
                List<Dish> list = results.ToList();
                return list;
            }
        }

        public DAODish()
        {

        }



    }

}
