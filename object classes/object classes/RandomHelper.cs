using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goodboyassignment_classes
{
    static class RandomHelper
    {
        static public bool Randomizer()
        {
        Random random = new Random();
        int trueOrFalse = random.Next(0, 1);
            if (trueOrFalse==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
