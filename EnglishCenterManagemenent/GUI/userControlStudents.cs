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
    public partial class userControlStudents : UserControl
    {
        public userControlStudents()
        {
            InitializeComponent();
            kryptonDataGridView1.Rows.Add(new object[] { "name1", "addr1","dob1","email1", "averagegrade1" });
            kryptonDataGridView1.Rows.Add(new object[] { "name2", "addr2", "dob2", "email2", "averagegrade2" });
            kryptonDataGridView1.Rows.Add(new object[] { "name3", "addr3", "dob3", "email3", "averagegrade" });
        }
    }
    }
