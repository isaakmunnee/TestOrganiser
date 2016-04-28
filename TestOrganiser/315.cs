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
        public int firstSingle;
        public int secondSingle;
        public int middleDouble;
        public int endDouble;

        public _315() { }
        public _315(int first, int second, int middle, int end)
        {
            firstSingle = first;
            secondSingle = second;
            middleDouble = middle;
            endDouble = end;
        }
    }
}
