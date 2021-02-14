namespace Lab02
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.Exitbtnsearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateField = new System.Windows.Forms.DateTimePicker();
            this.MemoryField = new System.Windows.Forms.ComboBox();
            this.GraphAdapterField = new System.Windows.Forms.ComboBox();
            this.ProcField = new System.Windows.Forms.ComboBox();
            this.CompanyField = new System.Windows.Forms.ComboBox();
            this.TypeField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CPUCField = new System.Windows.Forms.ComboBox();
            this.searchformlabelone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Exitbtnsearch
            // 
            this.Exitbtnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbtnsearch.AutoSize = true;
            this.Exitbtnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitbtnsearch.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtnsearch.Location = new System.Drawing.Point(775, 0);
            this.Exitbtnsearch.Name = "Exitbtnsearch";
            this.Exitbtnsearch.Size = new System.Drawing.Size(21, 24);
            this.Exitbtnsearch.TabIndex = 24;
            this.Exitbtnsearch.Text = "x";
            this.Exitbtnsearch.Click += new System.EventHandler(this.Exitbtnsearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(7, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 120);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 120);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.CPUCField);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.DateField);
            this.panel2.Controls.Add(this.MemoryField);
            this.panel2.Controls.Add(this.GraphAdapterField);
            this.panel2.Controls.Add(this.ProcField);
            this.panel2.Controls.Add(this.CompanyField);
            this.panel2.Controls.Add(this.TypeField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(503, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 300);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DateField
            // 
            this.DateField.Location = new System.Drawing.Point(71, 198);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(200, 20);
            this.DateField.TabIndex = 33;
            this.DateField.ValueChanged += new System.EventHandler(this.DateField_ValueChanged);
            // 
            // MemoryField
            // 
            this.MemoryField.FormattingEnabled = true;
            this.MemoryField.Location = new System.Drawing.Point(71, 171);
            this.MemoryField.Name = "MemoryField";
            this.MemoryField.Size = new System.Drawing.Size(200, 21);
            this.MemoryField.TabIndex = 32;
            this.MemoryField.SelectedIndexChanged += new System.EventHandler(this.MemoryField_SelectedIndexChanged);
            // 
            // GraphAdapterField
            // 
            this.GraphAdapterField.FormattingEnabled = true;
            this.GraphAdapterField.Location = new System.Drawing.Point(71, 144);
            this.GraphAdapterField.Name = "GraphAdapterField";
            this.GraphAdapterField.Size = new System.Drawing.Size(200, 21);
            this.GraphAdapterField.TabIndex = 31;
            this.GraphAdapterField.SelectedIndexChanged += new System.EventHandler(this.GraphAdapterField_SelectedIndexChanged);
            // 
            // ProcField
            // 
            this.ProcField.FormattingEnabled = true;
            this.ProcField.Location = new System.Drawing.Point(71, 90);
            this.ProcField.Name = "ProcField";
            this.ProcField.Size = new System.Drawing.Size(200, 21);
            this.ProcField.TabIndex = 30;
            this.ProcField.SelectedIndexChanged += new System.EventHandler(this.ProcField_SelectedIndexChanged);
            // 
            // CompanyField
            // 
            this.CompanyField.FormattingEnabled = true;
            this.CompanyField.Location = new System.Drawing.Point(71, 63);
            this.CompanyField.Name = "CompanyField";
            this.CompanyField.Size = new System.Drawing.Size(200, 21);
            this.CompanyField.TabIndex = 29;
            this.CompanyField.SelectedIndexChanged += new System.EventHandler(this.CompanyField_SelectedIndexChanged);
            // 
            // TypeField
            // 
            this.TypeField.FormattingEnabled = true;
            this.TypeField.Location = new System.Drawing.Point(71, 36);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(200, 21);
            this.TypeField.TabIndex = 28;
            this.TypeField.SelectedIndexChanged += new System.EventHandler(this.TypeField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Результаты поиска";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CPUCField
            // 
            this.CPUCField.FormattingEnabled = true;
            this.CPUCField.Location = new System.Drawing.Point(71, 117);
            this.CPUCField.Name = "CPUCField";
            this.CPUCField.Size = new System.Drawing.Size(200, 21);
            this.CPUCField.TabIndex = 45;
            this.CPUCField.SelectedIndexChanged += new System.EventHandler(this.CPUCField_SelectedIndexChanged);
            // 
            // searchformlabelone
            // 
            this.searchformlabelone.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchformlabelone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchformlabelone.Location = new System.Drawing.Point(139, 47);
            this.searchformlabelone.Name = "searchformlabelone";
            this.searchformlabelone.Size = new System.Drawing.Size(266, 37);
            this.searchformlabelone.TabIndex = 23;
            this.searchformlabelone.Text = "Поиск";
            this.searchformlabelone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchformlabelone.UseCompatibleTextRendering = true;
            this.searchformlabelone.Click += new System.EventHandler(this.searchformlabelone_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Lab02.Properties.Resources.iconfinder_Cancel_728918;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(146, 234);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 48;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Turquoise;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn.Image")));
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(3, 234);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchbtn.Size = new System.Drawing.Size(135, 40);
            this.searchbtn.TabIndex = 47;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(39, 117);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 46;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(39, 90);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(39, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(39, 36);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 39;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(796, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exitbtnsearch);
            this.Controls.Add(this.searchformlabelone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Exitbtnsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox MemoryField;
        private System.Windows.Forms.ComboBox GraphAdapterField;
        private System.Windows.Forms.ComboBox ProcField;
        private System.Windows.Forms.ComboBox CompanyField;
        private System.Windows.Forms.ComboBox TypeField;
        private System.Windows.Forms.DateTimePicker DateField;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CPUCField;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label searchformlabelone;
        private System.Windows.Forms.Button button1;
    }
}