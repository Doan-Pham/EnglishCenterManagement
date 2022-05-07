using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class StudentGrade
    {
        private int studentID;
        private int classID;
        private string testName;
        private float grade;

        public int StudentID { get => studentID; set => studentID = value; }
        public int ClassID { get => classID; set => classID = value; }
        public string TestName { get => testName; set => testName = value; }
        public float Grade { get => grade; set => grade = value; }
    }
}
