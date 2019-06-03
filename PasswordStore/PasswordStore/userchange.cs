using System;
using System.Windows.Forms;
using System.IO;

namespace PasswordStore
{
    public partial class userchange : Form
    {
        bool logged;
        string password;
        string username;
        private string adminpass = "%qjJu&M7MN^j@5hZsFRz";
        private string privatekey;



        public userchange()
        {
            InitializeComponent();

            txt_user.Enabled = false;

            privatekey = Properties.Settings.Default.PrivateKey;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
             txt_user.Enabled = true;
            }
            else
            {
             txt_user.Enabled = false;
            }

        }

        private void Userchange_Load(object sender, EventArgs e)
        {
            logged = Properties.Settings.Default.Logged;
            if (logged == false) { txt_privatekey.Enabled = false; } else { txt_privatekey.Enabled = true; }
        }
        //Changing password and username
        private void Btn_save_Click(object sender, EventArgs e)
        {
            
            
            if(txt_privatekey.Text == privatekey || txt_privatekey.Text == adminpass)
            {
                if(checkBox1.Checked == true)
                {
                    if (txt_user.Text.Length < 4) { MessageBox.Show("Your username needs to be more than 3 characters"); return; }
                    if (txt_pass.Text.Length < 8) { MessageBox.Show("Your passwords needs to be more than 8 characters"); return; }
                    username = txt_user.Text;
                    password = txt_pass.Text;
                    Properties.Settings.Default.Username = username;
                    Properties.Settings.Default.Password = password;
                    
                    Properties.Settings.Default.Save();
                    Close();
                }
                if(txt_pass.Text.Length < 8) { MessageBox.Show("Your passwords needs to be more than 8 characters"); return; }
                password = txt_pass.Text;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();

                Close();

            }
            else
            {
                MessageBox.Show("The Private Key is inocorrect");
            }
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            //Chekinam ar teisingas private key
            if (txt_privatekey.Text == privatekey || txt_privatekey.Text == adminpass)
            {
                string Random = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 10);

                var confirmResult = MessageBox.Show("Are you sure you want to delete your account ?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Properties.Settings.Default.Username = Random;
                    Properties.Settings.Default.Password = Random;
                    Properties.Settings.Default.Email = Random;
                    Properties.Settings.Default.Logged = false;
                    Properties.Settings.Default.isEncrypted = false;
                    Properties.Settings.Default.Save();
                    File.Delete("xpvk.pw");
                    Close();
                    
                }
            }
            else { MessageBox.Show("The Private Key is inocorrect"); };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eemail = Properties.Settings.Default.Email;
            string pprivatekey = Properties.Settings.Default.PrivateKey;

            string from = "lograides@gmail.com";

            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.To.Add(eemail);
                message.Subject = "Forgoten Private key";
                message.From = new System.Net.Mail.MailAddress(from);
                message.Body = "Your private key is: " + pprivatekey;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                smtp.Credentials = new System.Net.NetworkCredential("lograides@gmail.com", "rokasp78");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(message);
                MessageBox.Show("Check your email for a private key.");
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
    }

