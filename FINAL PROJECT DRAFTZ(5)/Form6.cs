﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BorrowingForm : Form
    {
        bool isStudent;
        string id;
        private Student currentStudent;
        private Teacher currentTeacher;

        int borrowLimit;
        public BorrowingForm()
        {
            InitializeComponent();

        }

        private void setUIData()
        {

            DateTime currentDate = DateTime.Now;

            label2.Text = "DATE BORROWED: " + currentDate.ToShortDateString();

            if (isStudent)
            {
                borrowerLabel.Text = "Borrower Name: " + currentStudent.firstName + " " + currentStudent.lastName;
                borrowLimit = 2 - currentStudent.borrowedBookCount;
            }
            else
            {
                borrowerLabel.Text = "Borrower Name: " + currentTeacher.firstName + " " + currentTeacher.lastName;
                borrowLimit = 5 - currentTeacher.borrowedBookCount;
            }
        }

        public void setUserData(Student student)
        {
            currentStudent = student;
            isStudent = true;
            id = student.userID;
            setUIData();
        }

        public void setUserData(Teacher teacher)
        {
            currentTeacher = teacher;
            isStudent = false;
            id = teacher.userID;
            setUIData();
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check if any CheckBox in the GroupBox is checked
            foreach (CheckBox checkBox in groupBox1.Controls)
            {
                if (checkBox.Checked)
                {
                    // Show a dialog box (replace YourDialogBox with the actual dialog box you want to show)
                    MessageBox.Show("Academic Books are only allowed inside the library");
                }
            }
        }

        private int CountCheckedCheckboxes(Control container)
        {
            int checkedCount = 0;

            // Iterate through all controls in the container
            foreach (Control control in container.Controls)
            {
                // Check if the control is a CheckBox
                if (control is CheckBox checkBox)
                {
                    // Check if the CheckBox is checked
                    if (checkBox.Checked)
                    {
                        checkedCount++;
                    }
                }

                // If the control is a container (like a GroupBox), recursively count checkboxes within it
                if (control.HasChildren)
                {
                    checkedCount += CountCheckedCheckboxes(control);
                }
            }

            return checkedCount;
        }

        private void UncheckAllCheckboxes(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }

                // If the control is a container (like a GroupBox), recursively uncheck checkboxes within it
                if (control.HasChildren)
                {
                    UncheckAllCheckboxes(control);
                }
            }
        }
        private void BorrowingForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int count = CountCheckedCheckboxes(groupBox2);
            int count2 = CountCheckedCheckboxes(groupBox3);
            count += count2;

            

            if (count > borrowLimit)
            {
                MessageBox.Show("Sorry! You have exceeded the \nnumber of books to be borrowed.\n LIMIT: " + borrowLimit.ToString() + 
                    "\n Please return the borrowed books first.");
                UncheckAllCheckboxes(groupBox2);
                UncheckAllCheckboxes(groupBox3);
                return;
            }

            UsersData.addBorrowCount(id, count, isStudent);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
