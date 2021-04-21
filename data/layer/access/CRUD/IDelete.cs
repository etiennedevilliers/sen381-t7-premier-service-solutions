using System;
using System.Collections.Generic;

namespace Data.Layer.Access
{
    interface IDelete <T>
    {
        void Delete(T obj);
    }
}
