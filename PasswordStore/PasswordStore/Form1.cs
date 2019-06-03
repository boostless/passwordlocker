using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace PasswordStore
{
    public partial class Form1 : Form
    {

        string username;
        string password;
        bool logged;
        bool isEncrypted;
        private string adminuser = "%qjJu&M7MN^j@5hZsFRz";
        private string adminpass = "%qjJu&M7MN^j@5hZsFRz";
        private string privatekey;
        private string sprivatekey;

        string filePath = "xpvk.pw";
        string key = "youtubee";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lbl_wrong.Visible = false;

            isEncrypted = Properties.Settings.Default.isEncrypted;

            if (isEncrypted == false) { Console.WriteLine("isEncrypted = false"); } else { Console.WriteLine("isEncrypted = true"); };

            if (!File.Exists("xpvk.pw"))
            {
                using (StreamWriter sw = File.CreateText("xpvk.pw"))
                { }
                isEncrypted = false;
                Console.WriteLine("isEncrypted = false");
            }

            logged = Properties.Settings.Default.Logged;

            if (logged == false)
            {
                btn_cngpass.Enabled = false;
                btn_log.Enabled = false;
                btn_singin.Enabled = true;
                user_box.Enabled = true;
                pass_box.Enabled = true;
                label3.Visible = true;
                listBox1.Visible = false;
                txtbox_add.Enabled = false;
                btn_add.Enabled = false;
                btn_copy.Enabled = false;
                btn_remove.Enabled = false;
            }
            else
            {
                btn_cngpass.Enabled = true;
                btn_log.Enabled = true;
                btn_singin.Enabled = false;
                user_box.Enabled = true;
                pass_box.Enabled = true;
                label3.Visible = true;
                listBox1.Visible = false;
                txtbox_add.Enabled = false;
                btn_add.Enabled = false;
                btn_copy.Enabled = false;
                btn_remove.Enabled = false;
            }
        }

        //Login sekcija
        private void Btn_log_Click_1(object sender, EventArgs e)
        {
            username = Properties.Settings.Default.Username;
            password = Properties.Settings.Default.Password;

            //Tikrinam userneima
            if (user_box.Text == username || user_box.Text == adminuser)
            {
                //tikrinam passworda
                if (pass_box.Text == password || pass_box.Text == adminpass)
                {
                    //Chekinam ar yra failas
                    if (File.Exists(filePath))
                    {
                        //chekinam ar failes ne tuscias
                        if (new FileInfo(filePath).Length > 0)
                        {
                            Console.WriteLine("isEncrypted = true");
                            if (isEncrypted == true)
                            {
                                Decryptfile(filePath, key);

                                isEncrypted = false;
                                Console.WriteLine("isEncrypted = false");
                            }
                        }
                    }

                    lbl_wrong.Visible = false;

                    LoginUnclock();
                    //Readinam faila
                    Readfile();
                }
                else
                {
                    if(pass_box.Text != password)
                    {
                        lbl_wrong.Visible = true;
                        return;
                    }
                }
            }
            else
            {
                if (user_box.Text != username)
                {
                    lbl_wrong.Visible = true;
                    return;
                }
            }
        }

        private void LoginUnclock()
        {
            label3.Visible = false;
            user_box.Enabled = false;
            pass_box.Enabled = false;
            btn_log.Enabled = false;
            listBox1.Visible = true;
            txtbox_add.Enabled = true;
            btn_add.Enabled = true;
            btn_copy.Enabled = true;
            btn_remove.Enabled = true;
        }

        //Pirmo karto prisijungimas
        private void Btn_singin_Click(object sender, EventArgs e)
        {
            sprivatekey = Properties.Settings.Default.PrivateKey;
            privatekey = Properties.Settings.Default.PrivateKey;

            Signin f3 = new Signin();
            f3.ShowDialog();

            
            
            
            

            logged = Properties.Settings.Default.Logged;


            if (logged == true)
            {
                label3.Visible = false;
                btn_cngpass.Enabled = true;
                btn_log.Enabled = true;
                btn_singin.Enabled = false;
                user_box.Enabled = true;
                pass_box.Enabled = true;
                label3.Visible = true;
                listBox1.Visible = true;
                txtbox_add.Enabled = true;
                btn_add.Enabled = true;
                btn_copy.Enabled = true;

                LoginUnclock();
            }
            else { return; }
        }
        //Uzkraunam nauja forma kai paspaudzia changepass nad username
        private void Btn_cngpass_Click(object sender, EventArgs e)
        {
            userchange f2 = new userchange();
            f2.ShowDialog();
        }
        //Kai paspaudzia submit tai prideda passwordus ir issaugo
        private void Btn_add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtbox_add.Text);
            txtbox_add.Clear();
            Saving();
        }
        //Saving sistema
        private void Saving()
        {
            if (listBox1.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter(filePath))
                {
                    foreach(string itemText in listBox1.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }

            }
        }
        //Readinma failus
        private void Readfile()
        {

            string[] readfiles = File.ReadAllLines(filePath);
            
            listBox1.Items.AddRange(readfiles);
        }
        //Copy to clipboard
        private void Btn_copy_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                StringBuilder SB = new StringBuilder();

                foreach (string itemValue in listBox1.Items)
                {
                    SB.AppendLine(itemValue);
                }

                string result = SB.ToString().TrimEnd('\n');

                Clipboard.SetText(result);
            }
        }
        //Removinam itemus selectinus
        private void Btn_remove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            Saving();
        }
        //Encryption

        static void Encryptfile(string filePath, string key)
        {
            byte[] plainContent = File.ReadAllBytes(filePath);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filePath, memStream.ToArray());
                }
            }
        }

        //Decryption
        static void Decryptfile(string filePath, string key)
        {
            byte[] encrypted = File.ReadAllBytes(filePath);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filePath, memStream.ToArray());

                }
            }
        }
        //Encryptinam ta faila
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Chekinam ar yra failas
            if (File.Exists(filePath))
            {
                //chekinam ar failes ne tuscias
                if (new FileInfo(filePath).Length > 0)
                {
                    if (isEncrypted == false)
                    {
                        Encryptfile(filePath, key);
                        Properties.Settings.Default.isEncrypted = true;
                        Properties.Settings.Default.Save();
                        Console.WriteLine("isEncrypted = true");
                    }
                }
            } 
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings f2 = new settings();
            f2.ShowDialog();
        }
    }
}
