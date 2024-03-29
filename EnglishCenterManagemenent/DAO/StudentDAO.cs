﻿using EnglishCenterManagemenent.DTO;
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
        public static List<Student> GetStudentsByClassId(int classId)
        {
            List<Student> students = new List<Student>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.STUDENT WHERE ClassId = @ClassId", new object[] {classId});
            foreach (DataRow row in data.Rows)
                students.Add(new Student(row));

            return students;
        }
        public static string GetStudentClass(int studentId)
        {
            string className = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT Class.Name " +
                "FROM CLASS, STUDENT " +
                "WHERE CLASS.ClassID = STUDENT.ClassID " +
                "      AND STUDENT.StudentID = @StudentID",
                new object[] { studentId });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                className = row["Name"].ToString();
            }
            return className;
        }

        public static List<Student> GetFilteredStudent(string info)
        {
            List<Student> students = new List<Student>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.STUDENT " +
                "WHERE FirstName LIKE N'%" + info + "%' OR LastName LIKE N'%" + info + "%' " +
                "OR Address LIKE N'%" + info + "%' OR DateOfBirth LIKE '%" + info + "%' " +
                "OR Phone LIKE '%" + info + "%' OR AverageGrade LIKE '%" + info + "%' ");
            foreach (DataRow row in data.Rows)
                students.Add(new Student(row));

            return students;
        }
        public static List<Student> GetFilteredStudentOfOneClass(string info, int classId)
        {
            List<Student> students = new List<Student>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.STUDENT " +
                "WHERE (FirstName LIKE N'%" + info + "%' OR LastName LIKE N'%" + info + "%' " +
                "OR Address LIKE N'%" + info + "%' OR DateOfBirth LIKE '%" + info + "%' " +
                "OR Phone LIKE '%" + info + "%' OR AverageGrade LIKE '%" + info + "%' ) " +
                "AND ClassID = @ClassID", 
                new object[] {classId});
            foreach (DataRow row in data.Rows)
                students.Add(new Student(row));

            return students;
        }
        public static void AddStudent(Student newStudent)
        {
            DataProvider.Instance.ExecuteScalar(
                    "INSERT INTO STUDENT(ClassID, FirstName, LastName, " +
                    "Address, DateOfBirth, Phone, AverageGrade) " +

                    "VALUES ( @ClassID , @FirstName , @LastName , " +
                    "@Address , @DateOfBirth , @Phone , @AverageGrade )",

                    new object[] {
                    newStudent.ClassID,
                    newStudent.FirstName,
                    newStudent.LastName,
                    newStudent.Address,
                    newStudent.DateOfBirth,
                    newStudent.Phone,
                    newStudent.AverageGrade });
        }

        public static void DeleteStudent(Student deletedStudent)
        {
            // before delete student, must delete test result of that student
            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM TESTRESULT WHERE StudentID = @StudentID ",
                new object[] { deletedStudent.StudentID });

            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM dbo.STUDENT WHERE StudentID = @StudentID",
                new object[] { deletedStudent.StudentID });

        }

        public static void UpdateStudent(Student newStudent)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE STUDENT " +
                "SET ClassID = @ClassID , FirstName = @FirstName , LastName = @LastName , " +
                "    Address = @Address , DateOfBirth = @DateOfBirth , " +
                "    Phone = @Phone , AverageGrade = @AverageGrade " +
                "WHERE StudentID = @StudentID",

                new object[] {
                    newStudent.ClassID,
                    newStudent.FirstName,
                    newStudent.LastName,
                    newStudent.Address,
                    newStudent.DateOfBirth,
                    newStudent.Phone,
                    newStudent.AverageGrade,
                    newStudent.StudentID});
        }

        public static float GetStudentTestResultByTestId(int studentId, int testId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT Grade FROM dbo.TESTRESULT " +
                "WHERE TestId = @TestId AND StudentId = @StudentId", 
                new object[] { testId, studentId });

            float grade = -1;
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                grade = (float)Convert.ToDouble(row["Grade"].ToString());
            }
            return grade;
        }

        public static int GetNumberOfStudents()
        {
            return (int)DataProvider.Instance.ExecuteScalar(
                "SELECT COUNT(*) FROM STUDENT");
        }
    }
}
