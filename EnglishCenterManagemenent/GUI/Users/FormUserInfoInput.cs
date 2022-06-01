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

namespace EnglishCenterManagemenent.GUI.Users
{
    public partial class FormUserInfoInput : Form
    {
        private string roleIdText;
        private string usernameText;
        private string passwordText;

        private int userId = -1;
        private int roleId;
        private string username;
        private string password;

        private DTO.Users currentUser = null;

        // This flag decides if user is adding new data or updating old data
        private bool isAddingNewData = true;
        private List<Role> roleList = new List<Role>();

        public FormUserInfoInput(DTO.Users currentUser)
        {
            InitializeComponent();

            foreach (Role role in RoleDAO.GetAllRole())
            {
                roleList.Add(role);
                comboBoxRole.Items.Add(role.Name);
            }

            this.currentUser = currentUser;
            if (currentUser != null)
            {
                isAddingNewData = false;
                userId = currentUser.UserID;
                textBoxUsername.Text = currentUser.Username;
                textBoxPassword.Text = currentUser.Password;

                comboBoxRole.SelectedIndex = comboBoxRole.FindStringExact(
                UsersDAO.GetUserRoleName(currentUser.UserID));
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

                    username = usernameText;
                    password = passwordText;
                    // is "new DTO.Users" right ?
                    DTO.Users newUser = new DTO.Users(userId, roleId, username, password);

                    if (isAddingNewData) UsersDAO.AddUser(newUser);
                    else UsersDAO.UpdateUser(newUser);

                    ShowInfoMessageBox("User saved !");
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
            usernameText = textBoxUsername.Text.Trim();
            passwordText = textBoxPassword.Text.Trim();
            
            return
                roleIdText == "" || usernameText == "" || passwordText == "";
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
