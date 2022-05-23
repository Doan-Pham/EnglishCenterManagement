using EnglishCenterManagemenent.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DAO
{
    public class EmployeeDAO
    {
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.EMPLOYEE");
            foreach (DataRow row in data.Rows)
                employees.Add(new Employee(row));

            return employees;
        }

        public static string GetEmployeeRoleName(int employeeId)
        {
            string roleName = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT Role.Name " +
                "FROM ROLE, EMPLOYEE " +
                "WHERE EMPLOYEE.RoleID = ROLE.RoleID " +
                "      AND EMPLOYEE.EmployeeID = @EmployeeID",
                new object[] { employeeId });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                roleName = row["Name"].ToString();
            }
            return roleName;
        }
    }
}
