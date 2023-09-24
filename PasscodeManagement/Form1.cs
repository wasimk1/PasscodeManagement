using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasscodeManagement
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtlogemail.Text.Trim()))
                {

                    txtlogemail.Focus();
                    errorProvider1.SetError(txtlogemail, "Email ID is required!");
                    return;
                }
                else
                {

                    errorProvider1.SetError(txtlogemail, string.Empty);
                }

                if (string.IsNullOrEmpty(txtlogpass.Text.Trim()))
                {

                    txtlogpass.Focus();
                    errorProvider1.SetError(txtlogpass, "Password is required!");
                    return;
                }
                else
                {

                    errorProvider1.SetError(txtlogpass, string.Empty);
                }
                dologin();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            UserRegistration ur = new UserRegistration();
            ur.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetPasscodeForm get_user_pass = new GetPasscodeForm();
            get_user_pass.ShowDialog();

        }
        public void dologin() {
            try
            {
                
                string logemailid = txtlogemail.Text.Trim();
                //Label lbl.text = logemailid;
                
                string logpass = txtlogpass.Text.Trim();
                string loginfile = "C:\\PasscodeManagement_Wasim\\UserRegister\\" + logemailid.Trim() + ".txt";
                if (File.Exists(loginfile))
                {
                    StreamReader sr = new StreamReader(loginfile);
                    sr.ReadToEnd();
                    string getpass = File.ReadLines(loginfile).ElementAtOrDefault(2);

                    if (logpass.Equals(getpass))
                    {
                        this.Close();
                        f cm = new f(this);
                        //txtlogemail.Text.Trim();
                        cm.Show();

                    }
                    else {
                        MessageBox.Show("Invalid credentials");
                        return;
                    }
                }
                else {
                    MessageBox.Show("User not found, please provide the valid details, or create a new account");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



        }
    }
}
