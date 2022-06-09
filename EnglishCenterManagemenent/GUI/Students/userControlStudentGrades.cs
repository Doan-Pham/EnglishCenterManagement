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

            foreach (Test test in ClassDAO.GetClassAllTests(studentsClassId))
            {
                dataGridView.Columns.Add("Column" + columnIndex++, test.Name);
            }

            //dataGridView.Rows.Clear();
            //studentList.Clear();
            //studentList = StudentDAO.GetStudentsByClassId(studentsClassId);

            //DataTable dataTable = ClassDAO.GetClassTestsResult(studentsClassId);

            //foreach (Student student in studentList)
            //{
            //    dataGridView.Rows.Add(new object[]
            //    {
            //        StudentDAO.GetStudentClass(student.StudentID),
            //        student.LastName + " " + student.FirstName,
            //    });
            //}
        }

        private void UserControlStudentGrades_Enter(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
