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
        public enum Type
        {
            ATAR = 0x00,
            Rec = 0x01,
            Twelvie = 0x02,
            ModTime = 0x03,
            Advo = 0x04,
            Other = 0x05
        }

        public string classCode;
        public string ClassName;
        public string TeacherName;
        public string ClassRoom;
        public Type type;

        public string courseColor;

        public ClassInfo.ClassInfo classInfo;

        public Course()
        {
            classCode = "";
            ClassName = "";
            TeacherName = "";
            ClassRoom = "";
            type = Type.ATAR;
            courseColor = "Control";
            classInfo = new ClassInfo.ClassInfo();
        }

        public Course(string code, string name, string teacher, string room, Type t)
        {
            classCode = code;
            ClassName = name;
            TeacherName = teacher;
            ClassRoom = room;
            type = t;
            courseColor = "Control";
            classInfo = new ClassInfo.ClassInfo();
        }
    }
}
