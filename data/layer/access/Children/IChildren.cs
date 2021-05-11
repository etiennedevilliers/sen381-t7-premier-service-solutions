using System;
using System.Collections.Generic;

namespace Data.Layer.Access
{
    // maintains the many-to-many
    interface IChildren <Child, Parent>
    {
        void Add(Child child, Parent parent);

        void Remove(Child child, Parent parent);

        List<Child> ReadChildren(Parent parent);
    }
}
