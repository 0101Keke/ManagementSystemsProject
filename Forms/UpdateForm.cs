using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ManagementSystemsProject.DataLayer;

namespace ManagementSystemsProject
{
    public partial class UpdateForm : Form
    {

        public UpdateForm()
        {
            InitializeComponent();

            // Add button click handlers
            btnUpdate1.Click += new EventHandler(btnUpdate1_Click);
            btncBack.Click += new EventHandler(btncBack_Click);
        }



        private void ClearForm()
        {
            txtStudentID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtCourse.Text = "";
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            string filePath = "students.txt";  
            string studentId = txtStudentID.Text;  
            string newName = txtName.Text;  
            int newAge;
            string newCourse = txtCourse.Text;  

            // Validate age input
            if (!int.TryParse(txtAge.Text, out newAge))
            {
                MessageBox.Show("Please enter a valid age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load all lines from file
            string[] lines = File.ReadAllLines(filePath);
            bool studentFound = false;

            // Update information
            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (fields[0] == studentId)  
                {
                    lines[i] = $"{studentId},{newName},{newAge},{newCourse}";  // Update the line with new details
                    studentFound = true;
                    break;
                }
            }

            if (studentFound)
            {
                // Saves
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Student record updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally refresh view
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Student not found. Please check the Student ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional helper method to refresh the DataGridView
        private void RefreshDataGridView()
        {
        }

        private void btncBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
