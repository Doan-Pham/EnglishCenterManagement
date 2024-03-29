﻿using EnglishCenterManagemenent.DAO;
using EnglishCenterManagemenent.DTO;
using EnglishCenterManagemenent.GUI.Classes;
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
    public partial class UserControlClasses : UserControl
    {
        public FormMain formMainInstance { get; set; }


        // This is the placeholder text for textBoxSearch, when you click on the textbox to type,
        // the placeholder text disappears, and only reappear when you clear the textbox and stop
        // focusing on it
        private const string TEXTBOX_SEARCH_PLACEHOLDER = "What are you looking for ?";

        // A list to keep track of all the classVars
        private List<Class> classList = new List<Class>();
        private int currentTeacherId = -1;

        public UserControlClasses()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void UserControlClasses_Load(object sender, EventArgs e)
        {
            buttonStudentsList.Location = new Point(666, 132);
            if (Global.userRole == "teacher")
            {
                buttonAdd.Hide();
                buttonUpdate.Hide();
                buttonDelete.Hide();
                buttonStudentsList.Location = new Point(666, 37);
                currentTeacherId = EmployeeDAO.GetEmployeeIdByUserName(Global.userName);
            }
            FillDataGridView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormClassInfoInput formClassInfoInput = new FormClassInfoInput(null);
            formClassInfoInput.ShowDialog();
            FillDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            Class currentClass = dataGridView.CurrentRow.Tag as Class;
            if (ClassDAO.GetNumberOfStudentsInClass(currentClass.ClassID) > 0)
            {
                ShowErrorMessageBox("Can't delete class because there are still students studying. " +
                    "Delete all the students first or move them to other classes.");
                return;
            }

            DialogResult dialog = ShowAskingMessageBox
                ("Are you sure you want to delete this class: " +
                currentClass.Name + "?");

            if (dialog == DialogResult.OK)
            {
                ClassDAO.DeleteClassTeachers(currentClass.ClassID);
                ClassDAO.DeleteClass(currentClass);
                ShowInfoMessageBox("Class deleted !");
                FillDataGridView();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            FormClassInfoInput formClassInfoInput = new FormClassInfoInput(
               dataGridView.CurrentRow.Tag as Class);

            formClassInfoInput.ShowDialog();
            FillDataGridView();
        }

        private void buttonStudentsList_Click(object sender, EventArgs e)
        {
            formMainInstance.userControlStudents.SetStudentsClass
                (classList.ElementAt(dataGridView.CurrentCell.RowIndex).ClassID);
            formMainInstance.userControlStudents.Focus();
            formMainInstance.userControlStudents.BringToFront();
            formMainInstance.userControlStudents.formMainInstance = formMainInstance;
            formMainInstance.labelCurrentUserControl.Text = "Class's students";
        }

        /// <summary>
        /// Fill this user control's datagridview with data from database
        /// </summary>
        private void FillDataGridView()
        {
            dataGridView.Rows.Clear();
            classList.Clear();

            classList = ClassDAO.GetAllClass();
            if (Global.userRole == "teacher")
                classList = ClassDAO.GetAllClassByTeacherId(currentTeacherId);
            
            foreach (Class classVar in classList)
            {
                dataGridView.Rows.Add(new object[]
                {
                    ClassDAO.GetClassCourseName(classVar.ClassID),
                    ClassDAO.GetClassTeacherName(classVar.ClassID),
                    classVar.Name,
                    $"{classVar.StartDate: dd/MM/yyyy}",
                    $"{classVar.EndDate: dd/MM/yyyy}",
                    ClassDAO.GetNumberOfStudentsInClass(classVar.ClassID),

                });
                dataGridView.Rows[dataGridView.Rows.Count - 1].Tag = classVar;
            }
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

        // Remove placeholder text from textBoxSearch when user clicks on it to type
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER)
                textBoxSearch.Text = "";
        }

        // Fill the textBoxSearch with placeholder text when user clears the textBox and stop
        // focusing on it
        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                textBoxSearch.Text = TEXTBOX_SEARCH_PLACEHOLDER;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // If we don't check this, the placeholer text becomes part of the filtering, which
            // is not wanted
            if (textBoxSearch.Text == TEXTBOX_SEARCH_PLACEHOLDER) return;

            if (textBoxSearch.Text.Trim() == "")
            {
                FillDataGridView();
                return;
            }

            dataGridView.Rows.Clear();
            classList.Clear();

            classList = ClassDAO.GetFilteredClass(textBoxSearch.Text);
            if (Global.userRole == "teacher")
                classList = ClassDAO.GetFilteredClassOfOneTeacher(textBoxSearch.Text, currentTeacherId);

            foreach (Class classVar in classList)
            {
                dataGridView.Rows.Add(new object[]
                {
                    ClassDAO.GetClassCourseName(classVar.ClassID),
                    ClassDAO.GetClassTeacherName(classVar.ClassID),
                    classVar.Name,
                    $"{classVar.StartDate: dd/MM/yyyy}",
                    $"{classVar.EndDate: dd/MM/yyyy}",
                    ClassDAO.GetNumberOfStudentsInClass(classVar.ClassID),

                });

                dataGridView.Rows[dataGridView.Rows.Count - 1].Tag = classVar;
            }
        }

        
    }
}
