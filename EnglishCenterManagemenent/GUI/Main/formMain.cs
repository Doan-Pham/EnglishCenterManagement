﻿using EnglishCenterManagemenent.DAO;
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
    public partial class FormMain : Form
    {
        public FormMain(string username, string password)
        {
            InitializeComponent();
            labelCurrentUser.Text = username;
            selectedPanel.StateCommon.Color1 = Color.Orange;
            Global.userRole = UsersDAO.GetUserRoleName(username, password);
        }

        // Check role of user

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Global.userRole == "teacher")
            {
                buttonUser.Enabled = false;
                //buttonCourse.Enabled = false;
                buttonEmployee.Enabled = false;
                
            }
            else if (Global.userRole == "receptionist")
            {
                buttonUser.Enabled = false;
            }
        }

        #region Menu buttons click events

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            userControlDashboard.BringToFront();
            labelCurrentUserControl.Text = "Dashboard";
            selectedPanel.Height = buttonDashboard.Height;
            selectedPanel.Top = buttonDashboard.Top;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            userControlUsers.BringToFront();
            labelCurrentUserControl.Text = "Users";
            selectedPanel.Height = buttonUser.Height;
            selectedPanel.Top = buttonUser.Top;
        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {
            userControlCourses.BringToFront();
            labelCurrentUserControl.Text = "Courses";
            selectedPanel.Height = buttonCourse.Height;
            selectedPanel.Top = buttonCourse.Top;
            userControlCourses.Focus();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            userControlClasses.BringToFront();
            labelCurrentUserControl.Text = "Classes";
            selectedPanel.Height = buttonClass.Height;
            selectedPanel.Top = buttonClass.Top;
            userControlClasses.formMainInstance = this;
            userControlClasses.Focus();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            userControlEmployees.BringToFront();
            labelCurrentUserControl.Text = "Employees";
            selectedPanel.Height = buttonEmployee.Height;
            selectedPanel.Top = buttonEmployee.Top;
            userControlEmployees.Focus();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            userControlStudents.BringToFront();
            labelCurrentUserControl.Text = "Students";
            userControlStudents.formMainInstance = this;
            selectedPanel.Height = buttonStudent.Height;
            selectedPanel.Top = buttonStudent.Top;
            userControlStudents.Focus();
        }

        // logout and show formLogin
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }

        }


        #endregion

        
    }
}
