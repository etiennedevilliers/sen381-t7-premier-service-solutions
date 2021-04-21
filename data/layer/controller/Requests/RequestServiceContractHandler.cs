using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    abstract internal class RequestServiceContractHandler : IChild<ServiceContract, Request>
    {
        private string tableName;
        private string tableIdentifierName;

        public RequestServiceContractHandler(string tableName, string tableIdentifierName) 
        {
            this.tableName = tableName;
            this.tableIdentifierName = tableIdentifierName;
        }

        //Child CRUD
        public void Set(ServiceContract child, Request parent) {

            DataHandler dh = new DataHandler();
            
            string query = string.Format(

                "UPDATE {0} SET ServiceContractID={1} WHERE {2}={3}",
                tableName,
                child.Id,
                tableIdentifierName,
                parent.Id

            );

            dh.Update(query);

            dh.Dispose();
        }

        public ServiceContract ReadChild(Request parent) {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "SELECT SC.ServiceContractID, SC.description, SC.dateFinalised, SC.dateTerminated, SC.cost, status FROM ServiceContract AS SC " +
	                "LEFT JOIN {0} AS R ON R.ServiceContractID = SC.ServiceContractID " +
                    "WHERE R.{1} = {2}",
                tableName,
                tableIdentifierName,
                parent.Id
            );

            SqlDataReader read = dh.Select(query); 
            ServiceContract newSc = null;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newSc = new ServiceContract(
                            read.GetString(1),
                            decimal.ToDouble(read.GetDecimal(4)),
                            read.GetDateTime(2),
                            read.GetDateTime(3),
                            read.GetString(5)
                        );

                    newSc.Id = read.GetInt32(0);
                }
            }

            dh.Dispose();
            return newSc;
        }
    }
}