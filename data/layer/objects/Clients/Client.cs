using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    public abstract class Client
    {
        //Fields
        protected int id;
        protected string clientIdentifier;
        protected string contactNum;
        protected List<ClientServiceContract> contracts = null;
        protected List<Address> addresses = null;
        protected List<Equipment> equipment = null;

        //Properties
        public int Id { get => id; set => id = value; }
        public string ClientIdentifier { get => clientIdentifier; set => clientIdentifier = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }
        public List<ClientServiceContract> Contracts
        {
            get
            {
                if (contracts == null)
                {
                    contracts = new ClientController().serviceContract.ReadChildren(this);
                    return contracts;
                }
                else
                {
                    return contracts;
                }
            }

            set => contracts = value;
        }
        public List<Address> Addresses
        {
            get
            {
                if (addresses == null)
                {
                    addresses = new ClientController().address.ReadChildren(this);
                    return addresses;
                }
                else
                {
                    return addresses;
                }
            }

            set => addresses = value;
        }
        public List<Equipment> Equipment
        {
            get
            {
                if (equipment == null)
                {
                    equipment = new ClientController().equipment.ReadChildren(this);
                    return equipment;
                }
                else
                {
                    return equipment;
                }
            }

            set => equipment = value;
        }

        //Constructor
        public Client(string contactNum, string clientIdentifier)
        {
            this.contactNum = contactNum;
            this.ClientIdentifier = clientIdentifier;
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
