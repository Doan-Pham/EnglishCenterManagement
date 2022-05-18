using EnglishCenterManagemenent.DAO;
using EnglishCenterManagemenent.DTO;
using EnglishCenterManagemenent.GUI.Courses;
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
    public partial class UserControlCourses : UserControl
    {
        private List<Course> courseList = new List<Course>();
        public UserControlCourses()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void UserControlCourses_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
        private void buttonGradeSchemes_Click(object sender, EventArgs e)
        {
            FormCourseGradeScheme formCourseGradeScheme = new FormCourseGradeScheme();
            formCourseGradeScheme.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCourseInfoInput formCourseInfoInput = new FormCourseInfoInput(null);
            formCourseInfoInput.ShowDialog();
            FillDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            DialogResult dialog = ShowAskingMessageBox
                ("Are you sure you want to delete this course: " + 
                courseList.ElementAt(dataGridView.CurrentCell.RowIndex).Name + "?");

            if (dialog == DialogResult.OK)
            {
                CourseDAO.DeleteCourse(courseList.ElementAt(dataGridView.CurrentCell.RowIndex));
                ShowInfoMessageBox("Course deleted !");
                FillDataGridView();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            FormCourseInfoInput formCourseInfoInput = new FormCourseInfoInput(
                courseList.ElementAt(dataGridView.CurrentCell.RowIndex));

            formCourseInfoInput.ShowDialog();
            FillDataGridView();
        }


        /// <summary>
        /// Fill this user control's datagridview with data from database
        /// </summary>
        private void FillDataGridView()
        {
            dataGridView.Rows.Clear();
            foreach (Course course in CourseDAO.GetAllCourses())
            {
                courseList.Add(course);
                dataGridView.Rows.Add(new object[]
                {
                    course.Name,
                    course.NumberOfLessons,
                    course.NumberOfWeeks,
                    course.Tuition,
                    course.StandardGrade,
                });
            }
        }

        private void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInfoMessageBox(string message)
        {
            MessageBox.Show(message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult ShowAskingMessageBox(string message)
        {
            return MessageBox.Show(message, "INFO",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }


    }
}
