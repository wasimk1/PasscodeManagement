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
    public partial class UserRegistration : Form
    {
        string userregfol, userpassfolder = string.Empty;
        String takegen = string.Empty;
        string takedob;
        string regusername;
        string regdob;


        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            checkuserregfolder();
            //disablebuttoncontrol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                
                txtusername.Focus();
                errorProvider1.SetError(txtusername, "Fullname is required!");
                return ;
            }
            else
            {
                
                errorProvider1.SetError(txtusername, string.Empty);
            }

            if (string.IsNullOrEmpty(txtemailid.Text.Trim()))
            {
                txtemailid.Focus();
                errorProvider1.SetError(txtemailid, "Email ID is required!");
                return;
            }
            else {
                errorProvider1.SetError(txtemailid, string.Empty);
            }

            if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
            {
                txtpassword.Focus();
                errorProvider1.SetError(txtpassword, "Password is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtpassword, string.Empty);
            }


            if (!(txtdob.Value.ToString() == string.Empty))
            {
                DateTime maxdate = DateTime.Now;
                if (txtdob.Value > maxdate)
                {
                    txtdob.Focus();
                    errorProvider1.SetError(txtdob, "Date of Birth cannot be future date please select today or past day");
                    return;
                }
                else
                {
                    regdob = txtdob.Value.ToString("yyyy-MM-dd");
                }



            }
            else
            {
                errorProvider1.SetError(txtdob, "Please select Date of Birth");
                txtdob.Focus();
                return;
            }


            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked))
            {
                errorProvider1.SetError(groupBox1, "Radio is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(groupBox1, string.Empty);
            }
            long num = 0;
            long num1 = 0;
            if (string.IsNullOrEmpty(numcontactno.Text.Trim()))
            {
                 
                //if (System.Text.RegularExpressions.Regex.IsMatch(numcontactno.Text, "[^0-9]"))
                //{
                    
                //    MessageBox.Show("Please enter only numbers");
                //    return;
                //    num = Convert.ToInt64(numcontactno.Text);
                //     num1=num.ToString().Length;
                    
                    
                //    if (num1 < 10)
                //    {
                //        MessageBox.Show("Please enter 10 digit number");
                //        return;
                //    }
                //}
                numcontactno.Focus();
                errorProvider1.SetError(numcontactno, "Contact No. is required!");
                return;
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(numcontactno.Text, "[^0-9]"))
                {
                    
                    MessageBox.Show("Please enter only numbers");
                    return;
                    
                    
                    
                }
                num = Convert.ToInt64(numcontactno.Text);
                num1 = num.ToString().Length;
                if (num1 < 10)
                {
                    MessageBox.Show("Please enter 10 digit number");
                    return;
                }
                else if(num1>10) {
                    MessageBox.Show("Please enter 10 digit number");
                    return;
                }
                errorProvider1.SetError(numcontactno, string.Empty);
            }

            doregister();
            this.Close();
            Form1 regtologin = new Form1();
            regtologin.Show();
            
            

        }
        public void checkuserregfolder()
        {
            try
            {
                userregfol = "C:\\PasscodeManagement_Wasim\\UserRegister";
                userpassfolder = "C:\\PasscodeManagement_Wasim\\Password";
                if (!(Directory.Exists(userregfol)) )
                {
                    Directory.CreateDirectory(userregfol);
                    
                }
                if (!(Directory.Exists(userpassfolder))) {
                    Directory.CreateDirectory(userpassfolder);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public void doregister()
        {
            regusername = txtusername.Text;
            string regemail = txtemailid.Text;
            string regpass = txtpassword.Text;
            //regdob = takedob;
            string reggender = takegen;
            string regcon = numcontactno.Text;
            DateTime todaydate = DateTime.Now;


            string user_acc_file = "C:\\PasscodeManagement_Wasim\\UserRegister\\" + regemail + ".txt";
            //string user_acc_pass_file = "C:\\PasscodeManagement_Wasim\\Password\\" + regusername + ".txt";
            try
            {
                if (!File.Exists(user_acc_file) )
                {
                    File.Create(user_acc_file).Dispose();
                    StreamWriter sw = new StreamWriter(user_acc_file);

                    sw.WriteLine(regusername + "\n" + regemail + "\n"  + regpass + "\n" + regdob + "\n" + reggender + "\n" + regcon+"\n"+todaydate.ToShortDateString());
                    sw.Close();
                    //StreamWriter sw1 = new StreamWriter(user_acc_pass_file);
                    //sw1.WriteLine(regpass+ "\n" + todaydate.ToShortDateString());
                    
                    //sw1.Close();
                    MessageBox.Show("User Registration successfull, now please do the login");
                }

                else
                {
                    MessageBox.Show("User already have an account");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string getmale = "Male";
            takegen = getmale;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string getfemale = "Female";
            takegen = getfemale;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string gettransgen = "Transgender";
            takegen = gettransgen;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //takedob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();

        }
        

        private void txtusername_TextChanged(object sender, EventArgs ex)
        {
           
            
        }
        
        private void txtusername_Validating(object sender, CancelEventArgs e)
        {

        }
        public void disablebuttoncontrol() {
            btnreg.Enabled = false;
        }

        private void txtusername_Validating_1(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            //{
            //    e.Cancel = true;
            //    txtusername.Focus();
            //    errorProvider1.SetError(txtusername, "Fullname is required!");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtusername, string.Empty);
            //}
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            //takedob = txtdob.Value.ToString("yyyy-MM-dd");
        }

        //private void dateTimePicker1_Validated(object sender, EventArgs e)
        //{
        //    takedob = txtdob.Value.ToString("yyyy-MM-dd");
        //}
    }
}
