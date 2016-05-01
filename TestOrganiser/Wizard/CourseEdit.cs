using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.comboBoxColour.Items.Add(c.Name);
            }
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
            thisCourse.courseColor = (comboBoxColour.SelectedItem != null) ? comboBoxColour.SelectedItem.ToString() : "Control";
            AppWideInfo.SetCourse(thisCourse, courseNumber);
            this.Close();
        }

        private void comboBoxColour_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5,
                                rect.Width - 10, rect.Height - 10);
            }
        }
    }
}
