using System;
using System.Collections.Generic;
using System.Text;

namespace data.layer.access
{
    interface IUpdate <T>
    {
        void Update(T obj);
    }
}