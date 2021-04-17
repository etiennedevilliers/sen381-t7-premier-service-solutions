using System;
using System.Collections.Generic;
using System.Text;

namespace data.layer.access
{
    // maintains the many-to-many
    interface IChild <Child, Parent>
    {
        void Set(Child child, Parent parent);

        Child ReadChild(Parent parent);
    }
}
