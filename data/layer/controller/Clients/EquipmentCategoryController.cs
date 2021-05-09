using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    class EquipmentCategoryController : ICreate<EquipmentCategory>, IRead<EquipmentCategory>, IUpdate<EquipmentCategory>, IDelete<EquipmentCategory>
    {
        public int Create(EquipmentCategory obj)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO EquipmentCategory(CategoryName) VALUES ('{0}')",
                obj.Name
            );

            int ID = dh.InsertID(query);

            obj.Id = ID;

            dh.Dispose();

            return ID;
        }

        public void Delete(EquipmentCategory obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("EquipmentCategory", "EquipmentCategoryID = " + obj.Id);

            dh.Dispose();
        }

        public List<EquipmentCategory> Read()
        {
            DataHandler dh = new DataHandler();

            List<EquipmentCategory> catList = new List<EquipmentCategory>();

            SqlDataReader read = dh.Select("SELECT EquipmentCategoryID, CategoryName FROM EquipmentCategory");

            EquipmentCategory category;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    category = new EquipmentCategory(
                        read.GetString(1)
                        );

                    category.Id = read.GetInt32(0);

                    catList.Add(category);
                }
            }

            dh.Dispose();
            return catList;
        }

        public void Update(EquipmentCategory obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.EquipmentCategory SET CategoryName = '{1}' WHERE EquipmentCategoryID = {0} ",
                obj.Id,
                obj.Name
                ));
        }
    }
}
