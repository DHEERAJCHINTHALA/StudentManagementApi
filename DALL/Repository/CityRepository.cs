using DALL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Repository
{
    public class CityRepository
    {
        string cs = "server=LAPTOP-0C6MBQ3H;database=GPTEST;uid=sa;pwd=123";
        public List<City> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                List<City> std = new List<City>();


                conn.Open();
                SqlCommand cmd = new SqlCommand("CityCrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    City obj = new City
                    {

                        CityId = (dr["CityId"] as int?).GetValueOrDefault(),
                        Code = dr["Code"].ToString(),
                        Name = dr["Name"].ToString(),
                        CreatedBy = dr["CreatedBy"].ToString(),
                        CreatedOn = (dr["CreatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedOn = (dr["UpdatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedBy = dr["UpdatedBy"].ToString(),
                        StatesId = (dr["StatesId"] as int?).GetValueOrDefault(),
                        CountryId = (dr["CountryId"] as int?).GetValueOrDefault()
                    };

                    std.Add(obj);
                }

                return std;
            }
        }
    
    }
}
