using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class BusinessClient : Client
    {
        //Fields
        private string _businessName;
        private int _id;

        //Properties
        public string businessName { get => _businessName; set => _businessName = value; }
        public int id { get => _id; set => _id = value; }

        //Constructor
        public BusinessClient(int id, List<ServiceContract> agreement, string address, string contactNum, string businessName) 
                        : base(agreement ,address,contactNum,id)
        {
            this.businessName = businessName;
        }
   
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                BusinessClient p = (BusinessClient)obj;
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
