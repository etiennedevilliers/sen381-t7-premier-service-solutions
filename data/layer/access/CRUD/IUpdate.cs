using System;
using System.Collections.Generic;

namespace Data.Layer.Access
{
    interface IUpdate <T>
    {
        void Update(T obj);
    }
}