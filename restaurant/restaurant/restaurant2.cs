﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace conn
{
    class restaurant2
    {
        public void show()
        {
            string constr = @"Data Source=BLT1068\SQLEXPRESS2014;Initial Catalog=EMPLOYEEDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    string querystr = "select * from restaurant1";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
             
            }
        }
        public void insert()
        {
            string constr = @"Data Source=BLT1068\SQLEXPRESS2014;Initial Catalog=EMPLOYEEDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    // string querystr = "insert into restaurent(res_name,res_location,res_timings,res_close) ";
                    string r = Console.ReadLine();
                    // string sar = querystr + r;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(r, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
        }
    }

}