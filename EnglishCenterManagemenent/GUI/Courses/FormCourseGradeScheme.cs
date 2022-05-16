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

namespace EnglishCenterManagemenent.GUI.Courses
{
    public partial class FormCourseGradeScheme : Form
    {
        private string gradeSchemeNameText;
        private string gradeSchemeLowestGradeText;
        private string gradeSchemeHighestGradeText;
        private string gradeSchemeRoundingText;


        private float gradeSchemeLowestGrade;
        private float gradeSchemeHighestGrade;
        private float gradeSchemeRounding;

        public FormCourseGradeScheme()
        {
            InitializeComponent();
            dataGridViewGradeScheme.DataSource = GradeSchemeDAO.GetAllGradeScheme();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            gradeSchemeNameText = textBoxGradeSchemeName.Text.Trim();
            gradeSchemeLowestGradeText = textBoxLowestGrade.Text.Trim();
            gradeSchemeHighestGradeText = textBoxHighestGrade.Text.Trim();
            gradeSchemeRoundingText = textBoxRounding.Text.Trim();

            if (gradeSchemeNameText == "" || gradeSchemeLowestGradeText == "" ||
                gradeSchemeHighestGradeText == "" || gradeSchemeRoundingText == "")
            {
                ShowErrorMessageBox("Empty input, please fill out all the fields !");
            }
            else
            {
                if (!float.TryParse(gradeSchemeLowestGradeText, out gradeSchemeLowestGrade) ||
                    !float.TryParse(gradeSchemeHighestGradeText, out gradeSchemeHighestGrade) ||
                    !float.TryParse(gradeSchemeRoundingText, out gradeSchemeRounding))
                {
                    ShowErrorMessageBox("Invalid input, please input only floating numbers !");
                }
                else if (gradeSchemeHighestGrade <= gradeSchemeLowestGrade + gradeSchemeRounding)
                {
                    ShowErrorMessageBox("Invalid input, highest grade must be higher than lowest!");
                }
                dataGridViewGradeScheme.Rows.Add(
                    gradeSchemeNameText,
                    gradeSchemeLowestGradeText,
                    gradeSchemeHighestGradeText,
                    gradeSchemeRoundingText);
            }
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = ShowAskingMessageBox("Are you sure you want to save ?");
            if (dialog == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridViewGradeScheme.Rows)
                {
                    object[] rowData = new object[dataGridViewGradeScheme.ColumnCount];
                    foreach (DataGridViewCell cell in row.Cells)
                        rowData[cell.ColumnIndex] = cell.Value;
                        
                    GradeSchemeDAO.AddGradeScheme(rowData);
                }

                ShowInfoMessageBox("Grade schemes saved !");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void ShowInfoMessageBox(string message)
        {
            MessageBox.Show(message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult ShowAskingMessageBox(string message)
        {
            return MessageBox.Show(message, "INFO", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
