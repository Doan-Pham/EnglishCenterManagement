using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class Test
    {
        private int testID;
        private int classID;
        private string name;
        private int numberOfExaminees;
        private DateTime? testDate;
        private DateTime? startTime;
        private DateTime? endTime;
        private string room;
        private int type;

        public Test(int testID, int classID, string name, int numberOfExaminees, DateTime? testDate, DateTime? endDate, DateTime? endTime, string room, int type)
        {
            TestID = testID;
            ClassID = classID;
            Name = name;
            NumberOfExaminees = numberOfExaminees;
            TestDate = testDate;
            StartTime = endDate;
            EndTime = endTime;
            this.room = room;
            this.type = type;
        }

        public Test(DataRow row)
        {
            TestID = (int)row["TestID"];
            ClassID = (int)row["ClassID"];
            Name = (string)row["Name"];

            if (row["NumberOfExaminees"] != DBNull.Value)
                NumberOfExaminees = (int)row["NumberOfExaminees"];

            if (row["TestDate"] != DBNull.Value)
                TestDate = (DateTime)row["TestDate"];

            if (row["StartTime"] != DBNull.Value)
                StartTime = (DateTime)row["StartTime"];

            if (row["EndTime"] != DBNull.Value)
                StartTime = (DateTime)row["StartTime"];

            if (row["Room"] != DBNull.Value)
                Room = (string)row["Room"];

            if (row["Type"] != DBNull.Value)
                Type = (int)row["Type"];
        }
        public int TestID { get => testID; set => testID = value; }
        public int ClassID { get => classID; set => classID = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfExaminees { get => numberOfExaminees; set => numberOfExaminees = value; }
        public DateTime? TestDate { get => testDate; set => testDate = value; }
        public DateTime? StartTime { get => startTime; set => startTime = value; }
        public DateTime? EndTime { get => endTime; set => endTime = value; }
        public string Room { get => room; set => room = value; }
        public int Type { get => type; set => type = value; }
    }
}
