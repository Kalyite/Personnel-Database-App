namespace vtUygulama1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBirim = new System.Windows.Forms.CheckBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.txtAraSoyad = new System.Windows.Forms.TextBox();
            this.txtAraAd = new System.Windows.Forms.TextBox();
            this.chkAd = new System.Windows.Forms.CheckBox();
            this.chkSoyad = new System.Windows.Forms.CheckBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(908, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personnel List";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEkle,
            this.toolStripSeparator1,
            this.btnSil,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1255, 48);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 45);
            this.btnEkle.Text = "Insert Record";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 45);
            this.btnSil.Text = "Delete Record";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(117, 45);
            this.toolStripButton1.Text = "Update Record";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.chkBirim);
            this.groupBox1.Controls.Add(this.cmbBirim);
            this.groupBox1.Controls.Add(this.txtAraSoyad);
            this.groupBox1.Controls.Add(this.txtAraAd);
            this.groupBox1.Controls.Add(this.chkAd);
            this.groupBox1.Controls.Add(this.chkSoyad);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Location = new System.Drawing.Point(968, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exact Search";
            // 
            // chkBirim
            // 
            this.chkBirim.AutoSize = true;
            this.chkBirim.Location = new System.Drawing.Point(6, 131);
            this.chkBirim.Name = "chkBirim";
            this.chkBirim.Size = new System.Drawing.Size(135, 29);
            this.chkBirim.TabIndex = 7;
            this.chkBirim.Text = "Department";
            this.chkBirim.UseVisualStyleBackColor = true;
            this.chkBirim.CheckedChanged += new System.EventHandler(this.chkBirim_CheckedChanged);
            // 
            // cmbBirim
            // 
            this.cmbBirim.Enabled = false;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Arşiv",
            "Bilgi İşlem",
            "Programcılık",
            "Mühendislik",
            "Edebiyat"});
            this.cmbBirim.Location = new System.Drawing.Point(144, 129);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(125, 33);
            this.cmbBirim.TabIndex = 6;
            this.cmbBirim.Text = "Birim Seçiniz";
            // 
            // txtAraSoyad
            // 
            this.txtAraSoyad.Location = new System.Drawing.Point(120, 93);
            this.txtAraSoyad.Name = "txtAraSoyad";
            this.txtAraSoyad.Size = new System.Drawing.Size(149, 30);
            this.txtAraSoyad.TabIndex = 2;
            this.txtAraSoyad.TextChanged += new System.EventHandler(this.txtAraSoyad_TextChanged);
            // 
            // txtAraAd
            // 
            this.txtAraAd.Location = new System.Drawing.Point(120, 57);
            this.txtAraAd.Name = "txtAraAd";
            this.txtAraAd.Size = new System.Drawing.Size(149, 30);
            this.txtAraAd.TabIndex = 2;
            this.txtAraAd.TextChanged += new System.EventHandler(this.txtAraAd_TextChanged);
            // 
            // chkAd
            // 
            this.chkAd.AutoSize = true;
            this.chkAd.Location = new System.Drawing.Point(6, 60);
            this.chkAd.Name = "chkAd";
            this.chkAd.Size = new System.Drawing.Size(86, 29);
            this.chkAd.TabIndex = 1;
            this.chkAd.Text = "Name";
            this.chkAd.UseVisualStyleBackColor = true;
            this.chkAd.CheckedChanged += new System.EventHandler(this.chkAd_CheckedChanged);
            // 
            // chkSoyad
            // 
            this.chkSoyad.AutoSize = true;
            this.chkSoyad.Location = new System.Drawing.Point(6, 95);
            this.chkSoyad.Name = "chkSoyad";
            this.chkSoyad.Size = new System.Drawing.Size(114, 29);
            this.chkSoyad.TabIndex = 1;
            this.chkSoyad.Text = "Surname";
            this.chkSoyad.UseVisualStyleBackColor = true;
            this.chkSoyad.CheckedChanged += new System.EventHandler(this.chkSoyad_CheckedChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.OldLace;
            this.btnAra.Location = new System.Drawing.Point(50, 184);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(161, 52);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Search";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEkle;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAraSoyad;
        private System.Windows.Forms.TextBox txtAraAd;
        private System.Windows.Forms.CheckBox chkAd;
        private System.Windows.Forms.CheckBox chkSoyad;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.CheckBox chkBirim;
    }
}

