using System;
using System.Collections.Generic;
using System.Text;

namespace data.layer.access
{
    interface IDelete <T>
    {
        void Delete(T obj);
    }
}
