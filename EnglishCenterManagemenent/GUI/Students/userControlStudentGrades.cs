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
    public partial class UserControlStudentGrades : UserControl
    {
        int studentsClassId = -1;
        private List<Student> studentList = new List<Student>();
        private List<Test> testList = new List<Test>();

        public UserControlStudentGrades()
        {
            InitializeComponent();
            FillDataGridView();
        }

        public void SetClass(int classId)
        {
            this.studentsClassId = classId;
        }

        private void FillDataGridView()
        {
            if (studentsClassId < 0) return;
            dataGridView.Columns.Clear();
            int columnIndex = 1;
            dataGridView.Columns.Add("Column" + columnIndex++, "Class");
            dataGridView.Columns.Add("Column" + columnIndex++, "Student");

            testList = ClassDAO.GetClassAllTests(studentsClassId);
            foreach (Test test in testList)
            {
                dataGridView.Columns.Add("Column" + columnIndex++, test.Name);
            }

            dataGridView.Rows.Clear();
            studentList.Clear();
            studentList = StudentDAO.GetStudentsByClassId(studentsClassId);

            foreach (Student student in studentList)
            {
                List<string> studentTestsResult = new List<string>() ;

                foreach (Test test in testList) 
                {
                    float grade = StudentDAO.GetStudentTestResultByTestId(student.StudentID, test.TestID);
                    if (grade > 0) studentTestsResult.Add(grade.ToString("0.0"));
                }

                // Some placeholder string in case a student doesn't have the result for a specific
                // test yet
                string[] placeholderGrade = new string[10];
                placeholderGrade = Enumerable.Repeat(string.Empty, placeholderGrade.Length).ToArray();
                studentTestsResult.AddRange(placeholderGrade);

                // Add all these test results make sure no test result is left out
                // TODO: Find some way to not hardcode this and add test result based on the 
                // actual number of tests
                dataGridView.Rows.Add(new object[]
                {
                    StudentDAO.GetStudentClass(student.StudentID),
                    student.LastName + " " + student.FirstName,
                    studentTestsResult[0],
                    studentTestsResult[1],
                    studentTestsResult[2],
                    studentTestsResult[3],
                    studentTestsResult[4],
                    studentTestsResult[5],
                    studentTestsResult[6],
                    studentTestsResult[7],
                    studentTestsResult[8],
                    studentTestsResult[9],
                });

                //foreach (Test test in ClassDAO.GetClassAllTests(studentsClassId))
                //{
                //    dataGridView.Columns.Add("Column" + columnIndex++, test.Name);
                //    if (row["DateOfBirth"] != DBNull.Value)
                //        AverageGrade = (float)Convert.ToDouble(row["AverageGrade"].ToString());
                //}
                //{
                //});
            }
        }

        private void UserControlStudentGrades_Enter(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private bool CheckValidGrade(float grade)
        {
            GradeScheme courseGradeScheme = GradeSchemeDAO.GetGradeSchemeByClassId(studentsClassId);

            return
                grade >= courseGradeScheme.LowestGrade &&
                grade <= courseGradeScheme.HighestGrade &&
                grade % courseGradeScheme.Rounding == 0;

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

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Exclude the first 2 columns which contain class and student name
            // TODO: Find some way to avoid hardcoding this
            if (e.ColumnIndex < 2) return;

            float grade;
            if ((!float.TryParse((string)e.FormattedValue, out grade) ||
                !CheckValidGrade(grade)) &&
                (e.FormattedValue.ToString().Trim() != ""))
            {
                dataGridView.CancelEdit();
                ShowErrorMessageBox("Invalid grade! Please input again");
            };
        }
    }
}
