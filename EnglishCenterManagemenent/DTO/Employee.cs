using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class Employee
    {
        private int employeeID;
        private int roleID;
        private string firstName;
        private string lastName;
        private string address;

        // The "?" character specifies that variable's value is nullable
        private DateTime? dateOfBirth;
        private string phone;
        private string certificate;
        private string email;

        public Employee(DataRow row)
        {
            EmployeeID = (int)row["EmployeeID"];
            RoleID = (int)row["RoleID"];
            FirstName = (string)row["FirstName"];
            LastName = (string)row["LastName"];
            Address = (string)row["Address"];

            if (row["DateOfBirth"] != DBNull.Value)
                DateOfBirth = (DateTime)row["DateOfBirth"];

            Phone = (string)row["Phone"];
            Certificate = (string)row["Certificate"];
            Email = (string)row["Email"];
        }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int RoleID { get => roleID; set => roleID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public DateTime? DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Certificate { get => certificate; set => certificate = value; }
        public string Email { get => email; set => email = value; }
    }
}
