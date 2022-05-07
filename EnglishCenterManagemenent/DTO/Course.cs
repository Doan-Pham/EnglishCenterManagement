using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class Course
    {
        private int courseID;
        private int gradeSchemeID;
        private string name;
        private string description;
        private int numberOfLessons;
        private int numberOfWeeks;
        private int tuition;

        public int CourseID { get => courseID; set => courseID = value; }
        public int GradeSchemeID { get => gradeSchemeID; set => gradeSchemeID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int NumberOfLessons { get => numberOfLessons; set => numberOfLessons = value; }
        public int NumberOfWeeks { get => numberOfWeeks; set => numberOfWeeks = value; }
        public int Tuition { get => tuition; set => tuition = value; }
    }
}
