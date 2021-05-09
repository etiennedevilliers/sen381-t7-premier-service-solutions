﻿using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    public class Package
    {
        //Fields 
        private int id;
        private Service service;
        private string name;
        private string description;
        private ServiceLevelAgreement sla;
        private int equiptment;

        //Properties
        public int Id { get => id; set => id = value; }
        public Service Service { get => service; set => service = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public ServiceLevelAgreement Sla { get => sla; set => sla = value; }
        public int Equiptment { get => equiptment; set => equiptment = value; }

        //Constructor 
        public Package(string name, string description, Service service, ServiceLevelAgreement sla, int eqt)
        {
            this.service = service;
            this.name = name;
            this.description = description;
            this.sla = sla;
            this.Equiptment = eqt;
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
                Package p = (Package)obj;
                return p.Id.Equals(id);
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return string.Format("Package({0}, {1}, {2}, {3}, {4})", id, name, description, service, sla, equiptment);
        }
    }
}