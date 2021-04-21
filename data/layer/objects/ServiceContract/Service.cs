using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{ 
    public class Service
    {
        //Fields
        private int id;
        private int expectedDuration;
        private string description;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int ExpectedDuration { get => expectedDuration; set => expectedDuration = value; }

        //Constructor
        public Service(string description, int expectedDuration)
        {
            this.expectedDuration = expectedDuration;
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
                Service p = (Service) obj;
                return p.Id.Equals(id);
            }
        }

        public override int GetHashCode() 
        {
            return Id;
        }

        public override string ToString()
        {
            return string.Format("Service({0}, {1}, {2})", id, description, expectedDuration);
        }
    }
}