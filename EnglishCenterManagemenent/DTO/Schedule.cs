using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class Schedule
    {
        private int scheduleID;
        private DateTime date;
        private string startTime;
        private string endTime;

        public int ScheduleID { get => scheduleID; set => scheduleID = value; }
        public DateTime Date { get => date; set => date = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
    }
}
