using DALL.Models;
using System.Data.SqlClient;
using System.Data;

namespace DALL.Repository
{
    public class AuthenticationRepository
    { 

                string cs = "server=LAPTOP-0C6MBQ3H;database=GPTEST;uid=sa;pwd=123";


        public int LoginAdmin(Admin obj)
        {

            using (SqlConnection conn = new SqlConnection(cs))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("AuthCrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "COUNT_LOGIN");
                cmd.Parameters.AddWithValue("@Name", obj.Username);
                cmd.Parameters.AddWithValue("@Password", obj.Password);

                int recordCount = (int)cmd.ExecuteScalar();

                return recordCount;
            }


        }

    }
}
