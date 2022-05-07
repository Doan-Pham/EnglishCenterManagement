using System;
using System.Collections.Generic;
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

        public int GradeSchemeID { get => gradeSchemeID; set => gradeSchemeID = value; }
        public string Name { get => name; set => name = value; }
        public float LowestGrade { get => lowestGrade; set => lowestGrade = value; }
        public float HighestGrade { get => highestGrade; set => highestGrade = value; }
        public float Rounding { get => rounding; set => rounding = value; }
    }
}
