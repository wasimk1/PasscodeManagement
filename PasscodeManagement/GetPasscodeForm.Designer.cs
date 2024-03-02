
namespace PasscodeManagement
{
    partial class GetPasscodeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtregisteredsetemail = new System.Windows.Forms.TextBox();
            this.btnfetchedpass = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtfetchedpass = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registered Email ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Get your passcode";
            // 
            // txtregisteredsetemail
            // 
            this.txtregisteredsetemail.Location = new System.Drawing.Point(170, 56);
            this.txtregisteredsetemail.Name = "txtregisteredsetemail";
            this.txtregisteredsetemail.Size = new System.Drawing.Size(205, 22);
            this.txtregisteredsetemail.TabIndex = 0;
            // 
            // btnfetchedpass
            // 
            this.btnfetchedpass.Location = new System.Drawing.Point(170, 112);
            this.btnfetchedpass.Name = "btnfetchedpass";
            this.btnfetchedpass.Size = new System.Drawing.Size(122, 28);
            this.btnfetchedpass.TabIndex = 2;
            this.btnfetchedpass.Text = "Fetch passcode";
            this.btnfetchedpass.UseVisualStyleBackColor = true;
            this.btnfetchedpass.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(167, 159);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back to login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtfetchedpass
            // 
            this.txtfetchedpass.Location = new System.Drawing.Point(170, 84);
            this.txtfetchedpass.Name = "txtfetchedpass";
            this.txtfetchedpass.ReadOnly = true;
            this.txtfetchedpass.Size = new System.Drawing.Size(205, 22);
            this.txtfetchedpass.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GetPasscodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 209);
            this.Controls.Add(this.txtfetchedpass);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnfetchedpass);
            this.Controls.Add(this.txtregisteredsetemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GetPasscodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetPasscodeForm";
            this.Load += new System.EventHandler(this.GetPasscodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtregisteredsetemail;
        private System.Windows.Forms.Button btnfetchedpass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtfetchedpass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}