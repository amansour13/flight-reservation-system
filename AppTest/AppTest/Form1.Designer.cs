
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Button();
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
            this.textBox1.Location = new System.Drawing.Point(114, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(111, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(111, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // aDMINBindingSource5
            // 
            this.aDMINBindingSource5.DataMember = "ADMIN";
            this.aDMINBindingSource5.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(114, 196);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(75, 23);
            this.logIn.TabIndex = 5;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.checkBox1.Location = new System.Drawing.Point(114, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.logIn);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(90, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 244);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(231, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(201, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Not Registered?";
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(204, 429);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(75, 23);
            this.signUp.TabIndex = 10;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(3)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(611, 512);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "LoginPage";
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signUp;
    }
}

