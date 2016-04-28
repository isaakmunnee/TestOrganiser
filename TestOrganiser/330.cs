using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser.Day
{
    [Serializable]
    public class _330
    {
        public int advocacy;
        public int single1;
        public int single2;
        public int single3;
        public int single4;
        public int single5;
        public int single6;

        public _330 () { }
        public _330(int advo, int s1, int s2, int s3, int s4, int s5, int s6)
        {
            advocacy = advo;
            single1 = s1;
            single2 = s2;
            single3 = s3;
            single4 = s4;
            single5 = s5;
            single6 = s6;
        }
    }
}
