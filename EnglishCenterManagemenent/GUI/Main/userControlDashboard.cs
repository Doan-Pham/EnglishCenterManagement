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

namespace EnglishCenterManagemenent.GUI
{
    public partial class UserControlDashboard : UserControl
    {
        public FormMain formMainInstance { get; set; }
        public UserControlDashboard()
        {
            InitializeComponent();
            FillDataButtons();
        }
        
        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            FillDataButtons();
        }

        // click to refresh userControl
        private void UserControlDashboard_Click(object sender, EventArgs e)
        {
            FillDataButtons();
        }
        private void FillDataButtons()
        {
            buttonCourses.Text = CourseDAO.GetNumberOfCourses().ToString();
            buttonClasses.Text = ClassDAO.GetNumberOfClasses().ToString();
            buttonStudents.Text = StudentDAO.GetNumberOfStudents().ToString();
            buttonTeachers.Text = EmployeeDAO.GetNumberOfTeachers().ToString();
        }

        private void UserControlDashboard_Enter(object sender, EventArgs e)
        {
            FillDataButtons();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            formMainInstance.buttonCourse.PerformClick();
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            formMainInstance.buttonClass.PerformClick();
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            formMainInstance.buttonEmployee.PerformClick();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            formMainInstance.buttonStudent.PerformClick();
        }
    }
}
