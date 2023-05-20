
namespace AppTest
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            this.aDMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightReservationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightReservationDataSet = new AppTest.FlightReservationDataSet();
            this.aDMINTableAdapter = new AppTest.FlightReservationDataSetTableAdapters.ADMINTableAdapter();
            this.aDMINBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aIRCRAFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRCRAFTTableAdapter = new AppTest.FlightReservationDataSetTableAdapters.AIRCRAFTTableAdapter();
            this.aDMINBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new AppTest.FlightReservationDataSetTableAdapters.CUSTOMERTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aDMINBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.logIn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.hr1 = new System.Windows.Forms.Panel();
            this.hr2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // aDMINBindingSource
            // 
            this.aDMINBindingSource.DataMember = "ADMIN";
            this.aDMINBindingSource.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // flightReservationDataSetBindingSource
            // 
            this.flightReservationDataSetBindingSource.DataSource = this.flightReservationDataSet;
            this.flightReservationDataSetBindingSource.Position = 0;
            // 
            // flightReservationDataSet
            // 
            this.flightReservationDataSet.DataSetName = "FlightReservationDataSet";
            this.flightReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDMINTableAdapter
            // 
            this.aDMINTableAdapter.ClearBeforeFill = true;
            // 
            // aDMINBindingSource1
            // 
            this.aDMINBindingSource1.DataMember = "ADMIN";
            this.aDMINBindingSource1.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // aIRCRAFTBindingSource
            // 
            this.aIRCRAFTBindingSource.DataMember = "AIRCRAFT";
            this.aIRCRAFTBindingSource.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // aIRCRAFTTableAdapter
            // 
            this.aIRCRAFTTableAdapter.ClearBeforeFill = true;
            // 
            // aDMINBindingSource2
            // 
            this.aDMINBindingSource2.DataMember = "ADMIN";
            this.aDMINBindingSource2.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // aDMINBindingSource3
            // 
            this.aDMINBindingSource3.DataMember = "ADMIN";
            this.aDMINBindingSource3.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // aDMINBindingSource4
            // 
            this.aDMINBindingSource4.DataMember = "ADMIN";
            this.aDMINBindingSource4.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.flightReservationDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.textBox1.Location = new System.Drawing.Point(204, 173);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.textBox2.Location = new System.Drawing.Point(204, 270);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(532, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(200, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(200, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // aDMINBindingSource5
            // 
            this.aDMINBindingSource5.DataMember = "ADMIN";
            this.aDMINBindingSource5.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.Location = new System.Drawing.Point(204, 341);
            this.logIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(532, 45);
            this.logIn.TabIndex = 5;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.checkBox1.Location = new System.Drawing.Point(427, 302);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.hr2);
            this.panel1.Controls.Add(this.hr1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signUp);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.logIn);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(200);
            this.panel1.Size = new System.Drawing.Size(932, 553);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(414, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Not Registered?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.Location = new System.Drawing.Point(204, 470);
            this.signUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(532, 45);
            this.signUp.TabIndex = 10;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.Image = global::AppTest.Properties.Resources.landing1;
            this.logo.Location = new System.Drawing.Point(417, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // hr1
            // 
            this.hr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.hr1.Location = new System.Drawing.Point(204, 201);
            this.hr1.Name = "hr1";
            this.hr1.Size = new System.Drawing.Size(532, 5);
            this.hr1.TabIndex = 12;
            // 
            // hr2
            // 
            this.hr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.hr2.Location = new System.Drawing.Point(204, 292);
            this.hr2.Name = "hr2";
            this.hr2.Size = new System.Drawing.Size(532, 5);
            this.hr2.TabIndex = 13;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Reservtion System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource flightReservationDataSetBindingSource;
        private FlightReservationDataSet flightReservationDataSet;
        private System.Windows.Forms.BindingSource aDMINBindingSource;
        private FlightReservationDataSetTableAdapters.ADMINTableAdapter aDMINTableAdapter;
        private System.Windows.Forms.BindingSource aDMINBindingSource1;
        private System.Windows.Forms.BindingSource aIRCRAFTBindingSource;
        private FlightReservationDataSetTableAdapters.AIRCRAFTTableAdapter aIRCRAFTTableAdapter;
        private System.Windows.Forms.BindingSource aDMINBindingSource2;
        private System.Windows.Forms.BindingSource aDMINBindingSource3;
        private System.Windows.Forms.BindingSource aDMINBindingSource4;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private FlightReservationDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource aDMINBindingSource5;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel hr2;
        private System.Windows.Forms.Panel hr1;
    }
}

