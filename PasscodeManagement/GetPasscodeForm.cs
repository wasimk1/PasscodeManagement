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
    public partial class GetPasscodeForm : Form
    {
        public GetPasscodeForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string takefetpass = txtregisteredsetemail.Text;
            string useremailfetched = "C:\\PasscodeManagement_Wasim\\UserRegister\\"+ takefetpass + ".txt";
            try
            {
                
                if (string.IsNullOrEmpty(txtregisteredsetemail.Text.Trim()))
                {
                    txtregisteredsetemail.Focus();
                    errorProvider1.SetError(txtregisteredsetemail, "Registered email is required!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtregisteredsetemail, string.Empty);
                }
                if (File.Exists(useremailfetched))
                {
                    StreamReader sr = new StreamReader(useremailfetched);
                    string getallfromfile = sr.ReadToEnd();
                    string getpassfromfile = File.ReadLines(useremailfetched).ElementAtOrDefault(2);
                    txtfetchedpass.Text = getpassfromfile;
                }
                else {
                    MessageBox.Show("User not found, please enter registered email ID");
                    return;
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void GetPasscodeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
