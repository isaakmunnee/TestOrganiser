using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser
{
    [Serializable]
    public class Semester
    {
        public Week weekA = new Week();
        public Week weekB = new Week();

        public Semester() { }
        public Semester(Week a, Week b)
        {
            weekA = a;
            weekB = b;
        }
    }
}
