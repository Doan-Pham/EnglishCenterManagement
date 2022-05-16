using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class GradeScheme
    {
        private int gradeSchemeID;
        private string name;
        private float lowestGrade;
        private float highestGrade;
        private float rounding;
        public GradeScheme(DataRow row)
        {
            GradeSchemeID = (int)row["GradeSchemeID"];
            Name = (string)row["Name"];
            LowestGrade = (float)Convert.ToDouble(row["LowestGrade"].ToString());
            HighestGrade = (float)Convert.ToDouble(row["HighestGrade"].ToString());
            Rounding = (float)Convert.ToDouble(row["Rounding"].ToString());
        }

        public GradeScheme(int gradeSchemeID, string name, float lowestGrade, float highestGrade, float rounding)
        {
            GradeSchemeID = gradeSchemeID;
            Name = name;
            LowestGrade = lowestGrade;
            HighestGrade = highestGrade;
            Rounding = rounding;
        }

        public int GradeSchemeID { get => gradeSchemeID; set => gradeSchemeID = value; }
        public string Name { get => name; set => name = value; }
        public float LowestGrade { get => lowestGrade; set => lowestGrade = value; }
        public float HighestGrade { get => highestGrade; set => highestGrade = value; }
        public float Rounding { get => rounding; set => rounding = value; }
    }
}
