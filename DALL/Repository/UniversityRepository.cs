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
    public class UniversityRepository
    {
        string cs = "server=LAPTOP-0C6MBQ3H;database=GPTEST;uid=sa;pwd=123";
        public List<University> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                List<University> std = new List<University>();


                conn.Open();
                SqlCommand cmd = new SqlCommand("UniversityCrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    University obj = new University
                    {

                        UniversityId = (dr["UniversityId"] as int?).GetValueOrDefault(),
                        Code = dr["Code"].ToString(),
                        Name = dr["Name"].ToString(),
                        CreatedBy = dr["CreatedBy"].ToString(),
                        CreatedOn = (dr["CreatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedOn = (dr["UpdatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedBy = dr["UpdatedBy"].ToString(),
                        CityId = (dr["CityId"] as int?).GetValueOrDefault()

                    };

                    std.Add(obj);
                }

                return std;
            }
        }
    }
}
