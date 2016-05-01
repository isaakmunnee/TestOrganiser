using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestOrganiser
{
    public static class FileHandling
    {
        public static void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "semester.dat"));
            SaveData sd = new SaveData();
            sd.sem = AppWideInfo.openSemester;
            sd.cl = AppWideInfo.courseList;
            bf.Serialize(file, sd);
            file.Close();
        }

        public static void Load()
        {
            if(!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "semester.dat")))
            {
                AppWideInfo.openSemester = new Semester();
                AppWideInfo.courseList = new CourseList();
                return;
            }
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "semester.dat"), FileMode.OpenOrCreate);
            SaveData sd = new SaveData();
            sd = (SaveData)bf.Deserialize(file);
            AppWideInfo.openSemester = sd.sem;
            AppWideInfo.courseList = sd.cl;
            AppWideInfo.UpdateCourseArray();
            file.Close();

            if (AppWideInfo.doubleWeekView != null)
                AppWideInfo.doubleWeekView.LoadInfo();
        }

        public static bool SaveFileExists()
        {
            bool b;
            b = File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "semester.dat"));
            return b;
        }
    }

    [Serializable]
    public class SaveData
    {
        public Semester sem;
        public CourseList cl;

        public SaveData() { }
        public SaveData(Semester s, CourseList c)
        {
            sem = s;
            cl = c;
        }
    }
}
