using EnglishCenterManagemenent.DAO;
using EnglishCenterManagemenent.DTO;
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
    public partial class UserControlStudents : UserControl
    {
        public FormMain formMainInstance { get; set; }
        private const string TEXTBOX_SEARCH_PLACEHOLDER = "What are you looking for ?";

        private List<Student> studentList = new List<Student>();

        // In case showing only students of a certain class
        int studentsClassId = -1;
        public UserControlStudents()
        {
            InitializeComponent();
            FillDataGridView();
        }

        /// <summary>
        /// In case user wants to display only students that belong to a certain class
        /// </summary>
        /// <param name="classId"></param>
        public void SetStudentsClass(int classId = -1)
        {
            studentsClassId = classId;
        }


        #region Buttons-related methods
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormStudentInfoInput formStudentInfoInput = new FormStudentInfoInput(null);
            formStudentInfoInput.ShowDialog();
            FillDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            Student currentStudent = dataGridView.CurrentRow.Tag as Student;
            DialogResult dialog = ShowAskingMessageBox
                ("Are you sure you want to delete this student: " +
                currentStudent.LastName + " " + currentStudent.FirstName + "?");

            if (dialog == DialogResult.OK)
            {
                StudentDAO.DeleteStudent(currentStudent);
                ShowInfoMessageBox("Student deleted !");
                FillDataGridView();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            FormStudentInfoInput formStudentInfoInput = new FormStudentInfoInput(
                dataGridView.CurrentRow.Tag as Student);

            formStudentInfoInput.ShowDialog();
            FillDataGridView();
        }


        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            formMainInstance.userControlStudentAttendance.BringToFront();
            formMainInstance.labelCurrentUserControl.Text = "Students Attendance";
        }

        private void buttonGrading_Click(object sender, EventArgs e)
        {
            formMainInstance.userControlStudentGrades.SetClass(studentsClassId);
            formMainInstance.userControlStudentGrades.BringToFront();
            formMainInstance.userControlStudentGrades.Focus();
            formMainInstance.labelCurrentUserControl.Text = "Students Grades";
        }

        #endregion

        #region textBosSearch-related methods

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // If we don't check this, the placeholer text becomes part of the filtering, which
            // is not wanted
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER) return;
            if (textBoxSearch.Text.Trim() == "")
            {
                FillDataGridView();
                return;
            }

            dataGridView.Rows.Clear();
            studentList.Clear();

            if (studentsClassId == -1) 
                studentList = StudentDAO.GetFilteredStudent(textBoxSearch.Text);
            else
                studentList = StudentDAO.GetFilteredStudentOfOneClass(textBoxSearch.Text, studentsClassId);

            foreach (Student student in studentList)
            {
                dataGridView.Rows.Add(new object[]
                {
                    StudentDAO.GetStudentClass(student.StudentID),
                    student.LastName,
                    student.FirstName,
                    student.Address,
                    $"{student.DateOfBirth: MM/dd/yyyy}",
                    student.Phone,
                    student.AverageGrade,
                });
                dataGridView.Rows[dataGridView.Rows.Count - 1].Tag = student;
            }
        }

        // Fill the textBoxSearch with placeholder text when user clears the textBox and stop
        // focusing on it
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER)
                textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                textBoxSearch.Text = TEXTBOX_SEARCH_PLACEHOLDER;
        }
        #endregion

        #region Utility methods

        /// <summary>
        /// Fill this user control's datagridview with data from database
        /// </summary>
        private void FillDataGridView()
        {
            dataGridView.Rows.Clear();
            studentList.Clear();

            if (studentsClassId == -1) studentList = StudentDAO.GetAllStudents();
            else studentList = StudentDAO.GetStudentsByClassId(studentsClassId);

            foreach (Student student in studentList)
            {
                dataGridView.Rows.Add(new object[]
                {
                    StudentDAO.GetStudentClass(student.StudentID),
                    student.LastName,
                    student.FirstName,
                    student.Address,
                    $"{student.DateOfBirth: MM/dd/yyyy}",
                    student.Phone,
                    student.AverageGrade,
                });
                dataGridView.Rows[dataGridView.Rows.Count - 1].Tag = student;
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


        #endregion

        private void UserControlStudents_Load(object sender, EventArgs e)
        {
            if (Global.userRole == "teacher")
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
            }
            if (studentsClassId == -1)
            {
                buttonAttendance.Visible = false;
                buttonAdd.Visible = true;
                buttonUpdate.Visible = true;
                buttonDelete.Visible = true;
            }
            else
            {
                buttonAttendance.Visible = true;
                buttonAdd.Visible = false;
                buttonUpdate.Visible = false;
                buttonDelete.Visible = false;
            }
            FillDataGridView();
        }

        private void UserControlStudents_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void UserControlStudents_Leave(object sender, EventArgs e)
        {
            studentsClassId = -1;
        }

        private void UserControlStudents_Enter(object sender, EventArgs e)
        {
            if (studentsClassId == -1)
            {
                buttonAttendance.Visible = false;
                buttonGrading.Visible = false;
                buttonAdd.Visible = true;
                buttonUpdate.Visible = true;
                buttonDelete.Visible = true;
            }
            else
            {
                buttonGrading.Visible = true;
                buttonAttendance.Visible = true;
                buttonAdd.Visible = false;
                buttonUpdate.Visible = false;
                buttonDelete.Visible = false;
            }
            FillDataGridView();
        }
    }
}
