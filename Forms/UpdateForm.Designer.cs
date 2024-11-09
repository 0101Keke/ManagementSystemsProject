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
            this.txtStudentID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.btncBack = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtStudentID);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 77);
            this.panel1.TabIndex = 0;
            // 
            // txtStudentID
            // 
            this.txtStudentID.AutoSize = true;
            this.txtStudentID.Location = new System.Drawing.Point(26, 34);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(72, 13);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.Text = "txtStudentID: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(400, 396);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnUpdate1);
            this.panel2.Controls.Add(this.btncBack);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtCourse);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(9, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 243);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Location = new System.Drawing.Point(202, 206);
            this.btnUpdate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(68, 22);
            this.btnUpdate1.TabIndex = 11;
            this.btnUpdate1.Text = "Update";
            this.btnUpdate1.UseVisualStyleBackColor = true;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // btncBack
            // 
            this.btncBack.Location = new System.Drawing.Point(28, 206);
            this.btncBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncBack.Name = "btncBack";
            this.btncBack.Size = new System.Drawing.Size(68, 22);
            this.btncBack.TabIndex = 10;
            this.btncBack.Text = "Back";
            this.btncBack.UseVisualStyleBackColor = true;
            this.btncBack.Click += new System.EventHandler(this.btncBack_Click);
            // 
            // txtAge
            // 
            this.txtAge.AutoSize = true;
            this.txtAge.Location = new System.Drawing.Point(26, 110);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(29, 13);
            this.txtAge.TabIndex = 9;
            this.txtAge.Text = "Age:";
            // 
            // txtCourse
            // 
            this.txtCourse.AutoSize = true;
            this.txtCourse.Location = new System.Drawing.Point(26, 167);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(43, 13);
            this.txtCourse.TabIndex = 8;
            this.txtCourse.Text = "Course:";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(26, 54);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(38, 13);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Name:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 105);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 162);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 3;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label txtStudentID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtAge;
        private System.Windows.Forms.Label txtCourse;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btncBack;
    }
}