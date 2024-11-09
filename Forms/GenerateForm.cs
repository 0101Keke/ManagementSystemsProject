using ManagementSystemsProject.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystemsProject.Forms
{
    public partial class GenerateForm : Form
    {
        public GenerateForm()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                ReportSummary summary = new ReportSummary("[StudentTextFile]");

                int totalStudents = summary.TotalStudents();
                dgvTotal.Rows.Add("TotalStudents", totalStudents);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }

        private void btnAvgAge_Click(object sender, EventArgs e)
        {
            try
            {
                ReportSummary summary = new ReportSummary("[StudentTextFile]");

                dgvAverage.Rows.Clear();

                double avgAge = summary.AvgAge();
                dgvAverage.Rows.Add("Average age", avgAge.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }
    }
}
