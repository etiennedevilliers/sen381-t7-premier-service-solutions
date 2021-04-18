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
                "UPDATE {0} SET ServiceContractID={1} WHERE ComplaintRequestID={2}",
                table_name,
                // child.id,
                parent.id
            );

            dh.Update(query);

            dh.Dispose();
        }
        public ServiceContract ReadChild(Request parent) {
            return null;
        }

    }
}