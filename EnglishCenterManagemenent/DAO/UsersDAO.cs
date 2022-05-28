using EnglishCenterManagemenent.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DAO
{
    public class UsersDAO
    {
        private static UsersDAO instance;

        public static UsersDAO Instance 
        {
            get
            {
                if (instance == null) { return instance = new UsersDAO(); }
                return instance;
            }
            set => instance = value;
        }
        public static List<Users> GetAllUsers()
        {
            List<Users> users = new List<Users>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.USERS");
            foreach (DataRow row in data.Rows)
                users.Add(new Users(row));

            return users;
        }

       
        public static string GetUserRoleName(int userID)
        {
            string roleName = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT Role.Name " +
                "FROM ROLE, USERS " +
                "WHERE USERS.RoleID = ROLE.RoleID " +
                "      AND USERS.UserID = @UserID",
                new object[] { userID });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                roleName = row["Name"].ToString();
            }
            return roleName;
        }


        public static void AddUser(Users newUser)
        {
            DataProvider.Instance.ExecuteNonQuery(
                    "INSERT INTO USERS(RoleID, Username, Password) " +
                    "VALUES ( @RoleID , @Username , @Password )",
                    new object[] {
                    newUser.RoleID,
                    newUser.Username,
                    newUser.Password,
                    });
        }
        public static void DeleteUser(Users deletedUser)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM dbo.USERS WHERE UserID = @UserID",
                new object[] { deletedUser.UserID });
        }

        public static List<Users> GetFilteredUser(string info)
        {
            List<Users> users = new List<Users>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.USERS " +
                "WHERE Username LIKE '%" + info + "%' OR Password LIKE '%" + info + "%' " +
                "OR RoleID LIKE '%" + info + "%'");
            foreach (DataRow row in data.Rows)
                users.Add(new Users(row));

            return users;
        }

        public static void UpdateUser(Users newUser)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE USERS " +
                "SET RoleID = @RoleID , Username = @Username , Password = @Password " +
                "WHERE UserID = @UserID",

                new object[] {
                    newUser.RoleID,
                    newUser.Username,
                    newUser.Password,
                    newUser.UserID,
                });
        }

        UsersDAO() { }

        // this used for Login function
        public bool Login(string username, string password)
        {
            string query = "EXEC USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            
            return result.Rows.Count > 0;
        }
    }
}
