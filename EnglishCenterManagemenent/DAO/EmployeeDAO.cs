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
    }
}
