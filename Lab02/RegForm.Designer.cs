namespace Lab02
{
    partial class RegForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.labe1 = new System.Windows.Forms.Label();
            this.buttonreg = new System.Windows.Forms.Button();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reglabel = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginF = new System.Windows.Forms.TextBox();
            this.surename = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labe1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 100);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(560, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // labe1
            // 
            this.labe1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labe1.Location = new System.Drawing.Point(212, 38);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(184, 37);
            this.labe1.TabIndex = 0;
            this.labe1.Text = "Регистрация";
            this.labe1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labe1.UseCompatibleTextRendering = true;
            this.labe1.Click += new System.EventHandler(this.labe1_Click);
            // 
            // buttonreg
            // 
            this.buttonreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonreg.FlatAppearance.BorderSize = 0;
            this.buttonreg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(48)))), ((int)(((byte)(8)))));
            this.buttonreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(7)))));
            this.buttonreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonreg.ForeColor = System.Drawing.Color.White;
            this.buttonreg.Location = new System.Drawing.Point(174, 307);
            this.buttonreg.Name = "buttonreg";
            this.buttonreg.Size = new System.Drawing.Size(262, 53);
            this.buttonreg.TabIndex = 4;
            this.buttonreg.Text = "Зарегистрироваться";
            this.buttonreg.UseVisualStyleBackColor = false;
            this.buttonreg.Click += new System.EventHandler(this.buttonreg_Click);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.LoginField.Location = new System.Drawing.Point(94, 38);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(225, 49);
            this.LoginField.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(97)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.reglabel);
            this.panel2.Controls.Add(this.passwordField);
            this.panel2.Controls.Add(this.loginF);
            this.panel2.Controls.Add(this.surename);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.buttonreg);
            this.panel2.Controls.Add(this.LoginField);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 389);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // reglabel
            // 
            this.reglabel.AutoSize = true;
            this.reglabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reglabel.ForeColor = System.Drawing.Color.White;
            this.reglabel.Location = new System.Drawing.Point(241, 364);
            this.reglabel.Name = "reglabel";
            this.reglabel.Size = new System.Drawing.Size(116, 16);
            this.reglabel.TabIndex = 12;
            this.reglabel.Text = "Авторизоваться";
            this.reglabel.Click += new System.EventHandler(this.reglabel_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(347, 243);
            this.passwordField.Multiline = true;
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(225, 39);
            this.passwordField.TabIndex = 11;
            this.passwordField.Enter += new System.EventHandler(this.passwordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
            this.passwordField.MouseEnter += new System.EventHandler(this.passwordField_MouseEnter);
            this.passwordField.MouseLeave += new System.EventHandler(this.passwordField_MouseLeave);
            // 
            // loginF
            // 
            this.loginF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginF.Location = new System.Drawing.Point(47, 243);
            this.loginF.Multiline = true;
            this.loginF.Name = "loginF";
            this.loginF.Size = new System.Drawing.Size(225, 39);
            this.loginF.TabIndex = 10;
            this.loginF.TextChanged += new System.EventHandler(this.loginF_TextChanged);
            this.loginF.Enter += new System.EventHandler(this.loginF_Enter);
            this.loginF.Leave += new System.EventHandler(this.loginF_Leave);
            this.loginF.MouseEnter += new System.EventHandler(this.loginF_MouseEnter);
            this.loginF.MouseLeave += new System.EventHandler(this.loginF_MouseLeave);
            // 
            // surename
            // 
            this.surename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surename.Location = new System.Drawing.Point(347, 141);
            this.surename.Multiline = true;
            this.surename.Name = "surename";
            this.surename.Size = new System.Drawing.Size(225, 39);
            this.surename.TabIndex = 9;
            this.surename.Enter += new System.EventHandler(this.surename_Enter);
            this.surename.Leave += new System.EventHandler(this.surename_Leave);
            this.surename.MouseEnter += new System.EventHandler(this.surename_MouseEnter);
            this.surename.MouseLeave += new System.EventHandler(this.surename_MouseLeave);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(47, 141);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(225, 39);
            this.username.TabIndex = 8;
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Lab02.Properties.Resources.iconfinder_lock_safe_password_2992204__2_;
            this.pictureBox3.Location = new System.Drawing.Point(304, 243);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab02.Properties.Resources.iconfinder_users_10_984119;
            this.pictureBox1.Location = new System.Drawing.Point(3, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab02.Properties.Resources.iconfinder_users_10_984119;
            this.pictureBox2.Location = new System.Drawing.Point(24, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Button buttonreg;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginF;
        private System.Windows.Forms.TextBox surename;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label reglabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}