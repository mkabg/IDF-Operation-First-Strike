using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation___First_Strike.logic
{
    internal class Permision
    {
        public static bool GetSet(string rank)
        {
            if (rank == "general")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
