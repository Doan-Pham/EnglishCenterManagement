using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class ClassTeacherSchedule
    {
        private int employeeID;
        private int classID;
        private int scheduleID;

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int ClassID { get => classID; set => classID = value; }
        public int ScheduleID { get => scheduleID; set => scheduleID = value; }
    }
}
