using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication7
{
    public class task
    {
       
            string constr = "";
            public task()
            {
                constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            }
            public DataSet getdetails(int id)
            {
                DataSet ds = new DataSet();
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.CommandText = "get";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        ada.Fill(ds);
                        ada.Update(ds);
                    }
                }
                catch { }
                return ds;
            }
            public void updatedata(int Id, string Location)
            {
                DataSet ds = new DataSet();
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@Location", Location);
                        cmd.CommandText = "Update";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter uda = new SqlDataAdapter(cmd);
                        uda.Fill(ds);
                        uda.Update(ds);
                    }
                }
                catch { }
            }

            public void insertrow(int Id, string Name, string Course, string Location)
            {
                DataSet ds = new DataSet();
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Course", Course);
                        cmd.Parameters.AddWithValue("@Location", Location);
                        cmd.CommandText = "Procedure";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(ds);
                        sda.Update(ds);

                    }
                }
                catch { }
            }
            public DataSet Getallrecords()
            {
                DataSet ds = new DataSet();
                string selqry = "select * from [Table]";
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        SqlCommand cmd = new SqlCommand(selqry, con);
                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        ada.Fill(ds);

                    }
                }
                catch (Exception ex)
                {

                }
                return ds;
            }
        }



    }
