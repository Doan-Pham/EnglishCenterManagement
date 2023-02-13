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

        public static void AddEmployee(Employee newEmployee)
        {
            DataProvider.Instance.ExecuteNonQuery(
                    "INSERT INTO EMPLOYEE(RoleID, FirstName, LastName, " +
                    "Address, DateOfBirth, Phone, Certificate, Email) " +

                    "VALUES ( @RoleID , @FirstName , @LastName , " +
                    "@Address , @DateOfBirth , @Phone , @Certificate , @Email )",

                    new object[] {
                    newEmployee.RoleID,
                    newEmployee.FirstName,
                    newEmployee.LastName,
                    newEmployee.Address,
                    newEmployee.DateOfBirth,
                    newEmployee.Phone,
                    newEmployee.Certificate,
                    newEmployee.Email});
        }

        public static List<Employee> GetAllTeachers()
        {
            List<Employee> teachers = new List<Employee>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.EMPLOYEE " +
                "WHERE RoleID = (SELECT RoleID FROM ROLE WHERE Name = 'teacher') ");
            foreach (DataRow row in data.Rows)
                teachers.Add(new Employee(row));

            return teachers;
        }

        public static void DeleteEmployee(Employee deletedEmployee)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM dbo.EMPLOYEE WHERE EmployeeID = @EmployeeID",
                new object[] { deletedEmployee.EmployeeID });
        }
        public static List<Employee> GetFilteredEmployee(string info)
        {
            List<Employee> employees = new List<Employee>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.EMPLOYEE " +
                "WHERE FirstName LIKE N'%" + info + "%' OR LastName LIKE N'%" + info + "%' " +
                "OR Address LIKE N'%" + info + "%' OR DateOfBirth LIKE '%" + info + "%' " +
                "OR Phone LIKE '%" + info + "%' OR Certificate LIKE N'%" + info + "%' " +
                "OR Email LIKE '%" + info + "%' ");
            foreach (DataRow row in data.Rows)
                employees.Add(new Employee(row));

            return employees;
        }
        public static void UpdateEmployee(Employee newEmployee)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE EMPLOYEE " +
                "SET RoleID = @RoleID , FirstName = @FirstName , LastName = @LastName , " +
                "    Address = @Address , DateOfBirth = @DateOfBirth , " +
                "    Phone = @Phone , Certificate = @Certificate , Email = @Email " +
                "WHERE EmployeeID = @EmployeeID",

                new object[] {
                    newEmployee.RoleID,
                    newEmployee.FirstName,
                    newEmployee.LastName,
                    newEmployee.Address,
                    newEmployee.DateOfBirth,
                    newEmployee.Phone,
                    newEmployee.Certificate,
                    newEmployee.Email,
                    newEmployee.EmployeeID});
        }

        public static int GetNumberOfTeachers()
        {
            return (int)DataProvider.Instance.ExecuteScalar(
                "SELECT COUNT(*) FROM EMPLOYEE " +
                "WHERE RoleID = (SELECT RoleID FROM ROLE WHERE Name = 'teacher')");
        }

        public static int GetEmployeeIdByUserName(string username)
        {
            int employeeId = -1;
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT EmployeeID " +
                "FROM EMPLOYEE, USERS " +
                "WHERE USERS.Username = @Username " +
                "AND EMPLOYEE.UserID = USERS.UserID ",
                new object[] { username });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                employeeId = (int)row["EmployeeID"];
            }
            return employeeId;
        }
    }
}
