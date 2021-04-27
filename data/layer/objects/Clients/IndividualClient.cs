using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    public class IndividualClient : Client
    {
        //Fields
        private string name;
        private string surname;

        //Properties
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        //Constructor
        public IndividualClient(string contactNum, string name, string surname) : base(contactNum)
        {
            this.name = name;
            this.surname = surname;
        }

        //Standards Methods
        public override string ToString()
        {
            return string.Format("IndividualClient({0}, {1}, {2}, {3})", id, name, surname, contactNum);
        }
    }
}
