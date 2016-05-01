using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser.ClassInfo
{
    [Serializable]
    public class Assignment
    {
        public DateTime dueDate;
        public int period;
        public string assignmentName;
        public bool done;

        public Assignment()
        {
            dueDate = new DateTime(2016, 1, 1);
            period = -1;
            assignmentName = "null";
            done = false;
        }

        public Assignment(DateTime due, string name)
        {
            dueDate = due;
            period = -1;
            assignmentName = name;
            done = false;
        }

        public Assignment(DateTime due, string name, int p)
        {
            dueDate = due;
            assignmentName = name;
            period = p;
            done = false;
        }
    }
}
