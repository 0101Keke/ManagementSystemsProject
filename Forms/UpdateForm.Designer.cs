namespace ManagementSystemsProject
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblcName = new System.Windows.Forms.Label();
            this.lblcCourse = new System.Windows.Forms.Label();
            this.lblcAge = new System.Windows.Forms.Label();
            this.btncBack = new System.Windows.Forms.Button();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblUpdate);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 95);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 0;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(35, 42);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(71, 16);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "StudentID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(453, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 487);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnUpdate1);
            this.panel2.Controls.Add(this.btncBack);
            this.panel2.Controls.Add(this.lblcAge);
            this.panel2.Controls.Add(this.lblcCourse);
            this.panel2.Controls.Add(this.lblcName);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(12, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 299);
            this.panel2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(192, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 22);
            this.textBox5.TabIndex = 6;
            // 
            // lblcName
            // 
            this.lblcName.AutoSize = true;
            this.lblcName.Location = new System.Drawing.Point(35, 67);
            this.lblcName.Name = "lblcName";
            this.lblcName.Size = new System.Drawing.Size(59, 20);
            this.lblcName.TabIndex = 7;
            this.lblcName.Text = "Name:";
            // 
            // lblcCourse
            // 
            this.lblcCourse.AutoSize = true;
            this.lblcCourse.Location = new System.Drawing.Point(35, 206);
            this.lblcCourse.Name = "lblcCourse";
            this.lblcCourse.Size = new System.Drawing.Size(66, 20);
            this.lblcCourse.TabIndex = 8;
            this.lblcCourse.Text = "Course:";
            // 
            // lblcAge
            // 
            this.lblcAge.AutoSize = true;
            this.lblcAge.Location = new System.Drawing.Point(35, 135);
            this.lblcAge.Name = "lblcAge";
            this.lblcAge.Size = new System.Drawing.Size(44, 20);
            this.lblcAge.TabIndex = 9;
            this.lblcAge.Text = "Age:";
            // 
            // btncBack
            // 
            this.btncBack.Location = new System.Drawing.Point(38, 253);
            this.btncBack.Name = "btncBack";
            this.btncBack.Size = new System.Drawing.Size(91, 27);
            this.btncBack.TabIndex = 10;
            this.btncBack.Text = "Back";
            this.btncBack.UseVisualStyleBackColor = true;
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Location = new System.Drawing.Point(269, 253);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(91, 27);
            this.btnUpdate1.TabIndex = 11;
            this.btnUpdate1.Text = "Update";
            this.btnUpdate1.UseVisualStyleBackColor = true;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcAge;
        private System.Windows.Forms.Label lblcCourse;
        private System.Windows.Forms.Label lblcName;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btncBack;
    }
}