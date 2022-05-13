using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EnglishCenterManagemenent.DAO;

namespace EnglishCenterManagemenent
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;
            if (Login(username, password))
            {
                //MessageBox.Show("OK");
                FormMain formMain = new FormMain();
                this.Hide();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        bool Login(string username, string password)
        {
            return UsersDAO.Instance.Login(username, password);
        }

    }
}
