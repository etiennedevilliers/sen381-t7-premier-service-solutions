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
    class PackageLogic
    {
        private PackageController P_ctr = new PackageController();

        public void Addpackage(Package P)
        {
           
            P_ctr.Create(P);

        }//Add Package 

        public void RemovePackage(Package P)
        {
           
            P_ctr.Delete(P);

        }//Still need to do  //Remove package

        public void EditPackage(Package P)
        {
            PackageController P_Ctr = new PackageController();
            P_Ctr.Update(P);
        }//Edit Package

        public List<Package> ViewPackage()
        {

            List<Package> returnlist = P_ctr.Read();

            return returnlist;

        }//View Package 

        public void SLA_and_Service_In_Package(Package p)
        {
          
        }//Still need to do 
    }
}
