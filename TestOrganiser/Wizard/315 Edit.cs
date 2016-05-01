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
    public partial class _315_Edit : Form
    {
        public int dayNumber;

        public _315_Edit()
        {
            InitializeComponent();
        }

        public void SetAllTheCourses()
        {
            foreach (string s in AppWideInfo.courseNames)
            {
                string sa = (String.IsNullOrWhiteSpace(s)) ? "Course not created or named" : s;
                comboBox1.Items.Add(sa);
                comboBox2.Items.Add(sa);
                comboBox3.Items.Add(sa);
                comboBox4.Items.Add(sa);
            }

            Day._315 day = (Day._315)AppWideInfo.GetDay(dayNumber);

            if (day != null)
            {
                comboBox1.SelectedIndex = day.firstSingle;
                comboBox2.SelectedIndex = day.secondSingle;
                comboBox3.SelectedIndex = day.middleDouble;
                comboBox4.SelectedIndex = day.endDouble;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (dayNumber)
            {
                case 1:
                    label1.Text = "Day: Tuesday";
                    break;
                case 3:
                    label1.Text = "Day: Thursday";
                    break;
                case 6:
                    goto case 1;
                case 8:
                    goto case 3;
                default:
                    label1.Text = "error, close and try again";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Day._315 day = new Day._315();
            day.firstSingle = comboBox1.SelectedIndex;
            day.secondSingle = comboBox2.SelectedIndex;
            day.middleDouble = comboBox3.SelectedIndex;
            day.endDouble = comboBox4.SelectedIndex;
            AppWideInfo.SetDay(day, dayNumber);
            this.Close();
        }
    }
}
