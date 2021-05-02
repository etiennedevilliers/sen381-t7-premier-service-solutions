using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class GeneralLogic
    {
        public string TruncList(string list)
        {
            if (list != "")
            {
                list = list.Substring(0, list.Length - 2);
            }

            return list;
        }
    }
}
