﻿using EnglishCenterManagemenent.DAO;
using EnglishCenterManagemenent.DTO;
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

            foreach (GradeScheme gradeScheme in GradeSchemeDAO.GetAllGradeScheme())
            {
                dataGridViewGradeScheme.Rows.Add(new object[] 
                { 
                    gradeScheme.Name, 
                    gradeScheme.LowestGrade, 
                    gradeScheme.HighestGrade, 
                    gradeScheme.Rounding 
                });
            }
        }

        private void FormCourseGradeScheme_Load(object sender, EventArgs e)
        {
            if (Global.userRole == "teacher" || Global.userRole == "receptionist")
            {
                // avoid teacher, receptionist add or delete grade scheme
                buttonAdd.Enabled = false;
                buttonSave.Visible = false;
            }
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
                else if (Int32.Parse(gradeSchemeHighestGradeText) < 0 || Int32.Parse(gradeSchemeLowestGradeText) < 0 ||
                        Int32.Parse(gradeSchemeRoundingText) < 0)
                {
                    ShowErrorMessageBox("Grade can't be lower than 0 !");
                }
                else if (Int32.Parse(gradeSchemeRoundingText) == 0)
                {
                    ShowErrorMessageBox("Rounding must be greater than 0 !");
                }
                else if (gradeSchemeHighestGrade <= gradeSchemeLowestGrade + gradeSchemeRounding)
                {
                    ShowErrorMessageBox("Invalid input, highest grade must be higher than lowest!");
                }
                else dataGridViewGradeScheme.Rows.Add(
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
                GradeSchemeDAO.DeleteAllGradeSchemes();
                foreach (DataGridViewRow row in dataGridViewGradeScheme.Rows)
                {
                    GradeScheme gradeScheme = new GradeScheme(
                        -1,
                        row.Cells["ColumnName"].Value.ToString(),
                        (float)Convert.ToDouble(row.Cells["ColumnLowestGrade"].Value),
                        (float)Convert.ToDouble(row.Cells["ColumnHighestGrade"].Value),
                        (float)Convert.ToDouble(row.Cells["ColumnRounding"].Value));
                    GradeSchemeDAO.AddGradeScheme(gradeScheme);
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
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

    }
}
