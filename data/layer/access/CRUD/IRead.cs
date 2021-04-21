using System;
using System.Collections.Generic;

namespace Data.Layer.Access
{
    interface IRead <T>
    {
        List<T> Read();
    }
}
