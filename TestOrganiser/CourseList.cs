using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser
{
    [Serializable]
    public class CourseList
    {
        public Course course1;
        public Course course2;
        public Course course3;
        public Course course4;
        public Course course5;
        public Course course6;
        public Course course7;

        public Course modTime;
        public Course advocacy;
        public Course privateStudy;

        public CourseList()
        {
            course1 = new Course();
            course2 = new Course();
            course3 = new Course();
            course4 = new Course();
            course5 = new Course();
            course6 = new Course();
            course7 = new Course();
            modTime = new Course();
            advocacy = new Course();
            privateStudy = new Course();
        }
    }
}
