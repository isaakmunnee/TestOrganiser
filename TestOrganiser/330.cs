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
        public Course advocacy;
        public Course single1;
        public Course single2;
        public Course single3;
        public Course single4;
        public Course single5;
        public Course single6;

        public _330 () { }
        public _330(Course advo, Course s1, Course s2, Course s3, Course s4, Course s5, Course s6)
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
