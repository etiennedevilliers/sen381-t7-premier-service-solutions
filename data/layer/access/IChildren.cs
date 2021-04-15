using System;
using System.Collections.Generic;
using System.Text;

namespace data.layer.access
{
    // maintains the many-to-many
    interface IChildren <Child>
    {
        void Add(Child obj);

        void Remove(Child obj);

        List<Child> ReadChildren();
    }
}
