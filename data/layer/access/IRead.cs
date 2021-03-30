using System;
using System.Collections.Generic;
using System.Text;

namespace data.layer.access
{
    interface IRead <T>
    {
        List<T> Read();
    }
}
