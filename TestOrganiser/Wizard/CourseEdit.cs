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
    public partial class CourseEdit : Form
    {
        public Course thisCourse;
        public int courseNumber;

        public CourseEdit()
        {
            InitializeComponent();
        }

        private void CourseEdit_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = thisCourse.classCode;
            this.textBox2.Text = thisCourse.ClassName;
            this.textBox3.Text = thisCourse.ClassRoom;
            this.textBox4.Text = thisCourse.TeacherName;
            this.comboBox1.SelectedIndex = (int)thisCourse.type;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            thisCourse.classCode = this.textBox1.Text;
            thisCourse.ClassName = this.textBox2.Text;
            thisCourse.ClassRoom = this.textBox3.Text;
            thisCourse.TeacherName = this.textBox4.Text;
            thisCourse.type = (Course.Type)this.comboBox1.SelectedIndex;
            AppWideInfo.SetCourse(thisCourse, courseNumber);
            this.Close();
        }
    }
}
