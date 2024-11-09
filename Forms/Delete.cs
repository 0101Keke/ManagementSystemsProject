using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ManagementSystemsProject.DataLayer;

namespace ManagementSystemsProject.Forms
{
    public partial class Delete : Form
    {

        private string filepath = @"students.txt";
        public Delete()
        {
            InitializeComponent();
        }


        private void ClearForm()
        {
            txtStudentID.Text = "";
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            try
            {
                string studentId = txtStudentID.Text.Trim();

                // checks ID
                if (string.IsNullOrEmpty(studentId))
                {
                    MessageBox.Show("Please enter a Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Reads all the lines from the file to find right Id
                string[] allLines = File.ReadAllLines(filepath);

                // Find the student line to delete 
                var remainingLines = allLines.Where(line =>
                    !line.StartsWith(studentId + ",")).ToList();

                if (remainingLines.Count == allLines.Length)
                {
                    MessageBox.Show("Student ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirming the deletion
                var result = MessageBox.Show("Are you sure you want to delete this student?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Writes whatevers left back to to text
                    File.WriteAllLines(filepath, remainingLines);

                    MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clears form
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();  // closes tab
        }
    }
    
}