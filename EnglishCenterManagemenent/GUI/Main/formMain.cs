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
            userControlUsers.BringToFront();
            labelCurrentUserControl.Text = "Users";
        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {
            userControlCourses.BringToFront();
            labelCurrentUserControl.Text = "Courses";
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            userControlClasses.BringToFront();
            labelCurrentUserControl.Text = "Classes";
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            userControlEmployees.BringToFront();
            labelCurrentUserControl.Text = "Employees";
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            userControlStudents.BringToFront();
            labelCurrentUserControl.Text = "Students";
        }

        #endregion

    }
}
