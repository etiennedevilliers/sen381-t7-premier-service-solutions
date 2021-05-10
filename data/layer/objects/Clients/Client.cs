using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    public abstract class Client
    {
        //Fields
        protected int id;
        protected List<ServiceContract> contracts;
        protected string contactNum;

        //Properties
        public int Id { get => id; set => id = value; }
        public string ClientIdentifier;
        public List<ServiceContract> Contracts { get => contracts; set => contracts = value; }
        public List<Address> addresses
        {
            get
            {
                AddressController adr = new AddressController(this);
                return adr.Read();
            }
        }
        public string ContactNum { get => contactNum; set => contactNum = value; }

        //Constructor
        public Client(string contactNum, string clientIdentifier)
        {
            this.contactNum = contactNum;
            this.ClientIdentifier = clientIdentifier;
        }

        //Address Methods
        public void AddAddress(Address adr)
        {
            AddressController adrContr = new AddressController(this);
            adrContr.Create(adr);
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
                Client p = (Client)obj;
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
