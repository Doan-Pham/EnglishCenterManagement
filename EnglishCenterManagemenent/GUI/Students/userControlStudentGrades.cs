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
        public UserControlStudentGrades()
        {
            InitializeComponent();
            float a = 9.957f;
            dataGridView.Rows.Add(new object[] { "Pre1", "2051", "Huỳnh", a.ToString("#.##"), 4.5, 4.5 });
            dataGridView.Rows.Add(new object[] { "Pre1", "2051", "Huỳnh", "9.0", 9.0, 9.0 });
            dataGridView.Rows.Add(new object[] { "Pre1", "2051", "Huỳnh", 9.0, 9.0, 9.0 });
        }
        private void FillDataGridView()
        {
            //dataGridView.Rows.Clear();
            //foreach (Student student in studentList)
            //{
            //    dataGridView.Rows.Add(new object[]
            //    {
            //        StudentDAO.GetStudentClass(student.StudentID),
            //        student.LastName,
            //        student.FirstName,
            //        student.Address,
            //        $"{student.DateOfBirth: MM/dd/yyyy}",
            //        student.Phone,
            //        student.AverageGrade,
            //    });
            //}
        }
    }
}
