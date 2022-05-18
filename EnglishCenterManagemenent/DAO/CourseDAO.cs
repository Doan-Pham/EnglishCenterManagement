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
                new object[] { deletedCourse .CourseID});
        }
        public static List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.COURSE");
            foreach (DataRow row in data.Rows)
                courses.Add(new Course(row));

            return courses;
        }
    }
}
