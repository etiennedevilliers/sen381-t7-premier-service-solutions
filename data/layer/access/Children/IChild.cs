using System;
using System.Collections.Generic;

namespace Data.Layer.Access
{
    interface IChild <Child, Parent>
    {
        void Set(Child child, Parent parent);

        Child ReadChild(Parent parent);
    }
}
