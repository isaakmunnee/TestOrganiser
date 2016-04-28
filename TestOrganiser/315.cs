using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser.Day
{
    [Serializable]
    public class _315
    {
        public Course firstSingle;
        public Course secondSingle;
        public Course middleDouble;
        public Course endDouble;

        public _315() { }
        public _315(Course first, Course second, Course middle, Course end)
        {
            firstSingle = first;
            secondSingle = second;
            middleDouble = middle;
            endDouble = end;
        }
    }
}
