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
    public partial class _310_Edit : Form
    {

        public int dayNumber;

        public _310_Edit()
        {
            InitializeComponent();
        }

        public void SetAllTheCourses()
        {
            foreach (string s in AppWideInfo.courseNames)
            {
                string sa = (String.IsNullOrWhiteSpace(s)) ? "Course not created or named" : s;
                comboBox1.Items.Add(sa);
                comboBox3.Items.Add(sa);
                comboBox4.Items.Add(sa);
            }

            Day._310 day = (Day._310)AppWideInfo.GetDay(dayNumber);

            if (day != null)
            {
                comboBox1.SelectedIndex = day.firstDoublePeriod;
                comboBox3.SelectedIndex = day.singleOne;
                comboBox4.SelectedIndex = day.singleTwo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Day._310 day = new Day._310();
            day.firstDoublePeriod = comboBox1.SelectedIndex;
            day.singleOne = comboBox3.SelectedIndex;
            day.singleTwo = comboBox4.SelectedIndex;
            AppWideInfo.SetDay(day, dayNumber);
            this.Close();
        }
    }
}
