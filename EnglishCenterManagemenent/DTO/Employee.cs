using System;
using System.Collections.Generic;
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
        private DateTime dateOfBirth;
        private string phone;
        private string certificate;
        private string email;

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int RoleID { get => roleID; set => roleID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Certificate { get => certificate; set => certificate = value; }
        public string Email { get => email; set => email = value; }
    }
}
