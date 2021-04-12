using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public abstract class Client
    {

        protected List<ServiceContract> _agreement;
        protected string _address;
        protected string _contactNum;
        protected int _id;

        public List<ServiceContract> agreement { get => _agreement; set => _agreement = value; }
        public string address { get => _address; set => _address = value; }
        public string contactNum { get => _contactNum; set => _contactNum = value; }
        public int id { get => _id; set => _id = value; }

        protected Client(List<ServiceContract> agreement, string address, string contactNum, int id)
        {
            this.agreement = agreement;
            this.address = address;
            this.contactNum = contactNum;
            this.id = id;
        }

        //Standard methods in a class
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Client p = (Client)obj;
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
        //Ruben De Beer
    }
}
