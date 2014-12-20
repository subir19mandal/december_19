using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationUI
{
    public partial class StudentInfo : Form
    {
        List<Student> aStudent = new List<Student>();
        string studentInfo;
        int count = 0;
       
        //private Student astudent = new Student();


        public StudentInfo()
        {
            InitializeComponent();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (count<3)
            {
                Student student = new Student();
                student.regNo = regNoTextBox.Text;
                student.firstName = firstNameTextBox.Text;
                student.lastName = lastNameTextBox.Text;

                aStudent.Add(student);
                MessageBox.Show("Data is Entried");
                count++;
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Already three students information have been added");
                clearTextBox();
            }
            
        }


        private void showAllButton_Click(object sender, EventArgs e)
        {
            
            foreach (Student Student in aStudent)
            {


                studentInfo += ("Reg No: " + Student.regNo + " Full Name: " + Student.GetFullName() + "\n");

            }
            MessageBox.Show(studentInfo);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            aStudent.Clear();
            studentInfo = null;
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }

        public void clearTextBox()
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            
        }
    }


}