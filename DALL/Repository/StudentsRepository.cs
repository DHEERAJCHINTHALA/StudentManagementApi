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
    public class StudentsRepository
    {
        string cs = "server=LAPTOP-0C6MBQ3H;database=GPTEST;uid=sa;pwd=123";
        public List<GetAll> GetAll()
        {

            List<GetAll> obj = new List<GetAll>();

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    GetAll std = new GetAll
                    {

                        StudentId = (dr["Id"] as int?).GetValueOrDefault(),
                        Firstname = dr["Firstname"].ToString(),
                        Lastname = dr["Lastname"].ToString(),
                        Age = (dr["Age"] as int?).GetValueOrDefault(),
                        Email = dr["Email"].ToString(),
                        Mobile = dr["Mobile"].ToString(),
                        Address = dr["Address"].ToString(),
                        Active = (dr["Active"] as bool?).GetValueOrDefault(),
                        CreatedBy = dr["CreatedBy"].ToString(),
                        CreatedOn = (dr["CreatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedOn = (dr["UpdatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedBy = dr["UpdatedBy"].ToString(),
                        CountryName = dr["CountryName"].ToString(),
                        StatesName = dr["StatesName"].ToString(),
                        CityName = dr["CityName"].ToString(),
                        UnivrsityName = dr["UnivrsityName"].ToString(),
                        CollegeName = dr["CollegeName"].ToString(),
                        ProgramName = dr["ProgramName"].ToString(),
                        Year = (dr["Year"] as int?).GetValueOrDefault(),
                    };

                    obj.Add(std);

                }

                return obj;
            }

        }

        public int INSERT(Students obj)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                DateTime Date = new DateTime();

                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.Parameters.AddWithValue("@ACTION", "INSERT");
                cmd.Parameters.AddWithValue("@Id", obj.StatesId);
                cmd.Parameters.AddWithValue("@Firstname", obj.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", obj.Lastname);
                cmd.Parameters.AddWithValue("@Age", obj.Age);
                cmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@Active", obj.Active);
                cmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedOn", Date.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@UpdatedBy", obj.UnivrsityId);
                cmd.Parameters.AddWithValue("@UpdatedOn", Date.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@CountryId  ", obj.CountryId);
                cmd.Parameters.AddWithValue("@CityId ", obj.CityId);
                cmd.Parameters.AddWithValue("@StatesId", obj.StatesId);
                cmd.Parameters.AddWithValue("@ACTION", "INSERT");

                int i = cmd.ExecuteNonQuery();

                return i;

            }
        }
        public int DELETE(int ID)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                DateTime Date = new DateTime();

                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.Parameters.AddWithValue("@ACTION", "DELETE");
                cmd.Parameters.AddWithValue("@Id", ID);

                int i = cmd.ExecuteNonQuery();

                return i;

            }
        }


        public List<Students> SINGLE(int ID)
        {

            List<Students> stdobj = new List<Students>();

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SINGLE");
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Students std = new Students
                    {

                        StudentId = (dr["Id"] as int?).GetValueOrDefault(),
                        Firstname = dr["Firstname"].ToString(),
                        Lastname = dr["Lastname"].ToString(),
                        Age = (dr["Age"] as int?).GetValueOrDefault(),
                        Email = dr["Email"].ToString(),
                        Mobile = dr["Mobile"].ToString(),
                        Address = dr["Address"].ToString(),
                        Active = (dr["Active"] as bool?).GetValueOrDefault(),
                        CreatedBy = dr["CreatedBy"].ToString(),
                        CreatedOn = (dr["CreatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedOn = (dr["UpdatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedBy = dr["UpdatedBy"].ToString(),
                        CountryId = (dr["CountryId"] as int?).GetValueOrDefault(),
                        StatesId = (dr["StatesId"] as int?).GetValueOrDefault(),
                        CityId = (dr["CityId"] as int?).GetValueOrDefault(),
                        UnivrsityId = (dr["UnivrsityId"] as int?).GetValueOrDefault(),
                        CollegeId = (dr["CollegeId"] as int?).GetValueOrDefault(),
                        ProgramId = (dr["ProgramId"] as int?).GetValueOrDefault(),

                    };
                    stdobj.Add(std);
                }
                return stdobj;
            }
        }
        public int UPDATE(int ID, Students obj)
        {

            using (SqlConnection conn = new SqlConnection(cs))
            {
                DateTime Date = DateTime.Now;


                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Firstname", obj.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", obj.Lastname);
                cmd.Parameters.AddWithValue("@Age", obj.Age);
                cmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@Active", obj.Active);
                cmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedOn", Date.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@UpdatedBy", obj.UnivrsityId);
                cmd.Parameters.AddWithValue("@UpdatedOn", Date.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@CountryId  ", obj.CountryId);
                cmd.Parameters.AddWithValue("@CityId ", obj.CityId);
                cmd.Parameters.AddWithValue("@StatesId", obj.StatesId);
                cmd.Parameters.AddWithValue("@Id", obj.StudentId);
                cmd.Parameters.AddWithValue("@ACTION", "UPDATE");

                int i = cmd.ExecuteNonQuery();

                return i;
            }

        }





    }

}
