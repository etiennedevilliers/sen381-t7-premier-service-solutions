using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.Layer.Access
{
    class DataHandler : IDisposable
    {
        string conStr = @"    Data Source=45.220.29.247,25565;
                              Database=pss;
                              Integrated Security=false;
                              User ID=app;Password=HAA4h5X$v^CHW5UeNucQf7;";
        static SqlConnection con;
        SqlDataReader read;
        SqlCommand query;

        public DataHandler()
        {
            if(con == null)
            {
                con = new SqlConnection(conStr);
                con.Open();
            }
        }

        public void Dispose()
        {
            if (read != null)
            {
                read.Close();
            }
            if (query != null)
            {
                query.Dispose();
            }
            
            //con.Close();
        }

        internal SqlDataReader Select(string command)
        {
            query = new SqlCommand(command, con);
            read = query.ExecuteReader();

            return read;
        }

        internal int InsertID(string command)
        {
            query = new SqlCommand(command, con);
            query.ExecuteNonQuery();

            query = new SqlCommand("SELECT SCOPE_IDENTITY()", con);
            return Convert.ToInt32(query.ExecuteScalar());
        }

        internal void Insert(string command)
        {
            query = new SqlCommand(command, con);
            query.ExecuteNonQuery();
        }

        internal void Update(string command)
        {
            query = new SqlCommand(command, con);
            query.ExecuteNonQuery();
        }

        internal void Delete(string table, string DeleteCondition)
        {

            query = new SqlCommand("DELETE FROM " + table + " WHERE " + DeleteCondition, con);
            query.ExecuteNonQuery();
        }
    }
}