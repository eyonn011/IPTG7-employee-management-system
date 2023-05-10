namespace Employee_management_system
{
    partial class employees
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DashboardForm = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.Label();
            this.department_txt = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.Label();
            this.edu_txt = new System.Windows.Forms.Label();
            this.dateofbirth_txt = new System.Windows.Forms.Label();
            this.gender_txt = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.eduTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DashboardForm);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 85);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SALARY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ATTENDANCE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(292, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEES";
            // 
            // DashboardForm
            // 
            this.DashboardForm.AutoSize = true;
            this.DashboardForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardForm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DashboardForm.Location = new System.Drawing.Point(79, 36);
            this.DashboardForm.Name = "DashboardForm";
            this.DashboardForm.Size = new System.Drawing.Size(75, 13);
            this.DashboardForm.TabIndex = 0;
            this.DashboardForm.Text = "DASHBOAD";
            this.DashboardForm.Click += new System.EventHandler(this.DashboardForm_Click);
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Location = new System.Drawing.Point(23, 112);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(35, 13);
            this.name_txt.TabIndex = 6;
            this.name_txt.Text = "Name";
            // 
            // address_txt
            // 
            this.address_txt.AutoSize = true;
            this.address_txt.Location = new System.Drawing.Point(23, 159);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(45, 13);
            this.address_txt.TabIndex = 7;
            this.address_txt.Text = "Address";
            // 
            // department_txt
            // 
            this.department_txt.AutoSize = true;
            this.department_txt.Location = new System.Drawing.Point(23, 209);
            this.department_txt.Name = "department_txt";
            this.department_txt.Size = new System.Drawing.Size(62, 13);
            this.department_txt.TabIndex = 8;
            this.department_txt.Text = "Department";
            // 
            // phone_txt
            // 
            this.phone_txt.AutoSize = true;
            this.phone_txt.Location = new System.Drawing.Point(23, 257);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(38, 13);
            this.phone_txt.TabIndex = 9;
            this.phone_txt.Text = "Phone";
            // 
            // edu_txt
            // 
            this.edu_txt.AutoSize = true;
            this.edu_txt.Location = new System.Drawing.Point(23, 299);
            this.edu_txt.Name = "edu_txt";
            this.edu_txt.Size = new System.Drawing.Size(26, 13);
            this.edu_txt.TabIndex = 10;
            this.edu_txt.Text = "Edu";
            // 
            // dateofbirth_txt
            // 
            this.dateofbirth_txt.AutoSize = true;
            this.dateofbirth_txt.Location = new System.Drawing.Point(23, 342);
            this.dateofbirth_txt.Name = "dateofbirth_txt";
            this.dateofbirth_txt.Size = new System.Drawing.Size(66, 13);
            this.dateofbirth_txt.TabIndex = 11;
            this.dateofbirth_txt.Text = "Date of Birth";
            this.dateofbirth_txt.Click += new System.EventHandler(this.dateofbirth_txt_Click);
            // 
            // gender_txt
            // 
            this.gender_txt.AutoSize = true;
            this.gender_txt.Location = new System.Drawing.Point(23, 389);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(42, 13);
            this.gender_txt.TabIndex = 12;
            this.gender_txt.Text = "Gender";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(83, 109);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(124, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(83, 156);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(124, 20);
            this.addressTextBox.TabIndex = 14;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(101, 206);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(124, 20);
            this.departmentTextBox.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(83, 257);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(124, 20);
            this.phoneTextBox.TabIndex = 16;
            // 
            // eduTextBox
            // 
            this.eduTextBox.Location = new System.Drawing.Point(83, 299);
            this.eduTextBox.Name = "eduTextBox";
            this.eduTextBox.Size = new System.Drawing.Size(124, 20);
            this.eduTextBox.TabIndex = 17;
            this.eduTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Location = new System.Drawing.Point(83, 382);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(124, 20);
            this.genderComboBox.TabIndex = 19;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(95, 336);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthPicker.TabIndex = 20;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(316, 112);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 21;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 268);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(415, 112);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 23;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(517, 112);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 24;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.eduTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.gender_txt);
            this.Controls.Add(this.dateofbirth_txt);
            this.Controls.Add(this.edu_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.department_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.panel1);
            this.Name = "employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DashboardForm;
        private System.Windows.Forms.Label name_txt;
        private System.Windows.Forms.Label address_txt;
        private System.Windows.Forms.Label department_txt;
        private System.Windows.Forms.Label phone_txt;
        private System.Windows.Forms.Label edu_txt;
        private System.Windows.Forms.Label dateofbirth_txt;
        private System.Windows.Forms.Label gender_txt;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox eduTextBox;
        private System.Windows.Forms.TextBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
    }
}