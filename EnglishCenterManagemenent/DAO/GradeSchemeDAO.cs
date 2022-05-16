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
        public static void AddGradeScheme(object[] newGradeSchemeData)
        {

        }

        public static List<GradeScheme> GetAllGradeScheme()
        {
            List<GradeScheme> gradeSchemes = new List<GradeScheme>();

            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.GradeScheme");
            foreach (DataRow row in data.Rows)
                gradeSchemes.Add(new GradeScheme(row));

            return gradeSchemes;

        }
    }
}
