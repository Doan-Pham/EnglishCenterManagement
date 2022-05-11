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
        public FormCourseGradeScheme()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string gradeSchemeNameText = textBoxGradeSchemeName.Text.Trim();
            string gradeSchemeLowestGradeText = textBoxLowestGrade.Text.Trim();
            string gradeSchemeHighestGradeText = textBoxHighestGrade.Text.Trim();
            string gradeSchemeRoundingText = textBoxRounding.Text.Trim();

            if (gradeSchemeNameText == "" || gradeSchemeLowestGradeText == "" ||
                gradeSchemeHighestGradeText == "" || gradeSchemeRoundingText == "")
            {
                ShowErrorMessageBox("Empty input, please fill out all the fields !");
            }
            else
            {
                float gradeSchemeLowestGrade;
                float gradeSchemeHighestGrade;
                float gradeSchemeRounding;

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

        /// <summary>
        /// Show a message box indicating that an error has occured
        /// </summary>
        /// <param name="message">The message box's error message</param>
        private void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
