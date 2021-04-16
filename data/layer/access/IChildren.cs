using System;
using System.Collections.Generic;
using System.Text;

namespace data.layer.access
{
    // maintains the many-to-many
    interface IChildren <Child, Parent>
    {
        void Add(Child child, Parent parent);

        void Remove(Child chils, Parent parent);

        List<Child> ReadChildren(Parent parent);
    }
}
