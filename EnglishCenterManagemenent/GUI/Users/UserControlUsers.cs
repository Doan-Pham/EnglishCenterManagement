using EnglishCenterManagemenent.DAO;
using EnglishCenterManagemenent.DTO;
using EnglishCenterManagemenent.GUI.Users;
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
    public partial class UserControlUsers : UserControl
    {
        private const string TEXTBOX_SEARCH_PLACEHOLDER = "What are you looking for ?";

        private List<DTO.Users> userList = new List<DTO.Users>();
        public UserControlUsers()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormUserInfoInput formUserInfoInput = new FormUserInfoInput(null);
            formUserInfoInput.ShowDialog();
            FillDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            DTO.Users currentUser = dataGridView.CurrentRow.Tag as DTO.Users;
            DialogResult dialog = ShowAskingMessageBox
                ("Are you sure you want to delete this user: " +
                currentUser.Username + "?");

            if (dialog == DialogResult.OK)
            {
                UsersDAO.DeleteUser(currentUser);
                ShowInfoMessageBox("User deleted !");
                FillDataGridView();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            FormUserInfoInput formUserInfoInput = new FormUserInfoInput(
               dataGridView.CurrentRow.Tag as DTO.Users);

            formUserInfoInput.ShowDialog();
            FillDataGridView();
        }

        /// <summary>
        /// Fill this user control's datagridview with data from database
        /// </summary>
        private void FillDataGridView()
        {
            dataGridView.Rows.Clear();
            userList.Clear();
            
            foreach (DTO.Users user in UsersDAO.GetAllUsers())
            {
                userList.Add(user);
                dataGridView.Rows.Add(new object[]
                {
                    UsersDAO.GetUserRoleName(user.UserID),
                    user.Username,
                    user.Password
                });

                dataGridView.Rows[dataGridView.Rows.Count - 1].Tag = user;
            }
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // If we don't check this, the placeholer text becomes part of the filtering, which
            // is not wanted
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER) return;
            if (textBoxSearch.Text.Trim() == "")
            {
                FillDataGridView();
                return;
            }

            dataGridView.Rows.Clear();
            userList.Clear();
            foreach (DTO.Users user in UsersDAO.GetFilteredUser(textBoxSearch.Text))
            {
                userList.Add(user);
                dataGridView.Rows.Add(new object[]
                {
                    UsersDAO.GetUserRoleName(user.UserID),
                    user.Username,
                    user.Password,
                });
                dataGridView.Rows[dataGridView.Rows.Count - 1].Tag = user;
            }
        }

        // Remove placeholder text from textBoxSearch when user clicks on it to type
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER)
                textBoxSearch.Text = "";
        }

        // Remove placeholder text from textBoxSearch when user clicks on it to type
        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                textBoxSearch.Text = TEXTBOX_SEARCH_PLACEHOLDER;
        }

        // show some type of messages
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
