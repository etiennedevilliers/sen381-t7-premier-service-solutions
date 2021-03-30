using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Data.Layer.Objects
{
    class DataHandler : IDisposable
    {
        string conStr = "";
        SqlConnection con;
        SqlDataReader read;
        SqlCommand query;

        public DataHandler()
        {
            con = new SqlConnection(conStr);
            con.Open();
        }

        public void Dispose()
        {            
            read.Close();
            query.Dispose();
            con.Close();
        }

        public SqlDataReader Select(string table, string condition = "")
        {                     
            query = new SqlCommand("SELECT * FROM " + table + " " + condition, con);
            read = query.ExecuteReader();

            return read;
        }

        public void Insert(string command)
        {
            query = new SqlCommand(command, con);
            query.ExecuteNonQuery();
        }

        public void Update(string command)
        {
            query = new SqlCommand(command, con);
            query.ExecuteNonQuery();
        }

        public void Delete(string table, string DeleteCondition)
        {
            query = new SqlCommand("DELETE FROM " + table + " " + DeleteCondition, con);
            query.ExecuteNonQuery();
        }
    }
}