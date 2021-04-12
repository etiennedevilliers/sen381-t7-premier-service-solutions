using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class IndividualClient : Client
    {
        //Fields
        private string _name;
        private string _surname;

        //Properties
        public string name { get => _name; set => _name = value; }
        public string surname { get => _surname; set => _surname = value; }

        //Constructor
        public IndividualClient(string contactNum, string name, string surname)
                                : base(contactNum) {
            this.surname = name;
            this.name = surname;
            
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                IndividualClient p = (IndividualClient)obj;
                return p.id.Equals(this._id);
            }
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return string.Format("IndividualClient({0}, {1}, {2}, {3})", id, name, surname, contactNum);
        }
        //Ruben De Beer
    }
}
