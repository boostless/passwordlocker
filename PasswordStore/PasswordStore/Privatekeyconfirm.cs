using System;
using System.Windows.Forms;

namespace PasswordStore
{
    public partial class Privatekeyconfirm : Form
    {

        string privatekey;

        public Privatekeyconfirm()
        {
            InitializeComponent();

            privatekey = Properties.Settings.Default.PrivateKey;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == privatekey)
            {
                Properties.Settings.Default.Logged = true;
                Properties.Settings.Default.Save();
                Close();
            }
            else { MessageBox.Show("Incorrect private key!"); }
        }
    }
}
