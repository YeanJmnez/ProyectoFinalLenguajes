using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TAO.Administration;
using System.Data.SqlClient;

namespace DAO.Administration
{
    public class DAODish
    {
        public SqlConnection sqlCnt = new SqlConnection(Properties.Settings.Default.StringConnection);

        public List<TODish> DishesList()
        {
            List<TAO.Administration.TODish> list = new List<TAO.Administration.TODish>();
            TAO.Administration.TODish dish = new TAO.Administration.TODish();
            string con = "select * from Dishes";
            SqlCommand comand = new SqlCommand(con, sqlCnt);

            if (sqlCnt.State != System.Data.ConnectionState.Open)
            {
                sqlCnt.Open();
            }

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dish = new TAO.Administration.TODish(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), double.Parse(reader.GetValue(3).ToString()), reader.GetValue(4).ToString(), reader.GetValue(5).ToString());
                    list.Add(dish);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            if (sqlCnt.State != System.Data.ConnectionState.Closed)
            {
                sqlCnt.Close();
            }

            return list;
        }

        public void updateDish(TODish dish)
        {
            string con = "Update Dishes set Name = @nam, Description = @desc, Price = @pri, State = @sta, Picture = @pic where Code = @cod";
            SqlCommand comand = new SqlCommand(con, sqlCnt);
            comand.Parameters.AddWithValue("@cod", dish.Code);
            comand.Parameters.AddWithValue("@nam", dish.Name);
            comand.Parameters.AddWithValue("@desc", dish.Description);
            comand.Parameters.AddWithValue("@pri", dish.Price);
            comand.Parameters.AddWithValue("@sta", dish.State);
            comand.Parameters.AddWithValue("@pic", dish.Picture);

            if (sqlCnt.State != System.Data.ConnectionState.Open)
            {
                sqlCnt.Open();
            }
            comand.ExecuteNonQuery();

            if (sqlCnt.State == System.Data.ConnectionState.Closed)
            {
                sqlCnt.Close();
            }
        }

        public void addDish(TODish dish)
        {
            string con = "Insert into Dishes (Code, Name, Description, Price, State, Picture) values (@cod, @nam, @desc, @pri, @sta, @Pic)";
            SqlCommand comand = new SqlCommand(con, sqlCnt);
            comand.Parameters.AddWithValue("@cod", dish.Code);
            comand.Parameters.AddWithValue("@nam", dish.Name);
            comand.Parameters.AddWithValue("@desc", dish.Description);
            comand.Parameters.AddWithValue("@pri", dish.Price);
            comand.Parameters.AddWithValue("@sta", dish.State);
            comand.Parameters.AddWithValue("@Pic", dish.Picture);

            if (sqlCnt.State != System.Data.ConnectionState.Open)
            {
                sqlCnt.Open();
            }
            comand.ExecuteNonQuery();

            if (sqlCnt.State == System.Data.ConnectionState.Closed)
            {
                sqlCnt.Close();
            }
        }

        public void DeleteDish(int code)
        {
            string con = "Delete From Dishes where Code = @cod";
            SqlCommand comand = new SqlCommand(con, sqlCnt);
            comand.Parameters.AddWithValue("@cod", code);

            if (sqlCnt.State != System.Data.ConnectionState.Open)
            {
                sqlCnt.Open();
            }
            comand.ExecuteNonQuery();

            if (sqlCnt.State == System.Data.ConnectionState.Closed)
            {
                sqlCnt.Close();
            }
        }

        public TAO.Administration.TODish ChargeDish(int code)
        {
            TODish dish = new TODish();
            string con = "select * from Dishes where Code = @cod";
            SqlCommand comand = new SqlCommand(con, sqlCnt);
            comand.Parameters.AddWithValue("@cod", code);
            if (sqlCnt.State != System.Data.ConnectionState.Open)
            {
                sqlCnt.Open();
            }

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (int.Parse(reader.GetValue(0).ToString()) == code)
                    {
                        dish = new TAO.Administration.TODish(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), double.Parse(reader.GetValue(3).ToString()), reader.GetValue(4).ToString(), reader.GetValue(5).ToString());
                        return dish;
                    }

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            if (sqlCnt.State != System.Data.ConnectionState.Closed)
            {
                sqlCnt.Close();
            }
            return dish;
        }
    }

}
