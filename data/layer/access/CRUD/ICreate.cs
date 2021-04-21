using System;
using System.Collections.Generic;

namespace Data.Layer.Access
{
    interface ICreate <T>
    {
        int Create(T obj);
    }
}
