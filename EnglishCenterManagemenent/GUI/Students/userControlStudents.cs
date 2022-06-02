using EnglishCenterManagemenent.DAO;
using EnglishCenterManagemenent.DTO;
using EnglishCenterManagemenent.GUI.Employees;
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
        public UserControlStudents()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormStudentInfoInput formStudentInfoInput = new FormStudentInfoInput(null);
            formStudentInfoInput.ShowDialog();
            FillDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            FillDataGridView();
            DialogResult dialog = ShowAskingMessageBox
                ("Are you sure you want to delete this employee: " +
                studentList.ElementAt(dataGridView.CurrentCell.RowIndex).FirstName + "?");

            if (dialog == DialogResult.OK)
            {
                StudentDAO.DeleteStudent(studentList.ElementAt(dataGridView.CurrentCell.RowIndex));
                ShowInfoMessageBox("Student deleted !");
                FillDataGridView();
            }
        }

        private void FillDataGridView()
        {
            dataGridView.Rows.Clear();
            studentList.Clear();
            foreach (Student student in StudentDAO.GetAllStudents())
            {
                studentList.Add(student);
                dataGridView.Rows.Add(new object[]
                {
                    student.ClassID,
                    student.LastName,
                    student.FirstName,
                    student.Address,
                    $"{student.DateOfBirth: MM/dd/yyyy}",
                    student.Phone,
                    student.AverageGrade,
                });
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // If we don't check this, the placeholer text becomes part of the filtering, which
            // is not wanted
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER) return;

            dataGridView.Rows.Clear();
            studentList.Clear();
            foreach (Student student in StudentDAO.GetAllStudents())
            {
                studentList.Add(student);
                dataGridView.Rows.Add(new object[]
                {
                    student.ClassID,
                    student.LastName,
                    student.FirstName,
                    student.Address,
                    $"{student.DateOfBirth: MM/dd/yyyy}",
                    student.Phone,
                    student.AverageGrade,
                });
            }
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            formMainInstance.userControlStudentAttendance.BringToFront();
            formMainInstance.labelCurrentUserControl.Text = "Students Attendance";
        }

        private void buttonGrading_Click(object sender, EventArgs e)
        {
            formMainInstance.userControlStudentGrades.BringToFront();
            formMainInstance.labelCurrentUserControl.Text = "Students Grades";
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
