using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Controller;
using Data.Layer.Objects;

namespace Logic
{
    class EquipmentCategoryLogic
    {
        private EquipmentCategoryController EQC = new EquipmentCategoryController();
      
        public void addEquiptmentCatagory(EquipmentCategory EC)
        {
            EQC.Create(EC);
        }  //Add Equiptment Catagory 
    
        public void removeEquiptmentCatagory(EquipmentCategory EC)
        {
            EQC.Delete(EC);
        }//Remove  Catagory 

        public void updateEquiptmentCatagory(EquipmentCategory EC)
        {
            EQC.Update(EC);
        }//Edit Catagory

        public List<EquipmentCategory> viewEquiptmentCatagory()
        {
            List<EquipmentCategory> ReturnList = EQC.Read();
            return ReturnList;
        }//View Catagoties
    }
}
