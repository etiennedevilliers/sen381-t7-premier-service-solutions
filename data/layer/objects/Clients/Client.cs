using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    public abstract class Client
    {
        //Fields
        protected int id;
        protected string contactNum;

        //Properties
        public int Id { get => id; set => id = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }
        public List<ClientServiceContract> contracts
        {
            get
            {
                return new ClientController().serviceContract.ReadChildren(this);
            }
        }
        public List<Address> addresses
        {
            get
            {
                return new ClientController().address.ReadChildren(this);
            }
        }
        public List<Equipment> equipment
        {
            get
            {
                return new ClientController().equipment.ReadChildren(this);
            }
        }

        //Constructor
        public Client(string contactNum)
        {
            this.contactNum = contactNum;
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
