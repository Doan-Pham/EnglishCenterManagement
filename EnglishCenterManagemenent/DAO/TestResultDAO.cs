using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DAO
{
    public class TestResultDAO
    {
        /// <summary>
        /// Check to see if there already exists a test result of a specific student for
        /// a specific test, insert if no, update if yes
        /// </summary>
        /// <param name="studentId">The ID of the student</param>
        /// <param name="testId">The ID of the test</param>
        /// <param name="grade">The grade of the student for the test</param>
        public static void InsertOrUpdateTestResult(int studentId, int testId, float grade)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM dbo.TESTRESULT " +
                "WHERE TestID = @TestID AND StudentID = @StudentID ",
                new object[] {testId, studentId});
            if (data.Rows.Count > 0)
            {
                DataProvider.Instance.ExecuteNonQuery(
                    "UPDATE dbo.TESTRESULT " +
                    "SET Grade = @Grade " +
                    "WHERE TestID = @TestID AND StudentID = @StudentID",
                    new object[] { grade, testId, studentId });

            }
            else 
            {
                DataProvider.Instance.ExecuteNonQuery(
                    "INSERT INTO dbo.TESTRESULT (TestID, StudentID, Grade) " +
                    "VALUES ( @TestID , @StudentID , @Grade )",
                    new object[] { testId, studentId, grade });
            }
        }
    }
}
