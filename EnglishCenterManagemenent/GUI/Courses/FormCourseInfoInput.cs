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

namespace EnglishCenterManagemenent.GUI.Courses
{
    public partial class FormCourseInfoInput : Form
    {
        private string courseNameText;
        private string gradeSchemeIdText;
        private string courseDescriptionText;
        private string courseLessonNumText;
        private string courseWeekNumText;
        private string courseTuitionText;
        private string courseStandardGradeText;


        private int gradeSchemeId;
        private string name;
        private string description;
        private int numberOfLessons;
        private int numberOfWeeks;
        private int tuition;
        private float standardGrade;

        private List<GradeScheme> gradeSchemeList = new List<GradeScheme>();
        public FormCourseInfoInput()
        {
            InitializeComponent();
            foreach (GradeScheme gradeScheme in GradeSchemeDAO.GetAllGradeScheme())
            {
                gradeSchemeList.Add(gradeScheme);
                comboBoxGradeScheme.Items.Add(gradeScheme.Name);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = ShowAskingMessageBox("Are you sure you want to save ?");
            if (dialog == DialogResult.OK)
            {
                if (CheckEmptyFields()) 
                    ShowErrorMessageBox("Empty input, please fill out all the required fields !");
                else
                {
                    gradeSchemeId = gradeSchemeList
                        .ElementAt(comboBoxGradeScheme.SelectedIndex).GradeSchemeID;

                    name = courseNameText;
                    description = courseDescriptionText;
                    numberOfLessons = int.Parse(courseLessonNumText);
                    numberOfWeeks = int.Parse(courseWeekNumText);
                    tuition = int.Parse(courseTuitionText);
                    standardGrade = float.Parse(courseStandardGradeText);


                    Course newCourse = new Course(
                        -1, gradeSchemeId, name, description, 
                        numberOfLessons, numberOfWeeks, tuition, standardGrade);

                    CourseDAO.AddCourse(newCourse);
                    ShowInfoMessageBox("Course saved !");
                }
                
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckEmptyFields()
        {
            gradeSchemeIdText = comboBoxGradeScheme.Text.Trim(); ;
            courseNameText = textBoxCourseName.Text.Trim();
            courseDescriptionText = textBoxCourseDescription.Text.Trim();
            courseLessonNumText = textBoxCourseLessonNum.Text.Trim(); ;
            courseWeekNumText = textBoxCourseWeekNum.Text.Trim(); ;
            courseTuitionText = textBoxCourseTuition.Text.Trim().Replace(" ", ""); ;
            courseStandardGradeText = textBoxStandardGrade.Text.Trim().Replace(" ", ""); ;

            return
                courseNameText == "" || gradeSchemeIdText == "" ||
                courseLessonNumText == "" || courseWeekNumText == "" ||
                courseTuitionText == "" || courseStandardGradeText == "";
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
