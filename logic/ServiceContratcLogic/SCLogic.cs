using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;
using Logic.CustomExceptions;

namespace Logic
{
    class SCLogic 
    {
        private ServiceContractController SC_Ctr = new ServiceContractController();

        public List<ServiceContract> ViewServiceContrac()
        {
            List<ServiceContract> returnlist = SC_Ctr.Read();

            return returnlist;
        }//View 

        public void EditServiceContract(ServiceContract SC)
        {
            SC_Ctr.Update(SC);
        }//Update 

        public void DeleteServiceContract(ServiceContract SC)
        {
            SC_Ctr.Delete(SC);
        }//Delete

        public void CreateServiceContract(ServiceContract SC)
        {
            SC_Ctr.Create(SC);
        }//Add/Create

        public string GenerateIDentifier(DateTime CreationDate , string LevelOfImportance)
        {
            string Result = "";
            Random RND = new Random();

            string Year = CreationDate.Year.ToString();
            string Random_String = (RND.Next('a', 'z').ToString()).ToUpper();


            Result = Year + Random_String + LevelOfImportance;

            return Result;
        }//Generate identifier

     

        public void AddPackage(Package P , ServiceContract SC)
        {
            SC_Ctr.Add(P,SC);
        }//Add Package to SC 

        public void RemovePackage(Package P, ServiceContract SC)
        {
            SC_Ctr.Remove(P, SC);
        }//Add Package to SC 
    }
}
