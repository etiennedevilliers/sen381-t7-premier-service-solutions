using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    public class Service_Level_Agreement
    {
        //Fields
        private int ID;
        private string slaDescription;
        private string level_extent;

        //Properties
        public int ID1 { get => ID; }
        public string SlaDescription { get => slaDescription; set => slaDescription = value; }
        public string Level_extent { get => level_extent; set => level_extent = value; }

        //Custom COnstructor
        public Service_Level_Agreement(int ID, string slaDescription, string level_extent)
        {
            this.ID = ID;
            SlaDescription = slaDescription;
            Level_extent = level_extent;
        }
          
        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Service_Level_Agreement p = (Service_Level_Agreement)obj;
                return p.ID.Equals(this.ID);
            }

        }

        public override int GetHashCode()
        {
            return this.ID;
        } 

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
