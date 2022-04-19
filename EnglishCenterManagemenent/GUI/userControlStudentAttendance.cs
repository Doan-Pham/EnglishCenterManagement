using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishCenterManagemenent.GUI
{
    public partial class UserControlStudentAttendance : UserControl
    {
        public UserControlStudentAttendance()
        {
            InitializeComponent();
            kryptonDataGridView1.Rows.Add(new object[] { "name1", "addr1", "dob1", true, true, true });
            kryptonDataGridView1.Rows.Add(new object[] { "name2", "addr2", "dob2", true, true, true });
            kryptonDataGridView1.Rows.Add(new object[] { "name3", "addr3", "dob3", true, true, true });
        }
    }
}
