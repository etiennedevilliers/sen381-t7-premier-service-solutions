using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Objects
{
    public class EquipmentCategory
    {
        //Fields
        private int id;
        private string name;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        //Constructors
        public EquipmentCategory(string name)
        {
            this.name = name;
        }

        //Standard Methods

        public override string ToString()
        {
            return Name;
        }
    }
}
