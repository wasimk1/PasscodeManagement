
namespace PasscodeManagement
{
    partial class f
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
            this.storebtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.setstoredbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgetemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btngetshow = new System.Windows.Forms.Button();
            this.txtgetpass = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnupd = new System.Windows.Forms.Button();
            this.txtupdpass = new System.Windows.Forms.TextBox();
            this.txtupdemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblReferesh = new System.Windows.Forms.LinkLabel();
            this.lblclose = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.btndel = new System.Windows.Forms.Button();
            this.txtdelemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.getallaccountname = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // storebtn
            // 
            this.storebtn.Location = new System.Drawing.Point(18, 243);
            this.storebtn.Name = "storebtn";
            this.storebtn.Size = new System.Drawing.Size(128, 23);
            this.storebtn.TabIndex = 2;
            this.storebtn.Text = "Store Password";
            this.storebtn.UseVisualStyleBackColor = true;
            this.storebtn.Click += new System.EventHandler(this.storebtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(18, 46);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(123, 23);
            this.showbtn.TabIndex = 0;
            this.showbtn.Text = "Show Password";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(550, 46);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(146, 25);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.Text = "Update Password";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(550, 243);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(143, 23);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "Delete Password";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.genbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(1196, 9);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 27);
            this.logoutbtn.TabIndex = 4;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Account name/EmailID/Account NIckname";
            this.label2.Visible = false;
            // 
            // txtacc
            // 
            this.txtacc.Location = new System.Drawing.Point(18, 289);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(376, 22);
            this.txtacc.TabIndex = 14;
            this.txtacc.Visible = false;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(18, 334);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(376, 22);
            this.txtpass.TabIndex = 15;
            this.txtpass.Visible = false;
            // 
            // setstoredbtn
            // 
            this.setstoredbtn.Location = new System.Drawing.Point(15, 362);
            this.setstoredbtn.Name = "setstoredbtn";
            this.setstoredbtn.Size = new System.Drawing.Size(191, 28);
            this.setstoredbtn.TabIndex = 16;
            this.setstoredbtn.Text = "Stored";
            this.setstoredbtn.UseVisualStyleBackColor = true;
            this.setstoredbtn.Visible = false;
            this.setstoredbtn.Click += new System.EventHandler(this.setstoredbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Password";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Account name/EmailID/Account NIckname";
            this.label3.Visible = false;
            // 
            // txtgetemail
            // 
            this.txtgetemail.Location = new System.Drawing.Point(15, 93);
            this.txtgetemail.Name = "txtgetemail";
            this.txtgetemail.Size = new System.Drawing.Size(379, 22);
            this.txtgetemail.TabIndex = 4;
            this.txtgetemail.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            this.label4.Visible = false;
            // 
            // btngetshow
            // 
            this.btngetshow.Location = new System.Drawing.Point(18, 166);
            this.btngetshow.Name = "btngetshow";
            this.btngetshow.Size = new System.Drawing.Size(191, 28);
            this.btngetshow.TabIndex = 6;
            this.btngetshow.Text = "Show";
            this.btngetshow.UseVisualStyleBackColor = true;
            this.btngetshow.Visible = false;
            this.btngetshow.Click += new System.EventHandler(this.btngetshow_Click);
            // 
            // txtgetpass
            // 
            this.txtgetpass.Location = new System.Drawing.Point(18, 138);
            this.txtgetpass.Name = "txtgetpass";
            this.txtgetpass.ReadOnly = true;
            this.txtgetpass.Size = new System.Drawing.Size(376, 22);
            this.txtgetpass.TabIndex = 5;
            this.txtgetpass.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password";
            this.label5.Visible = false;
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(550, 166);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(191, 28);
            this.btnupd.TabIndex = 11;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Visible = false;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // txtupdpass
            // 
            this.txtupdpass.Location = new System.Drawing.Point(553, 138);
            this.txtupdpass.Name = "txtupdpass";
            this.txtupdpass.Size = new System.Drawing.Size(376, 22);
            this.txtupdpass.TabIndex = 10;
            this.txtupdpass.Visible = false;
            // 
            // txtupdemail
            // 
            this.txtupdemail.Location = new System.Drawing.Point(551, 93);
            this.txtupdemail.Name = "txtupdemail";
            this.txtupdemail.Size = new System.Drawing.Size(379, 22);
            this.txtupdemail.TabIndex = 9;
            this.txtupdemail.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Account name/EmailID/Account NIckname";
            this.label6.Visible = false;
            // 
            // lblReferesh
            // 
            this.lblReferesh.AutoSize = true;
            this.lblReferesh.Location = new System.Drawing.Point(219, 173);
            this.lblReferesh.Name = "lblReferesh";
            this.lblReferesh.Size = new System.Drawing.Size(62, 16);
            this.lblReferesh.TabIndex = 7;
            this.lblReferesh.TabStop = true;
            this.lblReferesh.Text = "Referesh";
            this.lblReferesh.Visible = false;
            this.lblReferesh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReferesh_LinkClicked);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Location = new System.Drawing.Point(286, 173);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(42, 16);
            this.lblclose.TabIndex = 8;
            this.lblclose.TabStop = true;
            this.lblclose.Text = "Close";
            this.lblclose.Visible = false;
            this.lblclose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblclose_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(282, 370);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 16);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Close";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(215, 370);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(62, 16);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Referesh";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(818, 173);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(42, 16);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Close";
            this.linkLabel3.Visible = false;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(751, 173);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(62, 16);
            this.linkLabel4.TabIndex = 12;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Referesh";
            this.linkLabel4.Visible = false;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(820, 324);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(42, 16);
            this.linkLabel5.TabIndex = 22;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Close";
            this.linkLabel5.Visible = false;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(753, 324);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(62, 16);
            this.linkLabel6.TabIndex = 21;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Referesh";
            this.linkLabel6.Visible = false;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(552, 317);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(191, 28);
            this.btndel.TabIndex = 20;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Visible = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // txtdelemail
            // 
            this.txtdelemail.Location = new System.Drawing.Point(553, 289);
            this.txtdelemail.Name = "txtdelemail";
            this.txtdelemail.Size = new System.Drawing.Size(379, 22);
            this.txtdelemail.TabIndex = 19;
            this.txtdelemail.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Account name/EmailID/Account NIckname";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1097, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 32);
            this.label7.TabIndex = 33;
            this.label7.Text = "Creted and Developed by-\r\n                     Wasim Khan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Passcode Management - Perform operation";
            // 
            // getallaccountname
            // 
            this.getallaccountname.AutoSize = true;
            this.getallaccountname.Location = new System.Drawing.Point(976, 54);
            this.getallaccountname.Name = "getallaccountname";
            this.getallaccountname.Size = new System.Drawing.Size(174, 16);
            this.getallaccountname.TabIndex = 35;
            this.getallaccountname.TabStop = true;
            this.getallaccountname.Text = "Get all stored Account name";
            this.getallaccountname.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getallaccountname_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(979, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(184, 218);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(1123, 310);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(42, 16);
            this.linkLabel7.TabIndex = 37;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Close";
            this.linkLabel7.Visible = false;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 422);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.getallaccountname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.txtdelemail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.lblReferesh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.txtupdpass);
            this.Controls.Add(this.txtupdemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngetshow);
            this.Controls.Add(this.txtgetpass);
            this.Controls.Add(this.txtgetemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setstoredbtn);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.storebtn);
            this.Name = "f";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Menu";
            this.Load += new System.EventHandler(this.ChooseMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button storebtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button setstoredbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgetemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngetshow;
        private System.Windows.Forms.TextBox txtgetpass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.TextBox txtupdpass;
        private System.Windows.Forms.TextBox txtupdemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lblReferesh;
        private System.Windows.Forms.LinkLabel lblclose;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtdelemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel getallaccountname;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel7;
    }
}