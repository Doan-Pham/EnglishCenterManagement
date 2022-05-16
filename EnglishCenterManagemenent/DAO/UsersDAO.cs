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
        UsersDAO() { }
        public bool Login(string username, string password)
        {
            string query = "EXEC USP_Login @username , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            
            return result.Rows.Count > 0;
        }
    }
}
