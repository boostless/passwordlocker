using System;
using System.Windows.Forms;
using System.Net.Mail;


namespace PasswordStore
{
    public partial class Signin : Form
    {

        string privatekey;
        string password;
        string username;
        string email;

        public Signin()
        {
            
            InitializeComponent();

            lbl_email.Visible = false;
            lbl_passmatch.Visible = false;
            lbl_passshort.Visible = false;
            lbl_usershort.Visible = false;
        }

        private void Btn_confrim_Click(object sender, EventArgs e)
        {
            //Chekinam username ir password text boxa ar atitinka kriterijus
            if (user_box.Text.Length < 4) { lbl_usershort.Visible = true; return; } else
            { lbl_usershort.Visible = false; }
            //Chekinam emaila
            if (email_box.Text.Length < 5) { MessageBox.Show("Enter your email"); return; }
            if (email_box.Text != cemail_box.Text) { lbl_email.Visible = true; return; } else
            { lbl_email.Visible = false; }
            //Chekinam passworda
            if (pass_box.Text.Length < 8){ lbl_passshort.Visible = true; return; } else { lbl_passshort.Visible = false;  }
            if (cpass_box.Text != pass_box.Text) { lbl_passmatch.Visible = true; return; } else { lbl_passmatch.Visible = false; }

            email = email_box.Text;
            password = pass_box.Text;
            username = user_box.Text;

            //Sukurem privatu rakta kad zmogus galetu pakeisti savo slaptazodi
            privatekey = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
            Console.WriteLine(privatekey);
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);
            Console.WriteLine("Email: " + email);

            
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.PrivateKey = privatekey;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.Email = email;
            Properties.Settings.Default.Save();
            Sendemail(username, email, privatekey);
        }

        private void Sendemail(String uusername, String eemail, String pprivatekey)
        {
            string from = "lograides@gmail.com";

            try
            {
                MailMessage message = new MailMessage();
                message.To.Add(eemail);
                message.Subject = "Private key";
                message.From = new MailAddress(from);
                message.Body = "Your private key is: " + pprivatekey + "\nYour Username is: " + uusername;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Credentials = new System.Net.NetworkCredential("lograides@gmail.com", "rokasp78");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(message);
                MessageBox.Show("Check your email for a private key and then press OK.",
                                    "Important!",
                                    MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                Close();

                Privatekeyconfirm f4 = new Privatekeyconfirm();
                f4.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
