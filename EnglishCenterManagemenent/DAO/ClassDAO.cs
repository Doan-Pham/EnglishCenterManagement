using EnglishCenterManagemenent.DTO;
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
            // before delete class, must delete tests related to class
            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM TEST WHERE ClassID = @ClassID",
                new object[] { deletedClass.ClassID });

            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM dbo.CLASS WHERE ClassID = @ClassID",
                new object[] { deletedClass.ClassID });
        }

        public static void DeleteClassTeachers(int classId)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "DELETE FROM dbo.CLASS_TEACHER_SCHEDULE WHERE ClassID = @ClassID",
                new object[] { classId });
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
                "WHERE Name LIKE N'%" + info + "%' OR StartDate LIKE '%" + info + "%' " +
                "OR EndDate LIKE '%" + info + "%' OR NumberOfStudents LIKE '%" + info + "%' ");
            foreach (DataRow row in data.Rows)
                classList.Add(new Class(row));

            return classList;
        }

        public static List<Class> GetFilteredClassOfOneTeacher(string info, int teacherId)
        {
            List<Class> classList = new List<Class>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.CLASS, dbo.CLASS_TEACHER_SCHEDULE " +
                "WHERE (Name LIKE N'%" + info + "%' OR StartDate LIKE '%" + info + "%' " +
                "OR EndDate LIKE '%" + info + "%' OR NumberOfStudents LIKE '%" + info + "%' ) " +
                "AND CLASS.ClassID = CLASS_TEACHER_SCHEDULE.ClassID " +
                "AND CLASS_TEACHER_SCHEDULE.EmployeeID = @EmployeeID", 
                new object[] {teacherId});
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
                "INSERT INTO CLASS_TEACHER_SCHEDULE(ClassId, EmployeeId, ScheduleId) " +
                "VALUES ( @ClassId , @EmployeeId , 1)",
                new object[] { classId, teacherId });
        }

        public static void UpdateClassTeacher(int oldTeacherId, int teacherId, int classId)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE CLASS_TEACHER_SCHEDULE " +
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

        public static List<Class> GetAllClassByTeacherId(int teacherId)
        {
            List<Class> classList = new List<Class>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.CLASS, dbo.CLASS_TEACHER_SCHEDULE " +
                "WHERE CLASS.ClassID = CLASS_TEACHER_SCHEDULE.ClassID " +
                "AND CLASS_TEACHER_SCHEDULE.EmployeeID = @EmployeeID ", 
                new object[] {teacherId});

            foreach (DataRow row in data.Rows)
                classList.Add(new Class(row));

            return classList;
        }

        public static DataTable GetClassTestsResult(int classId)
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT CLASS.ClassID, CLASS.Name AS 'ClassName',STUDENT.StudentID, STUDENT.FirstName, STUDENT.LastName, TEST.Name AS 'TestName', TESTRESULT.Grade " +
                "FROM CLASS, TEST, TESTRESULT, STUDENT " +
                "WHERE CLASS.ClassID = @ClassID " +
                "AND CLASS.ClassID = TEST.ClassID " +
                "AND TEST.TestID = TESTRESULT.TestID " +
                "AND TESTRESULT.StudentID = STUDENT.StudentID " +
                "AND TEST.ClassID = STUDENT.ClassID",
                new object[] {classId});
        }

        public static List<Test> GetClassAllTests(int classId)
        {
            List<Test> testList = new List<Test>();

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT TEST.TestID, TEST.ClassID, TEST.Name, TEST.TestDate, TEST.StartTime, TEST.EndTime, TEST.ROOM, TEST.NumberOfExaminees, TEST.Type " +
                "FROM CLASS, TEST " +
                "WHERE CLASS.ClassID = @ClassId " +
                "AND CLASS.ClassID = TEST.ClassID",
                new object[] {classId});
            foreach (DataRow row in data.Rows)
                testList.Add(new Test(row));

            return testList;
        }

        public static DataTable GetStudentTestsResult(int classId, int studentId)
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT [1] AS 'Test1', [2] AS 'Test2', [3] AS 'Test3' " +
                "FROM " +
                "(SELECT StudentID, TESTRESULT.TestID, Grade  " +
                " FROM dbo.TESTRESULT, dbo.TEST " +
                " WHERE TEST.ClassID = @ClassID AND TEST.TestID = TESTRESULT.TestID AND StudentID = @studentId ) TRS " +
                "PIVOT " +
                "( AVG(Grade) FOR TestID IN  ( [1], [2], [3] )  ) AS pvt",
                new object[] { classId, studentId });
                
        }

        public static int GetNumberOfStudentsInClass(int classId)
        {
            return (int)DataProvider.Instance.ExecuteScalar(
                "SELECT COUNT(*) " +
                "FROM STUDENT " +
                "WHERE ClassID = @ClassID",
                new object[] { classId });
        }

        public static int GetNumberOfClasses()
        {
            return (int)DataProvider.Instance.ExecuteScalar(
                "SELECT COUNT(*) FROM CLASS");
        }
    }
}
