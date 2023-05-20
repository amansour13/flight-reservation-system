
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
            this.CustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerPanel
            // 
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
            this.CustomerPanel.Location = new System.Drawing.Point(130, 68);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(434, 335);
            this.CustomerPanel.TabIndex = 0;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(161, 300);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 14;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // adminCheckbox
            // 
            this.adminCheckbox.AutoSize = true;
            this.adminCheckbox.ForeColor = System.Drawing.Color.White;
            this.adminCheckbox.Location = new System.Drawing.Point(234, 150);
            this.adminCheckbox.Name = "adminCheckbox";
            this.adminCheckbox.Size = new System.Drawing.Size(62, 21);
            this.adminCheckbox.TabIndex = 13;
            this.adminCheckbox.Text = "Admin";
            this.adminCheckbox.UseVisualStyleBackColor = true;
            this.adminCheckbox.CheckedChanged += new System.EventHandler(this.adminCheckbox_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(72, 135);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(72, 81);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(231, 27);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(75, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(75, 151);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 8;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(75, 97);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 7;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(234, 43);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 6;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(75, 43);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 20);
            this.firstNameText.TabIndex = 5;
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.ForeColor = System.Drawing.Color.White;
            this.BirthdateLabel.Location = new System.Drawing.Point(72, 242);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(49, 13);
            this.BirthdateLabel.TabIndex = 4;
            this.BirthdateLabel.Text = "Birthdate";
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.ForeColor = System.Drawing.Color.White;
            this.SSNLabel.Location = new System.Drawing.Point(72, 191);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(29, 13);
            this.SSNLabel.TabIndex = 3;
            this.SSNLabel.Text = "SSN";
            // 
            // customerBirthDate
            // 
            this.customerBirthDate.Location = new System.Drawing.Point(75, 258);
            this.customerBirthDate.Name = "customerBirthDate";
            this.customerBirthDate.Size = new System.Drawing.Size(203, 20);
            this.customerBirthDate.TabIndex = 2;
            this.customerBirthDate.ValueChanged += new System.EventHandler(this.customerBirthDate_ValueChanged);
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(75, 207);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(100, 20);
            this.SSNTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alredy have an account?";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(291, 442);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(660, 477);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerPanel);
            this.Name = "signUpForm";
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
    }
}