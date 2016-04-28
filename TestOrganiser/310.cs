using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser.Day
{
    [Serializable]
    public class _310
    {
        public int firstDoublePeriod;
        public int advocacy;
        public int modTime;
        public int singleOne;
        public int singleTwo;

        public _310() { }
        public _310(int d, int a, int m, int s1, int s2)
        {
            firstDoublePeriod = d;
            advocacy = a;
            modTime = m;
            singleOne = s1;
            singleTwo = s2;
        }
    }
}
