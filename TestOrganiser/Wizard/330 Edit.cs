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
    public partial class _330_Edit : Form
    {

        public int dayNumber;

        public _330_Edit()
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
                comboBox5.Items.Add(sa);
                comboBox6.Items.Add(sa);
            }

            Day._330 day = (Day._330)AppWideInfo.GetDay(dayNumber);

            if (day != null)
            {
                comboBox1.SelectedIndex = day.single1;
                comboBox2.SelectedIndex = day.single2;
                comboBox3.SelectedIndex = day.single3;
                comboBox4.SelectedIndex = day.single4;
                comboBox5.SelectedIndex = day.single5;
                comboBox6.SelectedIndex = day.single6;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Day._330 day = new Day._330();
            day.single1 = comboBox1.SelectedIndex;
            day.single2 = comboBox2.SelectedIndex;
            day.single3 = comboBox3.SelectedIndex;
            day.single4 = comboBox4.SelectedIndex;
            day.single5 = comboBox5.SelectedIndex;
            day.single6 = comboBox6.SelectedIndex;
            AppWideInfo.SetDay(day, dayNumber);
            this.Close();
        }

        private void _330_Edit_Load(object sender, EventArgs e)
        {
            switch (dayNumber)
            {
                case 0:
                    label1.Text = "Day: Monday";
                    break;
                case 4:
                    label1.Text = "Day: Friday";
                    break;
                case 5:
                    goto case 0;
                case 9:
                    goto case 4;
                default:
                    label1.Text = "error, close and try again";
                    break;
            }
        }
    }
}
