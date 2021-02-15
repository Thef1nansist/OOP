namespace Lab02
{
    partial class PersonForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.TimeField = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picprinc = new System.Windows.Forms.PictureBox();
            this.personField = new System.Windows.Forms.Label();
            this.Version2020 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picprinc)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeField
            // 
            this.TimeField.AutoEllipsis = true;
            this.TimeField.AutoSize = true;
            this.TimeField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeField.Font = new System.Drawing.Font("Calisto MT", 36F);
            this.TimeField.ForeColor = System.Drawing.Color.White;
            this.TimeField.Location = new System.Drawing.Point(0, 295);
            this.TimeField.Name = "TimeField";
            this.TimeField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeField.Size = new System.Drawing.Size(114, 55);
            this.TimeField.TabIndex = 0;
            this.TimeField.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picprinc
            // 
            this.picprinc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picprinc.Image = ((System.Drawing.Image)(resources.GetObject("picprinc.Image")));
            this.picprinc.Location = new System.Drawing.Point(0, 0);
            this.picprinc.Name = "picprinc";
            this.picprinc.Size = new System.Drawing.Size(622, 295);
            this.picprinc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picprinc.TabIndex = 41;
            this.picprinc.TabStop = false;
            // 
            // personField
            // 
            this.personField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.personField.AutoEllipsis = true;
            this.personField.AutoSize = true;
            this.personField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personField.Font = new System.Drawing.Font("Calisto MT", 36F);
            this.personField.ForeColor = System.Drawing.Color.Maroon;
            this.personField.Image = global::Lab02.Properties.Resources.iconfinder_users_10_984119__1_;
            this.personField.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.personField.Location = new System.Drawing.Point(466, 298);
            this.personField.Name = "personField";
            this.personField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.personField.Size = new System.Drawing.Size(144, 55);
            this.personField.TabIndex = 1;
            this.personField.Text = "Autor";
            this.personField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Version2020
            // 
            this.Version2020.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Version2020.AutoSize = true;
            this.Version2020.Font = new System.Drawing.Font("Calisto MT", 10F);
            this.Version2020.ForeColor = System.Drawing.Color.White;
            this.Version2020.Location = new System.Drawing.Point(531, 0);
            this.Version2020.Name = "Version2020";
            this.Version2020.Size = new System.Drawing.Size(91, 16);
            this.Version2020.TabIndex = 42;
            this.Version2020.Text = "Version#2021";
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(622, 350);
            this.Controls.Add(this.Version2020);
            this.Controls.Add(this.picprinc);
            this.Controls.Add(this.personField);
            this.Controls.Add(this.TimeField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picprinc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeField;
        private System.Windows.Forms.Label personField;
        private System.Windows.Forms.PictureBox picprinc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Version2020;
    }
}