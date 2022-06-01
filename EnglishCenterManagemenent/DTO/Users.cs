using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class Users
    {
        private int userID;
        private int roleID;
        private string username;
        private string password;

        public Users(DataRow row)
        {
            UserID = (int)row["UserID"];
            RoleID = (int)row["RoleID"];
            Username = (string)row["Username"];
            Password = (string)row["Password"];
        }

        public Users(int userID, int roleID, string username, string password)
        {
            UserID = userID;
            RoleID = roleID;
            Username = username;
            Password = password;
        }

        public int UserID { get => userID; set => userID = value; }
        public int RoleID { get => roleID; set => roleID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
