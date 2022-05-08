using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class Student
    {
        private int studentID;
        private int classID;
        private string firstName;
        private string lastName;
        private string address;
        private DateTime dateOfBirth;
        private string phone;
        private float averageGrade;

        public int StudentID { get => studentID; set => studentID = value; }
        public int ClassID { get => classID; set => classID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Phone { get => phone; set => phone = value; }
        public float AverageGrade { get => averageGrade; set => averageGrade = value; }
    }
}
