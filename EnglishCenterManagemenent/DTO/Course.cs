using System;
using System.Collections.Generic;
using System.Data;
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
        private float standardGrade;

        public Course(DataRow row)
        {
            CourseID = (int)row["CourseID"];
            GradeSchemeID = (int)row["GradeSchemeID"];
            Name = (string)row["Name"];
            Description = (string)row["Description"];
            NumberOfLessons = (int)row["NumberOfLessons"];
            NumberOfWeeks = (int)row["NumberOfWeeks"];
            Tuition = (int)row["Tuition"];
            StandardGrade = (float)Convert.ToDouble(row["StandardGrade"].ToString());
        }

        public Course(int courseID, int gradeSchemeID, string name, string description, int numberOfLessons, int numberOfWeeks, int tuition, float standardGrade)
        {
            CourseID = courseID;
            GradeSchemeID = gradeSchemeID;
            Name = name;
            Description = description;
            NumberOfLessons = numberOfLessons;
            NumberOfWeeks = numberOfWeeks;
            Tuition = tuition;
            StandardGrade = standardGrade;
        }

        public int CourseID { get => courseID; set => courseID = value; }
        public int GradeSchemeID { get => gradeSchemeID; set => gradeSchemeID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int NumberOfLessons { get => numberOfLessons; set => numberOfLessons = value; }
        public int NumberOfWeeks { get => numberOfWeeks; set => numberOfWeeks = value; }
        public int Tuition { get => tuition; set => tuition = value; }
        public float StandardGrade { get => standardGrade; set => standardGrade = value; }
    }
}
