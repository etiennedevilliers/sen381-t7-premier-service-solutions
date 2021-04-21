using System;
using System.Collections.Generic;
using System.Text;
using data.layer.controller;

namespace Data.Layer.Objects
{
    public abstract class Client
    {
        //Fields
        protected int _id;
        protected List<ServiceContract> _contracts;        
        protected string _contactNum;

        //Properties
        public int id { get => _id; set => _id = value; }
        public List<ServiceContract> contracts { get => _contracts; set => _contracts = value; }
        public List<Address> addresses
        {
            get
            {
                AddressController adr = new AddressController(this);
                return adr.Read();
            }
        }
        public string contactNum { get => _contactNum; set => _contactNum = value; }

        //Constructor
        public Client(string contactNum)
        {
            this.contactNum = contactNum;
        }

        //Address Methods
        public void AddAddress(Address adr)
        {
            AddressController adrContr = new AddressController(this);
            adrContr.Create(adr);
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
    }
}
