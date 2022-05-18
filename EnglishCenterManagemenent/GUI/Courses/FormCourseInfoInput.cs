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

        private int courseId = -1;
        private int gradeSchemeId;
        private string name;
        private string description;
        private int numberOfLessons;
        private int numberOfWeeks;
        private int tuition;
        private float standardGrade;

        private Course currentCourse = null;

        // This flag decides if user is adding new data or updating old data
        private bool isAddingNewData = true;
        private List<GradeScheme> gradeSchemeList = new List<GradeScheme>();

        public FormCourseInfoInput(Course currentCourse)
        {
            InitializeComponent();


            foreach (GradeScheme gradeScheme in GradeSchemeDAO.GetAllGradeScheme())
            {
                gradeSchemeList.Add(gradeScheme);
                comboBoxGradeScheme.Items.Add(gradeScheme.Name);
            }
            this.currentCourse = currentCourse;
            if (currentCourse != null)
            {
                isAddingNewData = false;
                courseId = currentCourse.CourseID;
                textBoxCourseName.Text = currentCourse.Name;
                textBoxCourseDescription.Text = currentCourse.Description;
                textBoxCourseLessonNum.Text = currentCourse.NumberOfLessons.ToString();
                textBoxCourseWeekNum.Text = currentCourse.NumberOfWeeks.ToString();
                textBoxCourseTuition.Text = currentCourse.Tuition.ToString();
                textBoxStandardGrade.Text = currentCourse.StandardGrade.ToString();

                comboBoxGradeScheme.SelectedIndex = comboBoxGradeScheme.FindStringExact(
                CourseDAO.GetCourseGradeSchemeName(currentCourse.CourseID));
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = ShowAskingMessageBox("Are you sure you want to save ?");
            if (dialog == DialogResult.OK)
            {
                if (CheckEmptyFields()) 
                    ShowErrorMessageBox("Empty input, please fill out all the required fields !");
                else if (!CheckValidStandardGrade()) 
                    ShowErrorMessageBox("Invalid standard grade, please check again !");
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
                        courseId, gradeSchemeId, name, description, 
                        numberOfLessons, numberOfWeeks, tuition, standardGrade);

                    if (isAddingNewData) CourseDAO.AddCourse(newCourse);
                    else CourseDAO.UpdateCourse(newCourse);

                    ShowInfoMessageBox("Course saved !");
                    this.Close();
                }
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
            courseStandardGradeText = textBoxStandardGrade.Text.Trim().Replace(" ", ""); 

            return
                courseNameText == "" || gradeSchemeIdText == "" ||
                courseLessonNumText == "" || courseWeekNumText == "" ||
                courseTuitionText == "" || courseStandardGradeText == "";
        }

        private bool CheckValidStandardGrade()
        {
            standardGrade = float.Parse(courseStandardGradeText);
            GradeScheme courseGradeScheme = gradeSchemeList
                .ElementAt(comboBoxGradeScheme.SelectedIndex);
            return 
                standardGrade >= courseGradeScheme.LowestGrade &&
                standardGrade <= courseGradeScheme.HighestGrade &&
                standardGrade % courseGradeScheme.Rounding == 0;

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
