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
        public Course firstDoublePeriod;
        public Course advocacy;
        public Course modTime;
        public Course singleOne;
        public Course singleTwo;

        public _310() { }
        public _310(Course d, Course a, Course m, Course s1, Course s2)
        {
            firstDoublePeriod = d;
            advocacy = a;
            modTime = m;
            singleOne = s1;
            singleTwo = s2;
        }
    }
}
