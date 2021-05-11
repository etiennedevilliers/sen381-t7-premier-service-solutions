using Data.Layer.Access;
using Data.Layer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Controller
{
    class EquipmentController : IUpdate<Equipment>
    {
        public void Update(Equipment obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Equipment SET SerialNumber = '{0}', Manufacturer = '{1}', EquipmentCategoryID = {2} WHERE EquipmentID = {3}", obj.SerialNumber, obj.Manufacturer, obj.Category.Id, obj.Id));

            dh.Dispose();
        }
    }
}
