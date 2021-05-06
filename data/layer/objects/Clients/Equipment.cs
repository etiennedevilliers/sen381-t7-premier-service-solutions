using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Objects
{
    public class Equipment
    {
        //Fields
        private int id;
        private string serialNumber;
        private string manufacturer;
        private EquipmentCategory category;

        //Properties
        public int Id { get => id; set => id = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Maufacturer { get => manufacturer; set => manufacturer = value; }
        internal EquipmentCategory Category { get => category; set => category = value; }

        //Constructor
        public Equipment(string serialNumber, string manufacturer)
        {
            this.serialNumber = serialNumber;
            this.manufacturer = manufacturer;
        }
    }
}
