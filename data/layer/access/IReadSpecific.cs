using System;
using System.Collections.Generic;
using System.Text;

namespace data.layer.access
{
    interface IReadSpecific<T>
    {
        T ReadSpecific(int ID);
    }
}
