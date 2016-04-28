using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOrganiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Wizard.WizardBegin wiz = new Wizard.WizardBegin();
            wiz.Show();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!FileHandling.SaveFileExists())
            {
                label1.Text = "Status: Error, no save file found.";
                return;
            }
            FileHandling.Save();
        }
    }
}
