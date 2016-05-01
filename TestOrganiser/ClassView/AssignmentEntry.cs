using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOrganiser.ClassView
{
    public partial class AssignmentEntry : UserControl
    {

        public ClassInfo.Assignment assignment;

        public AssignmentEntry()
        {
            InitializeComponent();
        }

        private void AssignmentEntry_Load(object sender, EventArgs e)
        {
            //texxt.Text = assignment.assignmentName + " | due: " + assignment.dueDate.ToString("m");
            //checkBox.Checked = assignment.done;
        }
    }
}
