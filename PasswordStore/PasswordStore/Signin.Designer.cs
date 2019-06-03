namespace PasswordStore
{
    partial class Signin
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
            this.user_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cemail_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cpass_box = new System.Windows.Forms.TextBox();
            this.Btn_confrim = new System.Windows.Forms.Button();
            this.lbl_usershort = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_passshort = new System.Windows.Forms.Label();
            this.lbl_passmatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_box
            // 
            this.user_box.Location = new System.Drawing.Point(12, 21);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(132, 20);
            this.user_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(12, 60);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(132, 20);
            this.email_box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            // 
            // cemail_box
            // 
            this.cemail_box.Location = new System.Drawing.Point(12, 99);
            this.cemail_box.Name = "cemail_box";
            this.cemail_box.Size = new System.Drawing.Size(132, 20);
            this.cemail_box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm email:";
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(12, 138);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(132, 20);
            this.pass_box.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm password:";
            // 
            // cpass_box
            // 
            this.cpass_box.Location = new System.Drawing.Point(12, 177);
            this.cpass_box.Name = "cpass_box";
            this.cpass_box.PasswordChar = '*';
            this.cpass_box.Size = new System.Drawing.Size(132, 20);
            this.cpass_box.TabIndex = 12;
            // 
            // Btn_confrim
            // 
            this.Btn_confrim.Location = new System.Drawing.Point(12, 203);
            this.Btn_confrim.Name = "Btn_confrim";
            this.Btn_confrim.Size = new System.Drawing.Size(132, 23);
            this.Btn_confrim.TabIndex = 13;
            this.Btn_confrim.Text = "Confirm";
            this.Btn_confrim.UseVisualStyleBackColor = true;
            this.Btn_confrim.Click += new System.EventHandler(this.Btn_confrim_Click);
            // 
            // lbl_usershort
            // 
            this.lbl_usershort.AutoSize = true;
            this.lbl_usershort.ForeColor = System.Drawing.Color.Red;
            this.lbl_usershort.Location = new System.Drawing.Point(70, 5);
            this.lbl_usershort.Name = "lbl_usershort";
            this.lbl_usershort.Size = new System.Drawing.Size(52, 13);
            this.lbl_usershort.TabIndex = 14;
            this.lbl_usershort.Text = "Too short";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.Red;
            this.lbl_email.Location = new System.Drawing.Point(81, 83);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(73, 13);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Doesnt match";
            // 
            // lbl_passshort
            // 
            this.lbl_passshort.AutoSize = true;
            this.lbl_passshort.ForeColor = System.Drawing.Color.Red;
            this.lbl_passshort.Location = new System.Drawing.Point(70, 122);
            this.lbl_passshort.Name = "lbl_passshort";
            this.lbl_passshort.Size = new System.Drawing.Size(52, 13);
            this.lbl_passshort.TabIndex = 16;
            this.lbl_passshort.Text = "Too short";
            // 
            // lbl_passmatch
            // 
            this.lbl_passmatch.AutoSize = true;
            this.lbl_passmatch.ForeColor = System.Drawing.Color.Red;
            this.lbl_passmatch.Location = new System.Drawing.Point(92, 161);
            this.lbl_passmatch.Name = "lbl_passmatch";
            this.lbl_passmatch.Size = new System.Drawing.Size(62, 13);
            this.lbl_passmatch.TabIndex = 17;
            this.lbl_passmatch.Text = "Dont match";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 237);
            this.Controls.Add(this.lbl_passmatch);
            this.Controls.Add(this.lbl_passshort);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_usershort);
            this.Controls.Add(this.Btn_confrim);
            this.Controls.Add(this.cpass_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cemail_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Signin";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cemail_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpass_box;
        private System.Windows.Forms.Button Btn_confrim;
        private System.Windows.Forms.Label lbl_usershort;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_passshort;
        private System.Windows.Forms.Label lbl_passmatch;
    }
}