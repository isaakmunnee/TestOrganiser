using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOrganiser.Wizard
{
    public partial class WizardBegin : Form
    {
        public WizardBegin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.course1;
            one.courseNumber = 0;
            one.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.course2;
            one.courseNumber = 1;
            one.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.course3;
            one.courseNumber = 2;
            one.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.course4;
            one.courseNumber = 3;
            one.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.course5;
            one.courseNumber = 4;
            one.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.course6;
            one.courseNumber = 5;
            one.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.advocacy;
            one.courseNumber = 10;
            one.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.course7;
            one.courseNumber = 6;
            one.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CourseEdit one = new CourseEdit();
            one.thisCourse = AppWideInfo.courseList.modTime;
            one.courseNumber = 11;
            one.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FileHandling.Save();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _330_Edit ed = new _330_Edit();
            ed.dayNumber = 0;
            ed.SetAllTheCourses();
            ed.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            _330_Edit ed = new _330_Edit();
            ed.dayNumber = 4;
            ed.SetAllTheCourses();
            ed.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _330_Edit ed = new _330_Edit();
            ed.dayNumber = 5;
            ed.SetAllTheCourses();
            ed.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            _330_Edit ed = new _330_Edit();
            ed.dayNumber = 9;
            ed.SetAllTheCourses();
            ed.Show();
        }
    }
}
