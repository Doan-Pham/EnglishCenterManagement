using EnglishCenterManagemenent.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DAO
{
    public class RoleDAO
    {
        public static List<Role> GetAllRole()
        {
            List<Role> gradeSchemes = new List<Role>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ROLE");
            foreach (DataRow row in data.Rows)
                gradeSchemes.Add(new Role(row));

            return gradeSchemes;
        }
    }
}
