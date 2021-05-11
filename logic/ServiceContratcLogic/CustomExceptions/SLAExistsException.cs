using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Data.Layer.Objects;

namespace Logic.CustomExceptions
{
    [Serializable]
    class SLAExistsException : Exception
    {

        //Create a constructor for this class with a error message parameter

        Package package;
        public SLAExistsException(Package package) : base(String.Format("SLA Exists in package {0}", package.Name))
        {
            this.package = package;
        }

    }
}
