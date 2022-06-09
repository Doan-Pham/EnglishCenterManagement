using EnglishCenterManagemenent.DAO;
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
    public partial class UserControlStudentGrades : UserControl
    {
        int classId = -1;
        public UserControlStudentGrades()
        {
            InitializeComponent();
            FillDataGridView();
        }

        public void SetClass(int classId)
        {
            this.classId = classId;
        }

        private void FillDataGridView()
        {
            if (classId < 0) return;
            dataGridView.Rows.Clear();
            DataTable dataTable = ClassDAO.GetClassTestsResult(classId);

            foreach (DataRow row in dataTable.Rows)
            {
                dataGridView.Rows.Add(new object[]
                {
                    (string)row["ClassName"],
                    (string)row["LastName"] + " " + (string)row["FirstName"],
                    (string)row["TestName"],
                    (float)Convert.ToDouble(row["Grade"].ToString()),
                });
            }
        }

        private void UserControlStudentGrades_Enter(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
