using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    public class ServiceLevelAgreement
    {
        //Fields
        private int id;
        private string description;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }

        //Constructor
        public ServiceLevelAgreement(string description)
        {
            this.description = description;
        }

        //Standard Methods
        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ServiceLevelAgreement p = (ServiceLevelAgreement) obj;
                return p.Id.Equals(id);
            }
        }

        public override int GetHashCode()
        {
            return Id;
        } 

        public override string ToString()
        {
            return string.Format("ServiceLevelAgreement({0}, {1})", id, description);
        }
    }
}