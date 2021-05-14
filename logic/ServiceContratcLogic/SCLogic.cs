using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;
using Logic.CustomExceptions;
using Logic;

namespace Logic
{
    class SCLogic 
    {
        GeneralLogic G_L = new GeneralLogic();

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
            Random RND = new Random(26);
            string Character = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            string Year = CreationDate.Year.ToString();

            string Random_String = Character[RND.Next(0,26)].ToString();

            Result = Year + Random_String + LevelOfImportance;

            return Result.PadLeft(12,'0');

        }//Generate identifier

        public void AddPackage(Package P , ServiceContract SC)
        {
            SC_Ctr.Add(P,SC);

        }//Add Package to SC 

        public void RemovePackage(Package P, ServiceContract SC)
        {
            SC_Ctr.Remove(P,SC);

        }//Add Package to SC 
        //Read children 

        public List<Package> ReadChildren(ServiceContract scs)
        {
            return SC_Ctr.ReadChildren(scs);
        }
    }
}
