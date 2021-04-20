using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using data.layer.access;
using Data.Layer.Objects;

namespace data.layer.controller 
{
    abstract internal class RequestServiceContractHandler : IChild<ServiceContract, Request>
    {
        private String table_name;
        private String table_identifier_name;

        public RequestServiceContractHandler(String table_name, String table_identifier_name) 
        {
            this.table_name = table_name;
            this.table_identifier_name = table_identifier_name;
        }


         // IChild interface
        public void Set(ServiceContract child, Request parent) {

            DataHandler dh = new DataHandler();
            
            String query = String.Format(

                "UPDATE {0} SET ServiceContractID={1} WHERE {2}={3}",
                table_name,
                child.id,
                table_identifier_name,
                parent.id

            );

            dh.Update(query);

            dh.Dispose();
        }


        public ServiceContract ReadChild(Request parent) {
            DataHandler dh = new DataHandler();

            String query = String.Format(
                "SELECT SC.ServiceContractID, SC.description, SC.dateFinalised, SC.dateTerminated, SC.cost, status FROM ServiceContract AS SC " +
	                "LEFT JOIN {0} AS R ON R.ServiceContractID = SC.ServiceContractID " +
                    "WHERE R.{1} = {2}",
                table_name,
                table_identifier_name,
                parent.id
            );

            SqlDataReader read = dh.Select(query); 
            ServiceContract newSc = null;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newSc = new ServiceContract(
                            read.GetString(1),
                            Decimal.ToDouble(read.GetDecimal(4)),
                            read.GetDateTime(2),
                            read.GetDateTime(3),
                            read.GetString(5)
                        );

                    newSc.id = read.GetInt32(0);
                }
            }

            dh.Dispose();
            return newSc;
        }

    }
}