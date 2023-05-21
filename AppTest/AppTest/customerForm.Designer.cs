
namespace AppTest
{
    partial class customerForm
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
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.searchFlightsButton = new System.Windows.Forms.Button();
            this.flightsListButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.helloLabel = new System.Windows.Forms.Label();
            this.sideMenuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.AutoScroll = true;
            this.sideMenuPanel.Controls.Add(this.logOutBtn);
            this.sideMenuPanel.Controls.Add(this.searchFlightsButton);
            this.sideMenuPanel.Controls.Add(this.flightsListButton);
            this.sideMenuPanel.Controls.Add(this.profileButton);
            this.sideMenuPanel.Controls.Add(this.logoPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(250, 544);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.logOutBtn.Location = new System.Drawing.Point(0, 499);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.logOutBtn.Size = new System.Drawing.Size(250, 45);
            this.logOutBtn.TabIndex = 6;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // searchFlightsButton
            // 
            this.searchFlightsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.searchFlightsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchFlightsButton.FlatAppearance.BorderSize = 0;
            this.searchFlightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchFlightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFlightsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.searchFlightsButton.Location = new System.Drawing.Point(0, 228);
            this.searchFlightsButton.Name = "searchFlightsButton";
            this.searchFlightsButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.searchFlightsButton.Size = new System.Drawing.Size(250, 45);
            this.searchFlightsButton.TabIndex = 5;
            this.searchFlightsButton.Text = "Available Flights";
            this.searchFlightsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchFlightsButton.UseVisualStyleBackColor = false;
            this.searchFlightsButton.Click += new System.EventHandler(this.searchFlightsButton_Click);
            // 
            // flightsListButton
            // 
            this.flightsListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.flightsListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.flightsListButton.FlatAppearance.BorderSize = 0;
            this.flightsListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flightsListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightsListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.flightsListButton.Location = new System.Drawing.Point(0, 183);
            this.flightsListButton.Name = "flightsListButton";
            this.flightsListButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flightsListButton.Size = new System.Drawing.Size(250, 45);
            this.flightsListButton.TabIndex = 4;
            this.flightsListButton.Text = "Your Flights";
            this.flightsListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flightsListButton.UseVisualStyleBackColor = false;
            this.flightsListButton.Click += new System.EventHandler(this.flightsListButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.profileButton.Location = new System.Drawing.Point(0, 138);
            this.profileButton.Name = "profileButton";
            this.profileButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.profileButton.Size = new System.Drawing.Size(250, 45);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "Profile";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Controls.Add(this.logoBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 138);
            this.logoPanel.TabIndex = 2;
            this.logoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logoPanel_Paint);
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoBox.Image = global::AppTest.Properties.Resources.landing;
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(250, 138);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(11)))), ((int)(((byte)(35)))));
            this.mainPanel.Controls.Add(this.helloLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(678, 544);
            this.mainPanel.TabIndex = 1;
            // 
            // helloLabel
            // 
            this.helloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.helloLabel.Location = new System.Drawing.Point(0, 0);
            this.helloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(678, 544);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "label1";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helloLabel.Click += new System.EventHandler(this.helloLabel_Click);
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "customerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerForm";
            this.Load += new System.EventHandler(this.customerForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button searchFlightsButton;
        private System.Windows.Forms.Button flightsListButton;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label helloLabel;
    }
}