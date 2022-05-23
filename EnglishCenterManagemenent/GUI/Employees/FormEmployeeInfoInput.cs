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

namespace EnglishCenterManagemenent.GUI.Employees
{
    public partial class FormEmployeeInfoInput : Form
    {
        private string roleIdText;
        private string employeeFirstNameText;
        private string employeeLastNameText;
        private string employeeAddressText;
        private string employeeDateOfBirthText;
        private string employeeEmailText;
        private string employeePhoneText;
        private string employeeCertificateText;

        private int employeeId = -1;
        private int roleId;
        private string firstName;
        private string lastName;
        private string address;
        private DateTime? dateOfBirth;
        private string email;
        private string phone;
        private string certificate;

        private Employee currentEmployee = null;

        // This flag decides if user is adding new data or updating old data
        private bool isAddingNewData = true;
        private List<Role> roleList = new List<Role>();

        public FormEmployeeInfoInput(Employee currentEmployee)
        {
            InitializeComponent();

            // Put all the gradescheme's name into combobox and also add the gradescheme to a list
            // for later access
            foreach (Role role in RoleDAO.GetAllRole())
            {
                roleList.Add(role);
                comboBoxRole.Items.Add(role.Name);
            }

            // If user is updating employee, put all the employee's data into controls
            this.currentEmployee = currentEmployee;
            if (currentEmployee != null)
            {
                isAddingNewData = false;
                employeeId = currentEmployee.EmployeeID;
                textBoxEmployeeFirstName.Text = currentEmployee.FirstName;
                textBoxEmployeeLastName.Text = currentEmployee.LastName;
                textBoxEmployeeAddress.Text = currentEmployee.Address;
                dateTimePickerDateOfBirth.Text = $"{currentEmployee.DateOfBirth: MM/dd/yyyy}";
                textBoxEmployeeEmail.Text = currentEmployee.Email.ToString();
                textBoxEmployeePhone.Text = currentEmployee.Phone.ToString();
                textBoxEmployeeCertificate.Text = currentEmployee.Certificate.ToString();

                comboBoxRole.SelectedIndex = comboBoxRole.FindStringExact(
                EmployeeDAO.GetEmployeeRoleName(currentEmployee.EmployeeID));
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
                    roleId = roleList.ElementAt(comboBoxRole.SelectedIndex).RoleID;

                    firstName = employeeFirstNameText;
                    lastName = employeeLastNameText;
                    address = employeeAddressText;
                    dateOfBirth = DateTime.Parse(employeeDateOfBirthText);
                    email = employeeEmailText;
                    phone = employeePhoneText;
                    certificate = employeeCertificateText;

                    Employee newEmployee = new Employee(
                        employeeId, roleId, firstName, lastName, address, dateOfBirth,
                         phone, certificate, email);

                    if (isAddingNewData) EmployeeDAO.AddEmployee(newEmployee);
                    else EmployeeDAO.UpdateEmployee(newEmployee);

                    ShowInfoMessageBox("Employee saved !");
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
            roleIdText = comboBoxRole.Text.Trim(); ;
            employeeFirstNameText = textBoxEmployeeFirstName.Text.Trim();
            employeeLastNameText = textBoxEmployeeLastName.Text.Trim();
            employeeAddressText = textBoxEmployeeAddress.Text.Trim();
            employeeDateOfBirthText = dateTimePickerDateOfBirth.Text.Trim(); ;
            employeeEmailText = textBoxEmployeeEmail.Text.Trim(); ;
            employeePhoneText = textBoxEmployeePhone.Text.Trim().Replace(" ", ""); ;
            employeeCertificateText = textBoxEmployeeCertificate.Text.Trim().Replace(" ", "");

            return
                roleIdText == "" || employeeFirstNameText == "" || employeeLastNameText == "" ||
                employeeDateOfBirthText == "" || employeeEmailText == "" ||
                employeePhoneText == "";
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
