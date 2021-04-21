using System;
using System.Collections.Generic;

namespace Data.Layer.Access
{
    interface IReadSpecific<T>
    {
        T ReadSpecific(int ID);
    }
}
