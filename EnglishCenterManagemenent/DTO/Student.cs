using System;
using System.Collections.Generic;
using System.Data;
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

        // The "?" character specifies that variable's value is nullable
        private DateTime? dateOfBirth;
        private string phone;
        private float averageGrade;

        public Student(DataRow row)
        {
            StudentID = (int)row["StudentID"];
            ClassID = (int)row["ClassID"];
            FirstName = (string)row["FirstName"];
            LastName = (string)row["LastName"];
            Address = (string)row["Address"];

            if (row["DateOfBirth"] != DBNull.Value)
                DateOfBirth = (DateTime)row["DateOfBirth"];
            Phone = (string)row["Phone"];
            AverageGrade = (float)Convert.ToDouble(row["AverageGrade"].ToString());
        }

        public Student(int studentID, int roleID, string firstName, string lastName, string address, DateTime? dateOfBirth, string phone, float averageGrade)
        {
            StudentID = studentID;
            ClassID = roleID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            AverageGrade = averageGrade;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public int ClassID { get => classID; set => classID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public DateTime? DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Phone { get => phone; set => phone = value; }
        public float AverageGrade { get => averageGrade; set => averageGrade = value; }
    }
}
