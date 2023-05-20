
namespace AppTest
{
    partial class signUpForm
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
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.signUpButton = new System.Windows.Forms.Button();
            this.adminCheckbox = new System.Windows.Forms.CheckBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.customerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.hr5 = new System.Windows.Forms.Panel();
            this.hr6 = new System.Windows.Forms.Panel();
            this.hr3 = new System.Windows.Forms.Panel();
            this.hr4 = new System.Windows.Forms.Panel();
            this.hr7 = new System.Windows.Forms.Panel();
            this.CustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerPanel.Controls.Add(this.hr4);
            this.CustomerPanel.Controls.Add(this.hr3);
            this.CustomerPanel.Controls.Add(this.hr5);
            this.CustomerPanel.Controls.Add(this.signUpButton);
            this.CustomerPanel.Controls.Add(this.adminCheckbox);
            this.CustomerPanel.Controls.Add(this.passwordLabel);
            this.CustomerPanel.Controls.Add(this.emailLabel);
            this.CustomerPanel.Controls.Add(this.lastNameLabel);
            this.CustomerPanel.Controls.Add(this.firstNameLabel);
            this.CustomerPanel.Controls.Add(this.passwordText);
            this.CustomerPanel.Controls.Add(this.emailText);
            this.CustomerPanel.Controls.Add(this.lastNameText);
            this.CustomerPanel.Controls.Add(this.firstNameText);
            this.CustomerPanel.Controls.Add(this.BirthdateLabel);
            this.CustomerPanel.Controls.Add(this.SSNLabel);
            this.CustomerPanel.Controls.Add(this.customerBirthDate);
            this.CustomerPanel.Controls.Add(this.SSNTextBox);
            this.CustomerPanel.Location = new System.Drawing.Point(170, 13);
            this.CustomerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(630, 447);
            this.CustomerPanel.TabIndex = 0;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(0, 359);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(630, 45);
            this.signUpButton.TabIndex = 14;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // adminCheckbox
            // 
            this.adminCheckbox.AutoSize = true;
            this.adminCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCheckbox.ForeColor = System.Drawing.Color.White;
            this.adminCheckbox.Location = new System.Drawing.Point(277, 216);
            this.adminCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminCheckbox.Name = "adminCheckbox";
            this.adminCheckbox.Size = new System.Drawing.Size(78, 24);
            this.adminCheckbox.TabIndex = 13;
            this.adminCheckbox.Text = "Admin";
            this.adminCheckbox.UseVisualStyleBackColor = true;
            this.adminCheckbox.CheckedChanged += new System.EventHandler(this.adminCheckbox_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(4, 149);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 20);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(4, 77);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 20);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(334, 2);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(91, 20);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(4, 2);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(92, 20);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.passwordText.Location = new System.Drawing.Point(8, 169);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(622, 20);
            this.passwordText.TabIndex = 8;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.emailText.Location = new System.Drawing.Point(8, 97);
            this.emailText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(622, 20);
            this.emailText.TabIndex = 7;
            // 
            // lastNameText
            // 
            this.lastNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lastNameText.Location = new System.Drawing.Point(338, 26);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(292, 20);
            this.lastNameText.TabIndex = 6;
            // 
            // firstNameText
            // 
            this.firstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.firstNameText.Location = new System.Drawing.Point(8, 26);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(292, 20);
            this.firstNameText.TabIndex = 5;
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdateLabel.ForeColor = System.Drawing.Color.White;
            this.BirthdateLabel.Location = new System.Drawing.Point(334, 268);
            this.BirthdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(77, 20);
            this.BirthdateLabel.TabIndex = 4;
            this.BirthdateLabel.Text = "Birthdate";
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNLabel.ForeColor = System.Drawing.Color.White;
            this.SSNLabel.Location = new System.Drawing.Point(4, 268);
            this.SSNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(43, 20);
            this.SSNLabel.TabIndex = 3;
            this.SSNLabel.Text = "SSN";
            // 
            // customerBirthDate
            // 
            this.customerBirthDate.CalendarForeColor = System.Drawing.Color.White;
            this.customerBirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.customerBirthDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.customerBirthDate.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBirthDate.Location = new System.Drawing.Point(330, 288);
            this.customerBirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerBirthDate.Name = "customerBirthDate";
            this.customerBirthDate.Size = new System.Drawing.Size(300, 27);
            this.customerBirthDate.TabIndex = 2;
            this.customerBirthDate.ValueChanged += new System.EventHandler(this.customerBirthDate_ValueChanged);
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.SSNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SSNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.SSNTextBox.Location = new System.Drawing.Point(8, 288);
            this.SSNTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(292, 20);
            this.SSNTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(398, 464);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alredy have an account?";
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(170, 484);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(630, 45);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // hr5
            // 
            this.hr5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.hr5.Location = new System.Drawing.Point(8, 124);
            this.hr5.Name = "hr5";
            this.hr5.Size = new System.Drawing.Size(622, 5);
            this.hr5.TabIndex = 13;
            // 
            // hr6
            // 
            this.hr6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.hr6.Location = new System.Drawing.Point(178, 209);
            this.hr6.Name = "hr6";
            this.hr6.Size = new System.Drawing.Size(622, 5);
            this.hr6.TabIndex = 14;
            // 
            // hr3
            // 
            this.hr3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.hr3.Location = new System.Drawing.Point(8, 53);
            this.hr3.Name = "hr3";
            this.hr3.Size = new System.Drawing.Size(292, 5);
            this.hr3.TabIndex = 14;
            // 
            // hr4
            // 
            this.hr4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.hr4.Location = new System.Drawing.Point(338, 53);
            this.hr4.Name = "hr4";
            this.hr4.Size = new System.Drawing.Size(292, 5);
            this.hr4.TabIndex = 15;
            // 
            // hr7
            // 
            this.hr7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.hr7.Location = new System.Drawing.Point(178, 328);
            this.hr7.Name = "hr7";
            this.hr7.Size = new System.Drawing.Size(292, 5);
            this.hr7.TabIndex = 15;
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.hr7);
            this.Controls.Add(this.hr6);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "signUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signUpForm";
            this.Load += new System.EventHandler(this.signUpForm_Load);
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.DateTimePicker customerBirthDate;
        private System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.CheckBox adminCheckbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Panel hr5;
        private System.Windows.Forms.Panel hr6;
        private System.Windows.Forms.Panel hr4;
        private System.Windows.Forms.Panel hr3;
        private System.Windows.Forms.Panel hr7;
    }
}