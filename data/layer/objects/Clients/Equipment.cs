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
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        internal EquipmentCategory Category { get => category; set => category = value; }

        //Constructor
        public Equipment(string serialNumber, string manufacturer)
        {
            this.serialNumber = serialNumber;
            this.manufacturer = manufacturer;
        }

        //Standard Methods
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Equipment p = (Equipment) obj;
                return p.Id.Equals(id);
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
