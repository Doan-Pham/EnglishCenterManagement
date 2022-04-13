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
    public partial class userControlStudentGrades : UserControl
    {
        public userControlStudentGrades()
        {
            InitializeComponent();
            float a = 9.957f;
            kryptonDataGridView1.Rows.Add(new object[] { "Pre1", "2051", "Huỳnh", a.ToString("#.##"), 4.5, 4.5 });
            kryptonDataGridView1.Rows.Add(new object[] { "Pre1", "2051", "Huỳnh", "9.0", 9.0, 9.0 });
            kryptonDataGridView1.Rows.Add(new object[] { "Pre1", "2051", "Huỳnh", 9.0, 9.0, 9.0 });
        }

    }
}
