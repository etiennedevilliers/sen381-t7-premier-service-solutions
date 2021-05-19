using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;

namespace Logic.CustomExceptions
{ 
    [Serializable]
    class ServiceExistsException : Exception
    {

        //Create a constructor for this class with a error message parameter

        Package package;
        public ServiceExistsException(Package package) : base(String.Format("Service Exists in package {0}", package.Name))
        {
            this.package = package;
        }

    }
}
