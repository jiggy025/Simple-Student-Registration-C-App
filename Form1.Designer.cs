
namespace StudentRegistrationApplicatiom
{
    partial class Form1
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
            this.button_Register = new System.Windows.Forms.Button();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label_Studentregistration = new System.Windows.Forms.Label();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.textBox_Lastname = new System.Windows.Forms.TextBox();
            this.label_Firstname = new System.Windows.Forms.Label();
            this.label_Middlename = new System.Windows.Forms.Label();
            this.textBox_Firstname = new System.Windows.Forms.TextBox();
            this.textBox_Middlename = new System.Windows.Forms.TextBox();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Dateofbirth = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.listBox_Students = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.Crimson;
            this.button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.ForeColor = System.Drawing.Color.White;
            this.button_Register.Location = new System.Drawing.Point(24, 326);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(172, 38);
            this.button_Register.TabIndex = 0;
            this.button_Register.Text = "Register student";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(24, 299);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(67, 21);
            this.cbDay.TabIndex = 1;
            // 
            // label_Studentregistration
            // 
            this.label_Studentregistration.AutoSize = true;
            this.label_Studentregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Studentregistration.Location = new System.Drawing.Point(19, 9);
            this.label_Studentregistration.Name = "label_Studentregistration";
            this.label_Studentregistration.Size = new System.Drawing.Size(318, 29);
            this.label_Studentregistration.TabIndex = 4;
            this.label_Studentregistration.Text = "Student Registration Form";
            // 
            // label_Lastname
            // 
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lastname.Location = new System.Drawing.Point(22, 71);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(105, 20);
            this.label_Lastname.TabIndex = 5;
            this.label_Lastname.Text = "Last name *";
            // 
            // textBox_Lastname
            // 
            this.textBox_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Lastname.Location = new System.Drawing.Point(24, 94);
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.Size = new System.Drawing.Size(210, 26);
            this.textBox_Lastname.TabIndex = 6;
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Firstname.Location = new System.Drawing.Point(20, 126);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(106, 20);
            this.label_Firstname.TabIndex = 7;
            this.label_Firstname.Text = "First name *";
            // 
            // label_Middlename
            // 
            this.label_Middlename.AutoSize = true;
            this.label_Middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Middlename.Location = new System.Drawing.Point(21, 178);
            this.label_Middlename.Name = "label_Middlename";
            this.label_Middlename.Size = new System.Drawing.Size(122, 20);
            this.label_Middlename.TabIndex = 8;
            this.label_Middlename.Text = "Middle name *";
            // 
            // textBox_Firstname
            // 
            this.textBox_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Firstname.Location = new System.Drawing.Point(24, 149);
            this.textBox_Firstname.Name = "textBox_Firstname";
            this.textBox_Firstname.Size = new System.Drawing.Size(210, 26);
            this.textBox_Firstname.TabIndex = 9;
            // 
            // textBox_Middlename
            // 
            this.textBox_Middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Middlename.Location = new System.Drawing.Point(24, 201);
            this.textBox_Middlename.Name = "textBox_Middlename";
            this.textBox_Middlename.Size = new System.Drawing.Size(210, 26);
            this.textBox_Middlename.TabIndex = 10;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(21, 237);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(81, 20);
            this.label_Gender.TabIndex = 11;
            this.label_Gender.Text = "Gender *";
            // 
            // label_Dateofbirth
            // 
            this.label_Dateofbirth.AutoSize = true;
            this.label_Dateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dateofbirth.Location = new System.Drawing.Point(22, 272);
            this.label_Dateofbirth.Name = "label_Dateofbirth";
            this.label_Dateofbirth.Size = new System.Drawing.Size(122, 20);
            this.label_Dateofbirth.TabIndex = 12;
            this.label_Dateofbirth.Text = "Date of birth *";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(108, 240);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Male.TabIndex = 13;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(162, 240);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Female.TabIndex = 14;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(97, 299);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(67, 21);
            this.cbMonth.TabIndex = 15;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(170, 299);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(67, 21);
            this.cbYear.TabIndex = 16;
            // 
            // listBox_Students
            // 
            this.listBox_Students.FormattingEnabled = true;
            this.listBox_Students.Location = new System.Drawing.Point(266, 71);
            this.listBox_Students.Name = "listBox_Students";
            this.listBox_Students.Size = new System.Drawing.Size(371, 251);
            this.listBox_Students.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.listBox_Students);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.label_Dateofbirth);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.textBox_Middlename);
            this.Controls.Add(this.textBox_Firstname);
            this.Controls.Add(this.label_Middlename);
            this.Controls.Add(this.label_Firstname);
            this.Controls.Add(this.textBox_Lastname);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.label_Studentregistration);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.button_Register);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Student Registration ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label_Studentregistration;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.TextBox textBox_Lastname;
        private System.Windows.Forms.Label label_Firstname;
        private System.Windows.Forms.Label label_Middlename;
        private System.Windows.Forms.TextBox textBox_Firstname;
        private System.Windows.Forms.TextBox textBox_Middlename;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Dateofbirth;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ListBox listBox_Students;
    }
}

