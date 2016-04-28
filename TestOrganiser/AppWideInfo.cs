using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrganiser
{
    public static class AppWideInfo
    {
        public static Semester openSemester = new Semester();
        public static CourseList courseList = new CourseList();

        public static Course[] courseArray = new Course[9];

        public static string[] courseNames = new string[9];

        public static void SetCourse (Course c, int i)
        {
            switch (i)
            {
                case 0:
                    courseList.course1 = c;
                    break;
                case 1:
                    courseList.course2 = c;
                    break;
                case 2:
                    courseList.course3 = c;
                    break;
                case 3:
                    courseList.course4 = c;
                    break;
                case 4:
                    courseList.course5 = c;
                    break;
                case 5:
                    courseList.course6 = c;
                    break;
                case 6:
                    courseList.course7 = c;
                    break;
                case 10:
                    courseList.advocacy = c;
                    break;
                case 11:
                    courseList.modTime = c;
                    break;
                default:
                    Console.Write("Wrong case for static course list setting");
                    break;
            }
            UpdateCourseArray();
        }

        public static void SetDay(Object d, int i)
        {
            switch (i)
            {
                case 0:
                    openSemester.weekA.monday = (Day._330)d;
                    break;
                case 1:
                    openSemester.weekA.tuesday = (Day._315)d;
                    break;
                case 2:
                    openSemester.weekA.wednesday = (Day._310)d;
                    break;
                case 3:
                    openSemester.weekA.thursday = (Day._315)d;
                    break;
                case 4:
                    openSemester.weekA.friday = (Day._330)d;
                    break;
                case 5:
                    openSemester.weekB.monday = (Day._330)d;
                    break;
                case 6:
                    openSemester.weekB.tuesday = (Day._315)d;
                    break;
                case 7:
                    openSemester.weekB.wednesday = (Day._310)d;
                    break;
                case 8:
                    openSemester.weekB.thursday = (Day._315)d;
                    break;
                case 9:
                    openSemester.weekB.friday = (Day._330)d;
                    break;
                default:
                    Console.Write("Wrong case for static day setting");
                    break;
            }
        }

        public static object GetDay(int i)
        {
            switch (i)
            {
                case 0:
                    return openSemester.weekA.monday;
                    
                case 1:
                    return openSemester.weekA.tuesday;
                    
                case 2:
                    return openSemester.weekA.wednesday;
                    
                case 3:
                    return openSemester.weekA.thursday;
                    
                case 4:
                    return openSemester.weekA.friday;
                    
                case 5:
                    return openSemester.weekB.monday;
                    
                case 6:
                    return openSemester.weekB.tuesday;
                    
                case 7:
                    return openSemester.weekB.wednesday;
                    
                case 8:
                    return openSemester.weekB.thursday;
                    
                case 9:
                    return openSemester.weekB.friday;
                default:
                    Console.Write("Wrong case for static day getting");
                    break;
            }
            return null;
        }

        public static void UpdateCourseArray()
        {
            courseArray[0] = courseList.course1;
            courseArray[1] = courseList.course2;
            courseArray[2] = courseList.course3;
            courseArray[3] = courseList.course4;
            courseArray[4] = courseList.course5;
            courseArray[5] = courseList.course6;
            courseArray[6] = courseList.course7;
            courseArray[7] = courseList.advocacy;
            courseArray[8] = courseList.modTime;

            for (int i = 0; i < courseArray.Length; i++)
            {
                courseNames[i] = courseArray[i].ClassName;
            }
        }
    }
}
