using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestOrganiser.Wizard;

namespace TestOrganiser.DoubleWeekView
{
    public partial class Double_Week_View : Form
    {
        public Double_Week_View()
        {
            InitializeComponent();
        }

        private void Double_Week_View_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        public void LoadInfo()
        {

            dayOneAdvo.SetInfo(7);
            dayThreeAdvo.SetInfo(7);
            dayThreeModTime.SetInfo(8);
            dayFiveAdvo.SetInfo(7);

            daySixAdvo.SetInfo(7);
            dayEightAdvo.SetInfo(7);
            dayEightPeriodModTime.SetInfo(8);
            dayTenAdvo.SetInfo(7);

            dayOnePeriod1.SetInfo(AppWideInfo.openSemester.weekA.monday.single1);
            dayOnePeriod2.SetInfo(AppWideInfo.openSemester.weekA.monday.single2);
            dayOnePeriod3.SetInfo(AppWideInfo.openSemester.weekA.monday.single3);
            dayOnePeriod4.SetInfo(AppWideInfo.openSemester.weekA.monday.single4);
            dayOnePeriod5.SetInfo(AppWideInfo.openSemester.weekA.monday.single5);
            dayOnePeriod6.SetInfo(AppWideInfo.openSemester.weekA.monday.single6);

            dayTwoPeriod1.SetInfo(AppWideInfo.openSemester.weekA.tuesday.firstSingle);
            dayTwoPeriod2.SetInfo(AppWideInfo.openSemester.weekA.tuesday.secondSingle);
            dayTwoPeriod3.SetInfo(AppWideInfo.openSemester.weekA.tuesday.middleDouble);
            dayTwoPeriod4.SetInfo(AppWideInfo.openSemester.weekA.tuesday.middleDouble);
            dayTwoPeriod5.SetInfo(AppWideInfo.openSemester.weekA.tuesday.endDouble);
            dayTwoPeriod6.SetInfo(AppWideInfo.openSemester.weekA.tuesday.endDouble);

            dayThreePeriod1.SetInfo(AppWideInfo.openSemester.weekA.wednesday.firstDoublePeriod);
            dayThreePeriod2.SetInfo(AppWideInfo.openSemester.weekA.wednesday.firstDoublePeriod);
            dayThreePeriod3.SetInfo(AppWideInfo.openSemester.weekA.wednesday.singleOne);
            dayThreePeriod4.SetInfo(AppWideInfo.openSemester.weekA.wednesday.singleTwo);

            dayFourPeriod1.SetInfo(AppWideInfo.openSemester.weekA.thursday.firstSingle);
            dayFourPeriod2.SetInfo(AppWideInfo.openSemester.weekA.thursday.firstSingle);
            dayFourPeriod3.SetInfo(AppWideInfo.openSemester.weekA.thursday.secondSingle);
            dayFourPeriod4.SetInfo(AppWideInfo.openSemester.weekA.thursday.secondSingle);
            dayFourPeriod5.SetInfo(AppWideInfo.openSemester.weekA.thursday.middleDouble);
            dayFourPeriod6.SetInfo(AppWideInfo.openSemester.weekA.thursday.endDouble);

            dayFivePeriod1.SetInfo(AppWideInfo.openSemester.weekA.friday.single1);
            dayFivePeriod2.SetInfo(AppWideInfo.openSemester.weekA.friday.single2);
            dayFivePeriod3.SetInfo(AppWideInfo.openSemester.weekA.friday.single3);
            dayFivePeriod4.SetInfo(AppWideInfo.openSemester.weekA.friday.single4);
            dayFivePeriod5.SetInfo(AppWideInfo.openSemester.weekA.friday.single5);
            dayFivePeriod6.SetInfo(AppWideInfo.openSemester.weekA.friday.single6);


            daySixPeriod1.SetInfo(AppWideInfo.openSemester.weekB.monday.single1);
            daySixPeriod2.SetInfo(AppWideInfo.openSemester.weekB.monday.single2);
            daySixPeriod3.SetInfo(AppWideInfo.openSemester.weekB.monday.single3);
            daySixPeriod4.SetInfo(AppWideInfo.openSemester.weekB.monday.single4);
            daySixPeriod5.SetInfo(AppWideInfo.openSemester.weekB.monday.single5);
            daySixPeriod6.SetInfo(AppWideInfo.openSemester.weekB.monday.single6);

            daySevenPeriod1.SetInfo(AppWideInfo.openSemester.weekB.tuesday.firstSingle);
            daySevenPeriod2.SetInfo(AppWideInfo.openSemester.weekB.tuesday.secondSingle);
            daySevenPeriod3.SetInfo(AppWideInfo.openSemester.weekB.tuesday.middleDouble);
            daySevenPeriod4.SetInfo(AppWideInfo.openSemester.weekB.tuesday.middleDouble);
            daySevenPeriod5.SetInfo(AppWideInfo.openSemester.weekB.tuesday.endDouble);
            daySevenPeriod6.SetInfo(AppWideInfo.openSemester.weekB.tuesday.endDouble);

            dayEightPeriod1.SetInfo(AppWideInfo.openSemester.weekB.wednesday.firstDoublePeriod);
            dayEightPeriod2.SetInfo(AppWideInfo.openSemester.weekB.wednesday.firstDoublePeriod);
            dayEightPeriod3.SetInfo(AppWideInfo.openSemester.weekB.wednesday.singleOne);
            dayEightPeriod4.SetInfo(AppWideInfo.openSemester.weekB.wednesday.singleTwo);

            dayNinePeriod1.SetInfo(AppWideInfo.openSemester.weekB.thursday.firstSingle);
            dayNinePeriod2.SetInfo(AppWideInfo.openSemester.weekB.thursday.firstSingle);
            dayNinePeriod3.SetInfo(AppWideInfo.openSemester.weekB.thursday.secondSingle);
            dayNinePeriod4.SetInfo(AppWideInfo.openSemester.weekB.thursday.secondSingle);
            dayNinePeriod5.SetInfo(AppWideInfo.openSemester.weekB.thursday.middleDouble);
            dayNinePeriod6.SetInfo(AppWideInfo.openSemester.weekB.thursday.endDouble);

            dayTenPeriod1.SetInfo(AppWideInfo.openSemester.weekB.friday.single1);
            dayTenPeriod2.SetInfo(AppWideInfo.openSemester.weekB.friday.single2);
            dayTenPeriod3.SetInfo(AppWideInfo.openSemester.weekB.friday.single3);
            dayTenPeriod4.SetInfo(AppWideInfo.openSemester.weekB.friday.single4);
            dayTenPeriod5.SetInfo(AppWideInfo.openSemester.weekB.friday.single5);
            dayTenPeriod6.SetInfo(AppWideInfo.openSemester.weekB.friday.single6);

        }

        private void mondayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _330_Edit ed = new _330_Edit();
            ed.dayNumber = 0;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void tuesdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _315_Edit ed = new _315_Edit();
            ed.dayNumber = 1;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void wednesdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _310_Edit ed = new _310_Edit();
            ed.dayNumber = 2;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void thursdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _315_Edit ed = new _315_Edit();
            ed.dayNumber = 3;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void fridayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _330_Edit ed = new _330_Edit();
            ed.dayNumber = 4;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void mondayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _330_Edit ed = new _330_Edit();
            ed.dayNumber = 5;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void bTuesdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _315_Edit ed = new _315_Edit();
            ed.dayNumber = 6;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void wednesdayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _310_Edit ed = new _310_Edit();
            ed.dayNumber = 7;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void bThursdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _315_Edit ed = new _315_Edit();
            ed.dayNumber = 8;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void fridayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _330_Edit ed = new _330_Edit();
            ed.dayNumber = 9;
            ed.SetAllTheCourses();
            ed.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandling.Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandling.Load();
        }

        private void semestersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fromScratchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppWideInfo.Clear();
            WizardBegin wiz = new WizardBegin();
            wiz.Show();
            this.Hide();
            
        }

        private void withCurrentCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppWideInfo.openSemester = new Semester();
            WizardBegin wiz = new WizardBegin();
            wiz.Show();
            this.Hide();
        }

        private void WizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WizardBegin wiz = new WizardBegin();
            wiz.SetupForEditing();
            wiz.ShowDialog();
        }
    }
}
