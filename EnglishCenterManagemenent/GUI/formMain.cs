using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishCenterManagemenent
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        #region Menu buttons click events

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            userControlDashboard.BringToFront();
            labelCurrentUserControl.Text = "Dashboard";
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            userControlStudentGrades.BringToFront();
            labelCurrentUserControl.Text = "Student Grades";
        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {
            userControlStudentAttendance.BringToFront();
            labelCurrentUserControl.Text = "Student Attendance";
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            userControlStudents.BringToFront();
            labelCurrentUserControl.Text = "Student";
        }

        #endregion

    }
}
