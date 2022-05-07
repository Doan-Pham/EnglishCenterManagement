using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class StudentAttendance
    {
        private int studentID;
        private int classID;
        private DateTime date;
        private int isPresent;

        public int StudentID { get => studentID; set => studentID = value; }
        public int ClassID { get => classID; set => classID = value; }
        public DateTime Date { get => date; set => date = value; }
        public int IsPresent { get => isPresent; set => isPresent = value; }
    }
}
