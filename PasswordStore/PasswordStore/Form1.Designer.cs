namespace PasswordStore
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_wrong = new System.Windows.Forms.Label();
            this.btn_cngpass = new System.Windows.Forms.Button();
            this.btn_singin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.user_box = new System.Windows.Forms.TextBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPassword = new System.Windows.Forms.TabPage();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtbox_add = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPassword.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPassword);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(274, 255);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_wrong);
            this.tabPage1.Controls.Add(this.btn_cngpass);
            this.tabPage1.Controls.Add(this.btn_singin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pass_box);
            this.tabPage1.Controls.Add(this.user_box);
            this.tabPage1.Controls.Add(this.btn_log);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(266, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_wrong
            // 
            this.lbl_wrong.AutoSize = true;
            this.lbl_wrong.ForeColor = System.Drawing.Color.Red;
            this.lbl_wrong.Location = new System.Drawing.Point(56, 36);
            this.lbl_wrong.Name = "lbl_wrong";
            this.lbl_wrong.Size = new System.Drawing.Size(148, 13);
            this.lbl_wrong.TabIndex = 17;
            this.lbl_wrong.Text = "Wrong password or username";
            // 
            // btn_cngpass
            // 
            this.btn_cngpass.Location = new System.Drawing.Point(56, 162);
            this.btn_cngpass.Name = "btn_cngpass";
            this.btn_cngpass.Size = new System.Drawing.Size(156, 23);
            this.btn_cngpass.TabIndex = 16;
            this.btn_cngpass.Text = "Change pass and user";
            this.btn_cngpass.UseVisualStyleBackColor = true;
            this.btn_cngpass.Click += new System.EventHandler(this.Btn_cngpass_Click);
            // 
            // btn_singin
            // 
            this.btn_singin.Location = new System.Drawing.Point(137, 133);
            this.btn_singin.Name = "btn_singin";
            this.btn_singin.Size = new System.Drawing.Size(75, 23);
            this.btn_singin.TabIndex = 15;
            this.btn_singin.Text = "Sign in";
            this.btn_singin.UseVisualStyleBackColor = true;
            this.btn_singin.Click += new System.EventHandler(this.Btn_singin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username:";
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(56, 107);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(156, 20);
            this.pass_box.TabIndex = 12;
            // 
            // user_box
            // 
            this.user_box.Location = new System.Drawing.Point(56, 68);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(156, 20);
            this.user_box.TabIndex = 11;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(56, 133);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 10;
            this.btn_log.Text = "Login";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.Btn_log_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, -15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // tabPassword
            // 
            this.tabPassword.Controls.Add(this.btn_remove);
            this.tabPassword.Controls.Add(this.btn_copy);
            this.tabPassword.Controls.Add(this.btn_add);
            this.tabPassword.Controls.Add(this.txtbox_add);
            this.tabPassword.Controls.Add(this.label3);
            this.tabPassword.Controls.Add(this.listBox1);
            this.tabPassword.Location = new System.Drawing.Point(4, 22);
            this.tabPassword.Name = "tabPassword";
            this.tabPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPassword.Size = new System.Drawing.Size(266, 229);
            this.tabPassword.TabIndex = 1;
            this.tabPassword.Text = "Passwords";
            this.tabPassword.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(94, 26);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(185, 26);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 6;
            this.btn_copy.Text = "Copy To Clip";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.Btn_copy_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(4, 26);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // txtbox_add
            // 
            this.txtbox_add.Location = new System.Drawing.Point(4, 6);
            this.txtbox_add.Name = "txtbox_add";
            this.txtbox_add.Size = new System.Drawing.Size(256, 20);
            this.txtbox_add.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tu esi neprisijunges. \r\nPrisijung jeigu nori matyti slaptazodzius";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 173);
            this.listBox1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 270);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPassword.ResumeLayout(false);
            this.tabPassword.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_singin;
        private System.Windows.Forms.Button btn_cngpass;
        private System.Windows.Forms.TabPage tabPassword;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbox_add;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_wrong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

