﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOrganiser
{
    public partial class WeekPanelEntry : UserControl
    {

        public int classCode;

        public WeekPanelEntry()
        {
            InitializeComponent();
        }

        public void SetInfo(int code)
        {
            classCode = code;
            Course info = AppWideInfo.courseArray[code];
            name.Text = (info == null) ? "null" : info.ClassName;
            teacher.Text = (info == null) ? "null" : info.TeacherName;
            room.Text = (info == null) ? "null" : info.ClassRoom;
            tableLayoutPanel1.BackColor = Color.FromName(info.courseColor ?? "Control");
        }

        private void openClassView(object sender, EventArgs e)
        {
            ClassView.ClassView cv = new ClassView.ClassView();
            cv.thisCourse = AppWideInfo.courseArray[classCode];
            cv.courseCode = classCode;
            cv.ShowDialog();
        }
    }
}
