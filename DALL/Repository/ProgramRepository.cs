﻿using DALL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DALL.Repository
{
    public class ProgramRepository
    {
        string cs = "server=LAPTOP-0C6MBQ3H;database=GPTEST;uid=sa;pwd=123";
        public List<Programs> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                List<Programs> std = new List<Programs>();


                conn.Open();
                SqlCommand cmd = new SqlCommand("ProgramCrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Programs obj = new Programs
                    {

                        ProgramId = (dr["ProgramId"] as int?).GetValueOrDefault(),
                        Code = dr["Code"].ToString(),
                        Name = dr["Name"].ToString(),
                        CreatedBy = dr["CreatedBy"].ToString(),
                        CreatedOn = (dr["CreatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedOn = (dr["UpdatedOn"] as DateTime?).GetValueOrDefault(),
                        UpdatedBy = dr["UpdatedBy"].ToString(),
                        UniversityId = (dr["UniversityId"] as int?).GetValueOrDefault()

                    };

                    std.Add(obj);
                }

                return std;
            }
        }
    }
}
