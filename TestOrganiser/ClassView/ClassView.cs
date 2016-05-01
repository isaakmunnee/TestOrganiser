using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOrganiser.ClassView
{
    public partial class ClassView : Form
    {

        public Course thisCourse;
        public int courseCode;

        public ClassView()
        {
            InitializeComponent();
        }

        private void ClassView_Load(object sender, EventArgs e)
        {
            LoadMe();
        }

        public void LoadMe()
        {
            classNamePanel.BackColor = Color.FromName(thisCourse.courseColor);
            className.Text = thisCourse.ClassName;
            this.textBox1.Text = thisCourse.classInfo.comments;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thisCourse.classInfo = new ClassInfo.ClassInfo();
            this.thisCourse.classInfo.comments = textBox1.Text;
            AppWideInfo.SetCourse(thisCourse, courseCode);
            FileHandling.Save();
        }
    }
}
