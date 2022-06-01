using EnglishCenterManagemenent.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DAO
{
    public class CourseDAO
    {
        public static void AddCourse(Course newCourse)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "INSERT INTO COURSE(GradeSchemeID, Name, Description, " +
                "NumberOfLessons, NumberOfWeeks, Tuition, StandardGrade)" +

                "VALUES ( @GradeSchemeID , @Name , @Description , " +
                "@NumberOfLessons , @NumberOfWeeks , @Tuition , @StandardGrade )",

                new object[] {
                    newCourse.GradeSchemeID,
                    newCourse.Name,
                    newCourse.Description,
                    newCourse.NumberOfLessons,
                    newCourse.NumberOfWeeks,
                    newCourse.Tuition,
                    newCourse.StandardGrade});
        }

        public static void DeleteCourse(Course deletedCourse)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM dbo.COURSE WHERE CourseID = @CourseID",
                new object[] { deletedCourse.CourseID });
        }

        public static string GetCourseGradeSchemeName(int courseId)
        {
            string gradeSchemeName = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT GradeScheme.Name " +
                "FROM GRADESCHEME, COURSE " +
                "WHERE COURSE.GradeSchemeID = GRADESCHEME.GradeSchemeID " +
                "      AND COURSE.CourseID = @CourseID",
                new object[] { courseId });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                gradeSchemeName = row["Name"].ToString();
            }
            return gradeSchemeName;
        }

        public static GradeScheme GetCourseGradeSchemeDetails(int courseId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT GradeScheme.GradeSchemeID, GradeScheme.Name, GradeScheme.LowestGrade, " +
                        "GradeScheme.HighestGrade, GradeScheme.Rounding, " +
                "FROM GRADESCHEME, COURSE " +
                "WHERE COURSE.GradeSchemeID = GRADESCHEME.GradeSchemeID " +
                "      AND COURSE.CourseID = @CourseID",
                new object[] { courseId });

            return new GradeScheme(data.Rows[0]);
        }

        public static List<Course> GetFilteredCourse(string info){
            List<Course> courses = new List<Course>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.COURSE " +
                "WHERE Name LIKE '%" + info + "%' OR NumberOfLessons LIKE '%" + info + "%' " +
                "OR NumberOfWeeks LIKE '%" + info + "%' OR Tuition LIKE '%" + info + "%' " +
                "OR StandardGrade LIKE '%" + info + "%' ");
            foreach (DataRow row in data.Rows)
                courses.Add(new Course(row));

            return courses;
        }
        public static void UpdateCourse(Course updatedCourse)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE COURSE " +
                "SET GradeSchemeID = @GradeSchemeID , Name = @Name , Description = @Description , " +
                "    NumberOfLessons = @NumberOfLessons , NumberOfWeeks = @NumberOfWeeks , " +
                "    Tuition = @Tuition , StandardGrade = @StandardGrade " +
                "WHERE CourseID = @CourseID",

                new object[] {
                    updatedCourse.GradeSchemeID,
                    updatedCourse.Name,
                    updatedCourse.Description,
                    updatedCourse.NumberOfLessons,
                    updatedCourse.NumberOfWeeks,
                    updatedCourse.Tuition,
                    updatedCourse.StandardGrade,
                    updatedCourse.CourseID});
        }

        public static List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.COURSE");
            foreach (DataRow row in data.Rows)
                courses.Add(new Course(row));

            return courses;
        }

        public static Course GetCourseWithID(int courseId)
        {
            List<Course> courses = new List<Course>();

            Course course = null;
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.COURSE WHERE CourseID = @CourseID", new object[] { courseId });
            foreach (DataRow row in data.Rows)
                course = new Course(row);

            return course;
        }
    }
}
