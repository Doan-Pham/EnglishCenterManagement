using EnglishCenterManagemenent.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DAO
{
    public class StudentDAO
    {
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.STUDENT");
            foreach (DataRow row in data.Rows)
                students.Add(new Student(row));

            return students;
        }

        public static void AddStudent(Student newStudent)
        {
            DataProvider.Instance.ExecuteNonQuery(
                    "INSERT INTO STUDENT(ClassID, LastName, FirstName, " +
                    "Address, DateOfBirth, Phone, AverageGrade) " +
                    "VALUES ( @ClassID, @LastName, @FirstName, " +
                    "@Address, @DateOfBirth, @Phone, @AverageGrade)",

                    new object[] {
                    newStudent.ClassID,
                    newStudent.FirstName,
                    newStudent.LastName,
                    newStudent.Address,
                    newStudent.DateOfBirth,
                    newStudent.Phone,
                    newStudent.AverageGrade });
        }
    }
}
