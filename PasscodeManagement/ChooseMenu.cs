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
    public partial class f : Form
    {
        
        Form1 f1;
        string filepassname,email = string.Empty;
        string checkpassword_fol = "C:\\PasscodeManagement_Wasim\\Password";
        
        public f(Form1 frm1)
        {
           
            InitializeComponent();
            this.f1 = frm1;
            //txtgetpass.ReadOnly = true;
        }

        private void ChooseMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;         
            //textBox1.Text = f1.txtlogemail.txt;
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            showcontrols();
            showbtn.Enabled = false;

        }
        public void showcontrols() {
            label3.Visible = true;
            label4.Visible = true;
            txtgetemail.Visible = true;
            txtgetpass.Visible = true;
            btngetshow.Visible = true;
            lblReferesh.Visible = true;
            lblclose.Visible = true;
            txtgetemail.ReadOnly = false;
            //txtgetpass.ReadOnly = false;
            btngetshow.Enabled = true;
        }

        private void btngetshow_Click(object sender, EventArgs e)
        {
            
            try
            {

                 email = txtgetemail.Text.Trim();
               
                if (string.IsNullOrEmpty(txtgetemail.Text.Trim()))
                {
                    txtgetemail.Focus();
                    errorProvider1.SetError(txtgetemail, "Email ID is required!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtgetemail, string.Empty);
                }

                string showfile = "C:\\PasscodeManagement_Wasim\\Password\\" + email.Trim()+ ".txt";
                if (File.Exists(showfile))
                {
                    StreamReader sr = new StreamReader(showfile);
                    sr.ReadToEnd();
                    string getpass = File.ReadLines(showfile).ElementAtOrDefault(1);
                    txtgetpass.Text=getpass;
                    txtgetemail.ReadOnly = true;
                    txtgetpass.ReadOnly = true;
                    btngetshow.Enabled = false;
                    sr.Close();
                }
                else {
                    MessageBox.Show("Invalid emailID or account name");
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void storebtn_Click(object sender, EventArgs e)
        {

            show_storedcontrols();
            storebtn.Enabled = false;
        }
        public void storedpass() {
            try
            {

                //email = txtacc.Text.Trim();

                if (string.IsNullOrEmpty(txtacc.Text.Trim()))
                {
                    txtacc.Focus();
                    errorProvider1.SetError(txtacc, "Email ID is required!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtacc, string.Empty);
                }
                if (string.IsNullOrEmpty(txtpass.Text.Trim()))
                {
                    txtpass.Focus();
                    errorProvider1.SetError(txtpass, "Password is required!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtpass, string.Empty);
                }

                string emailornickname = txtacc.Text.Trim();
                string strpass = txtpass.Text.Trim();
                DateTime todaydate = DateTime.Now;
                string filepassname = "C:\\PasscodeManagement_Wasim\\Password\\" + emailornickname + ".txt";
                
                //string checkpassword_fol = "C:\\PasscodeManagement_Wasim\\Password";
                if (Directory.Exists(checkpassword_fol))
                {
                    if (!(File.Exists(filepassname)))
                    {
                        File.Create(filepassname).Dispose();
                        StreamWriter sw = new StreamWriter(filepassname);
                        sw.WriteLine(emailornickname + "\n" + strpass + "\n" + todaydate.ToString());
                        sw.Close();
                        MessageBox.Show("Password stored successfully");
                    }
                    else
                    {
                        MessageBox.Show("Password is already saved with this " + emailornickname + " account, to store new password please change the account name");
                        return;
                    }
                }
                else
                {
                    Directory.CreateDirectory(checkpassword_fol);
                    if (!(File.Exists(filepassname)))
                    {
                        File.Create(filepassname).Dispose();
                        StreamWriter sw = new StreamWriter(filepassname);
                        sw.WriteLine(emailornickname + "\n" + strpass + "\n" + todaydate.ToString());
                        sw.Close();
                        MessageBox.Show("Password stored successfully");
                    }
                    else
                    {
                        MessageBox.Show("Password is already saved with this " + emailornickname + " account, to store new password please change the account name");
                        return;
                    }
                }
                txtpass.ReadOnly = true;
                txtacc.ReadOnly = true;
                setstoredbtn.Enabled = false;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        public void show_storedcontrols() {
            label2.Visible = true;
            label1.Visible = true;
            setstoredbtn.Visible = true;
            txtpass.Visible = true;
            txtacc.Visible = true;
            linkLabel2.Visible = true;
            linkLabel1.Visible = true;
        }

        private void lblReferesh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtgetemail.Text="";
                txtgetpass.Text = "";
            txtgetemail.ReadOnly = false;
            //txtgetpass.ReadOnly = false;
            btngetshow.Enabled = true;
            //showbtn.Enabled = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtpass.ReadOnly = false;
            txtacc.ReadOnly = false;
            txtpass.Text = "";
                txtacc.Text = "";
            setstoredbtn.Enabled = true;
        }

        private void lblclose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtgetemail.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtgetpass.Visible = false;
            btngetshow.Visible = false;
            lblReferesh.Visible = false;
            lblclose.Visible = false;
            txtgetemail.Text = "";
                txtgetpass.Text = "";
            showbtn.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Visible = false;
            txtacc.Visible = false;
            label1.Visible = false;
            txtpass.Visible = false;
            setstoredbtn.Visible = false;
            linkLabel2.Visible = false;
            linkLabel1.Visible = false;
            storebtn.Enabled = true;
            txtpass.Text = "";
            txtacc.Text = "";
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            show_update_controls();
            updatebtn.Enabled = false;
        }

        private void setstoredbtn_Click(object sender, EventArgs e)
        {
            storedpass();
           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Visible = false;
            txtupdemail.Visible = false;
            label5.Visible = false;
            txtupdpass.Visible = false;
            btnupd.Visible = false;
            linkLabel4.Visible = false;
            linkLabel3.Visible = false;
            txtupdemail.Text = "";
                txtupdpass.Text = "";
            updatebtn.Enabled = true;
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            updatepass();
        }

        public void show_update_controls() {
            label6.Visible = true;
            txtupdemail.Visible = true;
            label5.Visible = true;
            txtupdpass.Visible = true;
            btnupd.Visible = true;
            linkLabel4.Visible = true;
            linkLabel3.Visible = true;
            txtupdpass.ReadOnly = false;
            txtupdemail.ReadOnly = false;
            btnupd.Enabled = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtupdpass.Text = "";
            txtupdemail.Text = "";
            txtupdpass.ReadOnly = false;
            txtupdemail.ReadOnly = false;
            btnupd.Enabled = true;
        }

        private void genbtn_Click(object sender, EventArgs e)
        {
            show_del_controls();
            delbtn.Enabled = false;
        }
        public void show_del_controls() {
            label8.Visible = true;
            txtdelemail.Visible = true;
            
            btndel.Visible = true;
            linkLabel6.Visible = true;
            linkLabel5.Visible = true;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            deletepassword();
        }

        public void updatepass() {
            try
            {

                if (string.IsNullOrEmpty(txtupdemail.Text.Trim()))
                {
                    txtupdemail.Focus();
                    errorProvider1.SetError(txtupdemail, "Email ID is required!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtupdemail, string.Empty);
                }
                if (string.IsNullOrEmpty(txtupdpass.Text.Trim()))
                {
                    txtupdpass.Focus();
                    errorProvider1.SetError(txtupdpass, "Password is required!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtupdpass, string.Empty);
                }
                string emailornickname = txtupdemail.Text.Trim();
                string strpass = txtupdpass.Text.Trim();
                DateTime todaydate = DateTime.Now;
                string filepassname = "C:\\PasscodeManagement_Wasim\\Password\\" + emailornickname + ".txt";

                if (Directory.Exists(checkpassword_fol))
                {
                    if (File.Exists(filepassname))
                    {
                        File.Delete(filepassname);
                        File.Create(filepassname).Dispose();
                            StreamWriter sw = new StreamWriter(filepassname);
                        sw.WriteLine(emailornickname + "\n" + strpass + "\n" + todaydate.ToString());
                        sw.Close();
                        MessageBox.Show("Password updated successfully");
                        //File.Exists(filepassname);
                    }
                    else
                    {
                        MessageBox.Show("Please provide the valid account emailID or nick name");
                        return;
                    }
                }
                else
                {
                    Directory.CreateDirectory(checkpassword_fol);
                    if (File.Exists(filepassname))
                    {
                        File.Delete(filepassname);
                        File.Create(filepassname).Dispose();
                        StreamWriter sw = new StreamWriter(filepassname);
                        sw.WriteLine(emailornickname + "\n" + strpass + "\n" + todaydate.ToString());
                        sw.Close();
                        MessageBox.Show("Password updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Please provide the valid account emailID or nick name");
                        return;
                    }
                }
                txtupdpass.ReadOnly = true;
                    txtupdemail.ReadOnly = true;
                btnupd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtdelemail.Text = "";
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label8.Visible = false;
                txtdelemail.Visible = false;
            btndel.Visible = false;
            linkLabel6.Visible = false;
            linkLabel5.Visible = false;
            delbtn.Enabled = true;
        }

        

        public void deletepassword() {

            try
            {

                //email = txtacc.Text.Trim();

                if (string.IsNullOrEmpty(txtdelemail.Text.Trim()))
                {
                    txtdelemail.Focus();
                    errorProvider1.SetError(txtdelemail, "Email ID is required!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtdelemail, string.Empty);
                }
                

                string emailornickname = txtdelemail.Text.Trim();
                string filepassname = "C:\\PasscodeManagement_Wasim\\Password\\" + emailornickname + ".txt";
                if (Directory.Exists(checkpassword_fol))
                {
                    if (File.Exists(filepassname))
                    {
                        File.Delete(filepassname);
                        MessageBox.Show("Account deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Please provide the valid account emailID or nickname");
                        return;
                    }
                }
                else
                {
                    Directory.CreateDirectory(checkpassword_fol);
                    if (File.Exists(filepassname))
                    {
                        File.Delete(filepassname);
                        MessageBox.Show("Account deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Please provide the valid account emailID or nickname");
                        return;
                    }
                }
                txtdelemail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getallaccountname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                
                
                string dir_folder = "C:\\PasscodeManagement_Wasim\\Password";
                if (Directory.Exists(dir_folder))
                {
                    getallaccountname.Visible = false;
                    richTextBox1.Visible = true;
                    linkLabel7.Visible = true;
                    DirectoryInfo dir = new DirectoryInfo(dir_folder);

                    FileInfo[] Files = dir.GetFiles("*.txt");
                    int len = Files.Length;
                    if (len==0) {
                        richTextBox1.Visible = false;
                        linkLabel7.Visible = false;
                        
                        MessageBox.Show("No files found");
                        getallaccountname.Visible = true;
                        return;
                    }
                    string str = "";
                    string updatedfilename = "";

                    foreach (FileInfo file in Files)
                    {
                        str = file.Name;
                        int index = str.IndexOf(".");
                         updatedfilename = str.Substring(0, index);
                        string allfilename = updatedfilename + "\n";

                        richTextBox1.Text += allfilename;
                    }
                }
                else {
                    MessageBox.Show("Directory not found");
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox1.Text = "";
            getallaccountname.Visible = true;
            linkLabel7.Visible = false;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
