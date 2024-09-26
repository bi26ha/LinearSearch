using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class LinearSearch
    {
        public static int Perform(double SearchValue, List<double> ListToSearch)
        {
            for (int i = 0; i < ListToSearch.Count; i++)
            {
                if (ListToSearch[i] > SearchValue)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Perform(string SearchValue, List<string> listToSearch)
        {
            for (int i = 0; i < listToSearch.Count; i++)
            {
                if (string.Compare(listToSearch[i], SearchValue) == 0)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}
