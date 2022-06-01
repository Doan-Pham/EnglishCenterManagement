﻿using EnglishCenterManagemenent.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EnglishCenterManagemenent.DAO
{
    public class ClassDAO
    {
        public static int AddClass(Class newClass)
        {
            int classId = -1;
            object result = DataProvider.Instance.ExecuteScalar(
                "INSERT INTO CLASS(CourseID, Name, NumberOfStudents, " +
                "StartDate, EndDate) " +

                "VALUES ( @CourseID , @Name , @NumberOfStudents , " +
                "@StartDate , @EndDate ) ; " +
                "SELECT CAST(scope_identity() AS int)",

                new object[] {
                    newClass.CourseID,
                    newClass.Name,
                    newClass.NumberOfStudents,
                    newClass.StartDate,
                    newClass.EndDate});

            if (result == null) Debug.WriteLine("[ERROR] ClassDAO.AddClass() failed!");
            else classId = (int)result;
            return classId;
        }

        public static void DeleteClass(Class deletedClass)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM dbo.CLASS WHERE ClassID = @ClassID",
                new object[] { deletedClass.ClassID });
        }

        public static string GetClassCourseName(int classId)
        {
            string courseName = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT COURSE.Name " +
                "FROM COURSE, CLASS " +
                "WHERE CLASS.CourseID = COURSE.CourseID " +
                "      AND CLASS.ClassID = @ClassID",
                new object[] { classId });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                courseName = row["Name"].ToString();
            }
            return courseName;
        }

        public static string GetClassTeacherName(int classId)
        {
            string teacherName = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT EMPLOYEE.LastName, EMPLOYEE.FirstName " +
                "FROM EMPLOYEE, CLASS, CLASS_TEACHER_SCHEDULE " +
                "WHERE CLASS.ClassId = @ClassId" +
                "      AND CLASS.ClassId = CLASS_TEACHER_SCHEDULE.ClassId" +
                "      AND CLASS_TEACHER_SCHEDULE.EmployeeId = EMPLOYEE.EmployeeId " ,
                new object[] { classId });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                teacherName = row["LastName"].ToString() + " " + row["FirstName"].ToString();
            }
            return teacherName;
        }
        public static Course GetClassCourseDetails(int courseId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT COURSE.CourseID, COURSE.Name, COURSE.LowestGrade, " +
                        "COURSE.HighestGrade, COURSE.Rounding, " +
                "FROM COURSE, CLASS " +
                "WHERE CLASS.CourseID = COURSE.CourseID " +
                "      AND CLASS.ClassID = @ClassID",
                new object[] { courseId });

            return new Course(data.Rows[0]);
        }

        public static List<Class> GetFilteredClass(string info)
        {
            List<Class> classList = new List<Class>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.CLASS " +
                "WHERE Name LIKE '%" + info + "%' OR StartDate LIKE '%" + info + "%' " +
                "OR EndDate LIKE '%" + info + "%' OR NumberOfStudents LIKE '%" + info + "%' ");
            foreach (DataRow row in data.Rows)
                classList.Add(new Class(row));

            return classList;
        }
        public static void UpdateClass(Class updatedClass)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE CLASS " +
                "SET CourseID = @CourseID , Name = @Name , NumberOfStudents = @NumberOfStudents , " +
                "    StartDate = @StartDate , EndDate = @EndDate " +
                "WHERE ClassID = @ClassID",

                new object[] {
                    updatedClass.CourseID,
                    updatedClass.Name,
                    updatedClass.NumberOfStudents,
                    updatedClass.StartDate,
                    updatedClass.EndDate,
                    updatedClass.ClassID});
        }

        public static void AddClassTeacher(int teacherId, int classId) 
        {
            DataProvider.Instance.ExecuteNonQuery(
                "INSERT INTO CLASS_TEACHER_SCHEDULE(ClassId, EmployeeId) " +
                "VALUES ( @ClassId , @EmployeeId )",
                new object[] { classId, teacherId, });
        }

        public static void UpdateClassTeacher(int oldTeacherId, int teacherId, int classId)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE CLASS_TEACHER_SCHEDULE(ClassId, EmployeeId) " +
                "SET EmployeeId = @teacherId " +
                "WHERE ClassId = @ClassId AND EmployeeId = @oldTeacherId",
                new object[] { teacherId, classId, oldTeacherId});
        }
        public static List<Class> GetAllClass()
        {
            List<Class> classList = new List<Class>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CLASS");
            foreach (DataRow row in data.Rows)
                classList.Add(new Class(row));

            return classList;
        }
    }
}
