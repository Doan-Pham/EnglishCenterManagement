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
    public partial class UserControlEmployees : UserControl
    {
        private const string TEXTBOX_SEARCH_PLACEHOLDER = "What are you looking for ?";

        private List<Employee> employeeList = new List<Employee>();
        public UserControlEmployees()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void UserControlEmployees_Load(object sender, EventArgs e)
        {
            if (Global.userRole == "receptionist")
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;

                if (Global.userRole == "teacher")
                    buttonUpdate.Enabled = false;
            }
            FillDataGridView();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEmployeeInfoInput formEmployeeInfoInput = new FormEmployeeInfoInput(null);
            formEmployeeInfoInput.ShowDialog();
            FillDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

           Employee currentEmployee = dataGridView.CurrentRow.Tag as Employee;
            DialogResult dialog = ShowAskingMessageBox
                ("Are you sure you want to delete this employee: " +
                currentEmployee.FirstName + "?");

            if (dialog == DialogResult.OK)
            {
                EmployeeDAO.DeleteEmployee(currentEmployee);
                ShowInfoMessageBox("Employee deleted !");
                FillDataGridView();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            FormEmployeeInfoInput formEmployeeInfoInput = new FormEmployeeInfoInput(
               dataGridView.CurrentRow.Tag as Employee);

            formEmployeeInfoInput.ShowDialog();
            FillDataGridView();
        }
        /// <summary>
        /// Fill this user control's datagridview with data from database
        /// </summary>
        private void FillDataGridView()
        {
            dataGridView.Rows.Clear();
            employeeList.Clear();
            foreach (Employee employee in EmployeeDAO.GetAllEmployees())
            {
                employeeList.Add(employee);
                dataGridView.Rows.Add(new object[]
                {
                    EmployeeDAO.GetEmployeeRoleName(employee.EmployeeID),
                    employee.LastName,
                    employee.FirstName,
                    employee.Address,
                    $"{employee.DateOfBirth: MM/dd/yyyy}",
                    employee.Phone,
                    employee.Email,
                });
                dataGridView.Rows[dataGridView.Rows.Count - 1].Tag = employee;
            }
        }



        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // If we don't check this, the placeholer text becomes part of the filtering, which
            // is not wanted
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER) return;

            dataGridView.Rows.Clear();
            employeeList.Clear();
            foreach (Employee employee in EmployeeDAO.GetFilteredEmployee(textBoxSearch.Text))
            {
                employeeList.Add(employee);
                dataGridView.Rows.Add(new object[]
                {
                    EmployeeDAO.GetEmployeeRoleName(employee.EmployeeID),
                    employee.LastName,
                    employee.FirstName,
                    employee.Address,
                    $"{employee.DateOfBirth: MM/dd/yyyy}",
                    employee.Phone,
                    employee.Email,
                });
                dataGridView.Rows[dataGridView.Rows.Count - 1].Tag = employee;
            }
        }
        // Remove placeholder text from textBoxSearch when user clicks on it to type
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER)
                textBoxSearch.Text = "";
        }

        // Fill the textBoxSearch with placeholder text when user clears the textBox and stop
        // focusing on it
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
