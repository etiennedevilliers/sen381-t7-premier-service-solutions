using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.General
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

        public List<T> GetAddedItems<T>(List<T> oldList, List<T> newList)
        {
            return GetDiffItems(oldList, newList);
        }

        public List<T> GetRemovedItems<T>(List<T> oldList, List<T> newList)
        {
            return GetDiffItems(newList, oldList);
        }

        List<T> GetDiffItems<T>(List<T> parentList, List<T> childList)
        {
            bool found;
            List<T> diffList = new List<T>();

            foreach (T i in childList)
            {
                found = false;

                foreach (T j in parentList)
                {
                    if (i.Equals(j))
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    diffList.Add(i);
                }
            }

            return diffList;
        }
    }
}
