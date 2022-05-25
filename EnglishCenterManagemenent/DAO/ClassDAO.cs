using EnglishCenterManagemenent.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DAO
{
    public class ClassDAO
    {
        public static void AddClass(Class newClass)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "INSERT INTO CLASS(CourseID, Name, NumberOfStudents, " +
                "StartDate, EndDate, )" +

                "VALUES ( @CourseID , @Name , @NumberOfStudents , " +
                "@StartDate , @EndDate )",

                new object[] {
                    newClass.CourseID,
                    newClass.Name,
                    newClass.NumberOfStudents,
                    newClass.StartDate,
                    newClass.EndDate});
        }

        public static void DeleteClass(Class deletedClass)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM dbo.CLASS WHERE ClassID = @ClassID",
                new object[] { deletedClass.ClassID });
        }

        public static string GetClassCourseName(int courseId)
        {
            string courseName = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT COURSE.Name " +
                "FROM COURSE, CLASS " +
                "WHERE CLASS.CourseID = COURSE.CourseID " +
                "      AND CLASS.ClassID = @ClassID",
                new object[] { courseId });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                courseName = row["Name"].ToString();
            }
            return courseName;
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

        public static List<Class> GetAllClasses()
        {
            List<Class> classList = new List<Class>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CLASS");
            foreach (DataRow row in data.Rows)
                classList.Add(new Class(row));

            return classList;
        }
    }
}
