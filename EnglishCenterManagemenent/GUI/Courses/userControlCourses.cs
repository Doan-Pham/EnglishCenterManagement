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

        private void buttonGradeSchemes_Click(object sender, EventArgs e)
        {
            FormCourseGradeScheme formCourseGradeScheme = new FormCourseGradeScheme();
            formCourseGradeScheme.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCourseInfoInput formCourseInfoInput = new FormCourseInfoInput();
            formCourseInfoInput.ShowDialog();
        }
    }
}
