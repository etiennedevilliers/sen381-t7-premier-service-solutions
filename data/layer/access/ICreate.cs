﻿using System;
using System.Collections.Generic;
using System.Text;

namespace data.layer.access
{
    interface ICreate <T>
    {
        int Create(T obj);
    }
}