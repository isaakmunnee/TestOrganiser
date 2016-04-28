using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser
{
    [Serializable]
    public class Course
    {
        public string classCode;
        public string ClassName;
        public string TeacherName;
        public string ClassRoom;

        public Course()
        {
            classCode = "";
            ClassName = "";
            TeacherName = "";
            ClassRoom = "";
        }

        public Course(string code, string name, string teacher, string room)
        {
            classCode = code;
            ClassName = name;
            TeacherName = teacher;
            ClassRoom = room;
        }
    }
}
