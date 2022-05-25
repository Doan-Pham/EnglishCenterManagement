using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class Class
    {
        private int classID;
        private int courseID;
        private string name;
        private int numberOfStudents;
        private DateTime? startDate;
        private DateTime? endDate;

        public Class(int classID, int courseID, string name, int numberOfStudents, DateTime? startDate, DateTime? endDate)
        {
            ClassID = classID;
            CourseID = courseID;
            Name = name;
            NumberOfStudents = numberOfStudents;
            StartDate = startDate;
            EndDate = endDate;
        }

        public Class(DataRow row)
        {
            ClassID = (int)row["ClassID"];
            CourseID = (int)row["CourseID"];
            Name = (string)row["Name"];
            NumberOfStudents = (int)row["NumberOfStudents"];

            if (row["StartDate"] != DBNull.Value)
                StartDate = (DateTime)row["StartDate"];

            if (row["EndDate"] != DBNull.Value)
                EndDate = (DateTime)row["EndDate"];
        }
        public int ClassID { get => classID; set => classID = value; }
        public int CourseID { get => courseID; set => courseID = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfStudents { get => numberOfStudents; set => numberOfStudents = value; }
        public DateTime? StartDate { get => startDate; set => startDate = value; }
        public DateTime? EndDate { get => endDate; set => endDate = value; }
    }
}
