using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class Package
    {
        //Fields 
        private int _id;
        private Service _service;
        private string _name;
        private string _decription;
        private ServiceLevelAgreement _sla;

        public int id { get => _id; set => _id = value; }
        public Service service { get => _service; set => _service = value; }
        public string name { get => _name; set => _name = value; }
        public string decription { get => _decription; set => _decription = value; }
        public ServiceLevelAgreement sla { get => _sla; set => _sla = value; }

        //Custom Constructor 
        public Package(int ID , string Name,string Description, Service Services,ServiceLevelAgreement sla)
        {
            this.id = ID;
            this.service = Services;
            this.name = Name;
            this.decription = Description;
            this.sla = sla;
        }

       
        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Package p = (Package)obj;
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
