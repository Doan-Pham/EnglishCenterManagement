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
    public partial class FormStudentInfoInput : Form
    {
        private string classIdText;
        private string studentFirstNameText;
        private string studentLastNameText;
        private string studentAddressText;
        private string studentDateOfBirthText;
        private string studentPhoneText;
        private string studentAverageGradeText;

        private int studentId = -1;
        private int classId;
        private string firstName;
        private string lastName;
        private string address;
        private DateTime? dateOfBirth;
        private string phone;
        private float averageGrade;

        private Student currentStudent = null;
        // This flag decides if user is adding new data or updating old data
        private bool isAddingNewData = true;
        private List<Class> classList = new List<Class>();

        public FormStudentInfoInput(Student currentStudent)
        {
            InitializeComponent();
            // Put all the class's name into combobox for later access

            foreach (Class classes in ClassDAO.GetAllClass())
            {
                classList.Add(classes);
                comboBoxClass.Items.Add(classes.Name);
            }

            // If user is updating student, put all the student's data into controls
            this.currentStudent = currentStudent;
            if (currentStudent != null)
            {
                isAddingNewData = false;
                studentId = currentStudent.StudentID;
                textBoxStudentFirstName.Text = currentStudent.FirstName;
                textBoxStudentLastName.Text = currentStudent.LastName;
                textBoxStudentAddress.Text = currentStudent.Address;
                textBoxStudentPhone.Text = currentStudent.Phone.ToString();
                dateTimePickerStudentDOB.Text = $"{currentStudent.DateOfBirth: MM/dd/yyyy}";

                comboBoxClass.SelectedIndex = comboBoxClass.FindStringExact(
                StudentDAO.GetStudentClass(currentStudent.StudentID));
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
                    classId = classList.ElementAt(comboBoxClass.SelectedIndex).ClassID;

                    firstName = studentFirstNameText;
                    lastName = studentLastNameText;
                    address = studentAddressText;
                    dateOfBirth = DateTime.Parse(studentDateOfBirthText);
                    phone = studentPhoneText;
                    // new student has averageGrade = 0
                    averageGrade = 0f;

                    Student newStudent = new Student(
                        studentId, classId, firstName, lastName, address, dateOfBirth, phone, averageGrade);

                    if (isAddingNewData) StudentDAO.AddStudent(newStudent);
                    else StudentDAO.UpdateStudent(newStudent);

                    ShowInfoMessageBox("Student saved !");
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
            classIdText = comboBoxClass.Text.Trim(); ;
            studentFirstNameText = textBoxStudentFirstName.Text.Trim();
            studentLastNameText = textBoxStudentLastName.Text.Trim();
            studentAddressText = textBoxStudentAddress.Text.Trim();
            studentDateOfBirthText = dateTimePickerStudentDOB.Text.Trim(); ;
            studentPhoneText = textBoxStudentPhone.Text.Trim().Replace(" ", "");

            return
                classIdText == "" || studentFirstNameText == "" || studentLastNameText == "" ||
                studentPhoneText == "" || studentDateOfBirthText == "";          
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
