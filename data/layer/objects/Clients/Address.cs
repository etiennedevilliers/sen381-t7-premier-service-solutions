using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class Address
    {
        //Fields
        private int id;
        private string country;
        private string province;
        private string district;
        private string locality;
        private string postalCode;
        private string streetAddress;
        private string premise;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Country { get => country; set => country = value; }
        public string Province { get => province; set => province = value; }
        public string District { get => district; set => district = value; }
        public string Locality { get => locality; set => locality = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string Premise { get => premise; set => premise = value; }

        //Constructor
        public Address(string country, string province, string district, string locality, string postalCode, string streetAddress, string premise)
        {
            this.country = country;
            this.province = province;
            this.district = district;
            this.locality = locality;
            this.postalCode = postalCode;
            this.streetAddress = streetAddress;
            this.premise = premise;
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
                Address p = (Address) obj;
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
