using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser
{
    [Serializable]
    public class Week
    {
        public Day._330 monday = new Day._330();
        public Day._315 tuesday = new Day._315();
        public Day._310 wednesday = new Day._310();
        public Day._315 thursday = new Day._315();
        public Day._330 friday = new Day._330();

        public Week () { }
        public Week (Day._330 mon, Day._315 tue, Day._310 wed, Day._315 thur, Day._330 fri)
        {
            monday = mon;
            tuesday = tue;
            wednesday = wed;
            thursday = thur;
            friday = fri;
        }
    }
}
