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
using System.Diagnostics;

namespace EnglishCenterManagemenent.GUI.Classes
{
    public partial class FormClassInfoInput : Form
    {
        private string classNameText;
        private string courseIdText;
        private string classStudentNumText;
        private string classStartDateText;
        private string classEndDateText;
        private string teacherIdText;

        private int classId = -1;
        private int courseId = -1;
        private string name;
        private int numberOfStudents;
        private DateTime? startDate;
        private DateTime? endDate;
        private int teacherId = -1;
        private int oldTeacherId = -1;

        private Class currentClass = null;

        // This flag decides if user is adding new data or updating old data
        private bool isAddingNewData = true;
        private List<Course> courseList = new List<Course>();
        private List<Employee> teacherList = new List<Employee>();

        public FormClassInfoInput(Class currentClass)
        {
            InitializeComponent();

            // Put all the course's name into combobox and also add the course to a list
            // for later access
            foreach (Course course in CourseDAO.GetAllCourses())
            {
                courseList.Add(course);
                comboBoxCourse.Items.Add(course.Name);
            }

            foreach (Employee teacher in EmployeeDAO.GetAllTeachers())
            {
                teacherList.Add(teacher);
                comboBoxTeacher.Items.Add(teacher.LastName + " " + teacher.FirstName);
            }
            comboBoxTeacher.SelectedIndex = 0;

            // If user is updating course, put all the course's data into controls
            this.currentClass = currentClass;
            if (currentClass != null)
            {
                isAddingNewData = false;
                classId = currentClass.ClassID;
                courseId = currentClass.CourseID;
                textBoxClassName.Text = currentClass.Name;
                textBoxNumberOfStudents.Text = currentClass.NumberOfStudents.ToString();
                dateTimePickerStartDate.Text = $"{currentClass.StartDate: MM/dd/yyyy}";
                dateTimePickerEndDate.Text = $"{currentClass.EndDate: MM/dd/yyyy}";

                comboBoxCourse.SelectedIndex = comboBoxCourse.FindStringExact(
                    ClassDAO.GetClassCourseName(currentClass.ClassID));

                comboBoxTeacher.SelectedIndex = Math.Max(0, comboBoxTeacher.FindStringExact(
                    ClassDAO.GetClassTeacherName(currentClass.ClassID)));
                oldTeacherId = teacherList.ElementAt(comboBoxTeacher.SelectedIndex).EmployeeID;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = ShowAskingMessageBox("Are you sure you want to save ?");
            if (dialog == DialogResult.OK)
            {
                if (CheckEmptyFields())
                    ShowErrorMessageBox("Empty input, please fill out all the required fields !");
                else if (!CheckValidStartEndDate())
                    ShowErrorMessageBox("Invalid dates, please check again !");
                else
                {
                    courseId = courseList.ElementAt(comboBoxCourse.SelectedIndex).CourseID;

                    name = classNameText;
                    numberOfStudents = int.Parse(classStudentNumText);
                    startDate = DateTime.Parse(classStartDateText);
                    endDate = DateTime.Parse(classEndDateText);
                    teacherId = teacherList.ElementAt(comboBoxTeacher.SelectedIndex).EmployeeID;

                    Class newClass = new Class(
                        classId, courseId, name,
                        numberOfStudents, startDate, endDate);

                    if (isAddingNewData)
                    {
                        classId = ClassDAO.AddClass(newClass);
                        if (classId == -1)
                        {
                            Debug.WriteLine("[ERROR] Failed to add class through FormClassInfoInput");
                            return;  
                        }
                            
                        ClassDAO.AddClassTeacher(teacherId, classId);
                    }
                    else
                    {
                        ClassDAO.UpdateClass(newClass);
                        ClassDAO.UpdateClassTeacher(oldTeacherId, teacherId, classId);
                    }

                    ShowInfoMessageBox("Class saved !");
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
            courseIdText = comboBoxCourse.Text.Trim(); ;
            classNameText = textBoxClassName.Text.Trim();
            classStudentNumText = textBoxNumberOfStudents.Text.Trim(); ;
            classStartDateText = dateTimePickerStartDate.Text.Trim(); ;
            classEndDateText = dateTimePickerEndDate.Text.Trim().Replace(" ", ""); ;
            teacherIdText = comboBoxTeacher.Text.Trim(); ;

            return
                classNameText == "" || courseIdText == "" || classStartDateText == "" ||
                classEndDateText == "" || teacherIdText == "";
        }

        private bool CheckValidStartEndDate()
        {
            startDate = DateTime.Parse(classStartDateText);
            endDate = DateTime.Parse(classEndDateText);

            return
                startDate < endDate && startDate >= DateTime.Today;

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
