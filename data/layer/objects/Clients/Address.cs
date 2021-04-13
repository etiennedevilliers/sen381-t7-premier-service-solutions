using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class Address
    {
        //Fields
        private int _id;
        private string _country;
        private string _province;
        private string _district;
        private string _locality;
        private string _postalCode;
        private string _streetAddress;
        private string _premise;

        //Properties
        public int id { get => _id; set => _id = value; }
        public string country { get => _country; set => _country = value; }
        public string province { get => _province; set => _province = value; }
        public string district { get => _district; set => _district = value; }
        public string locality { get => _locality; set => _locality = value; }
        public string postalCode { get => _postalCode; set => _postalCode = value; }
        public string streetAddress { get => _streetAddress; set => _streetAddress = value; }
        public string premise { get => _premise; set => _premise = value; }

        //Constructor
        public Address(string country, string province, string district, string locality, string postalCode, string streetAddress, string premise)
        {
            _country = country;
            _province = province;
            _district = district;
            _locality = locality;
            _postalCode = postalCode;
            _streetAddress = streetAddress;
            _premise = premise;
        }

        //Standard Methods
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Address p = (Address) obj;
                return p.id.Equals(this._id);
            }
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
