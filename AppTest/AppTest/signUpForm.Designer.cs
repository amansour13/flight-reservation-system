
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.customerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
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
            this.CustomerPanel.Controls.Add(this.textBox5);
            this.CustomerPanel.Controls.Add(this.textBox4);
            this.CustomerPanel.Controls.Add(this.textBox3);
            this.CustomerPanel.Controls.Add(this.textBox2);
            this.CustomerPanel.Controls.Add(this.BirthdateLabel);
            this.CustomerPanel.Controls.Add(this.SSNLabel);
            this.CustomerPanel.Controls.Add(this.customerBirthDate);
            this.CustomerPanel.Controls.Add(this.SSNTextBox);
            this.CustomerPanel.Location = new System.Drawing.Point(173, 84);
            this.CustomerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(579, 412);
            this.CustomerPanel.TabIndex = 0;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(215, 369);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(100, 28);
            this.signUpButton.TabIndex = 14;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // adminCheckbox
            // 
            this.adminCheckbox.AutoSize = true;
            this.adminCheckbox.ForeColor = System.Drawing.Color.White;
            this.adminCheckbox.Location = new System.Drawing.Point(312, 185);
            this.adminCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminCheckbox.Name = "adminCheckbox";
            this.adminCheckbox.Size = new System.Drawing.Size(67, 20);
            this.adminCheckbox.TabIndex = 13;
            this.adminCheckbox.Text = "Admin";
            this.adminCheckbox.UseVisualStyleBackColor = true;
            this.adminCheckbox.CheckedChanged += new System.EventHandler(this.adminCheckbox_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(96, 166);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(96, 100);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 16);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(308, 33);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 16);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(100, 30);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(72, 16);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(100, 186);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 119);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(312, 53);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.ForeColor = System.Drawing.Color.White;
            this.BirthdateLabel.Location = new System.Drawing.Point(96, 298);
            this.BirthdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(60, 16);
            this.BirthdateLabel.TabIndex = 4;
            this.BirthdateLabel.Text = "Birthdate";
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.ForeColor = System.Drawing.Color.White;
            this.SSNLabel.Location = new System.Drawing.Point(96, 235);
            this.SSNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(35, 16);
            this.SSNLabel.TabIndex = 3;
            this.SSNLabel.Text = "SSN";
            // 
            // customerBirthDate
            // 
            this.customerBirthDate.Location = new System.Drawing.Point(100, 318);
            this.customerBirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerBirthDate.Name = "customerBirthDate";
            this.customerBirthDate.Size = new System.Drawing.Size(269, 22);
            this.customerBirthDate.TabIndex = 2;
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(100, 255);
            this.SSNTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(132, 22);
            this.SSNTextBox.TabIndex = 0;
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(880, 587);
            this.Controls.Add(this.CustomerPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            this.Load += new System.EventHandler(this.signUpForm_Load);
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.DateTimePicker customerBirthDate;
        private System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.CheckBox adminCheckbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button signUpButton;
    }
}