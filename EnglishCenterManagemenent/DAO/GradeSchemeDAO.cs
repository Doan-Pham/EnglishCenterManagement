using EnglishCenterManagemenent.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DAO
{
    public class GradeSchemeDAO
    {
        public static void AddGradeScheme(GradeScheme newGradeScheme)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "INSERT INTO dbo.GRADESCHEME (Name , LowestGrade , HighestGrade , Rounding)" +
                "VALUES ( @Name , @LowestGrade , @HighestGrade , @Rounding )",
                new object[] {
                    newGradeScheme.Name,
                    newGradeScheme.LowestGrade,
                    newGradeScheme.HighestGrade,
                    newGradeScheme.Rounding });
        }

        public static void DeleteAllGradeSchemes()
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.GRADESCHEME");
        }

        public static List<GradeScheme> GetAllGradeScheme()
        {
            List<GradeScheme> gradeSchemes = new List<GradeScheme>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.GradeScheme");
            foreach (DataRow row in data.Rows)
                gradeSchemes.Add(new GradeScheme(row));

            return gradeSchemes;
        }
    }
}
