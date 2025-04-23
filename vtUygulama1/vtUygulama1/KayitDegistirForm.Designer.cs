namespace vtUygulama1
{
    partial class KayitDegistirForm
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
            this.lblHata = new System.Windows.Forms.Label();
            this.dTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbDyeri = new System.Windows.Forms.ComboBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltrh = new System.Windows.Forms.Label();
            this.radKadin = new System.Windows.Forms.RadioButton();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radErkek = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KayıtDno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKayitD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(393, 234);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(20, 25);
            this.lblHata.TabIndex = 4;
            this.lblHata.Text = "*";
            this.lblHata.Visible = false;
            // 
            // dTarih
            // 
            this.dTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTarih.Location = new System.Drawing.Point(221, 391);
            this.dTarih.Name = "dTarih";
            this.dTarih.Size = new System.Drawing.Size(154, 30);
            this.dTarih.TabIndex = 21;
            // 
            // cmbDyeri
            // 
            this.cmbDyeri.FormattingEnabled = true;
            this.cmbDyeri.Items.AddRange(new object[] {
            "Kastamonu",
            "Ankara",
            "Sivas",
            "Manisa",
            "İstanbul",
            "İzmir",
            "Eskişehir",
            "Antalya",
            "Trabzon"});
            this.cmbDyeri.Location = new System.Drawing.Point(221, 339);
            this.cmbDyeri.Name = "cmbDyeri";
            this.cmbDyeri.Size = new System.Drawing.Size(154, 33);
            this.cmbDyeri.TabIndex = 19;
            this.cmbDyeri.Text = "Şehir Seçiniz";
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Arşiv",
            "Bilgi İşlem",
            "Programcılık",
            "Mühendislik",
            "Edebiyat"});
            this.cmbBirim.Location = new System.Drawing.Point(221, 285);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(154, 33);
            this.cmbBirim.TabIndex = 20;
            this.cmbBirim.Text = "Birim Seçiniz";
            // 
            // txtTel
            // 
            this.txtTel.BeepOnError = true;
            this.txtTel.Location = new System.Drawing.Point(221, 447);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(154, 30);
            this.txtTel.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(36, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(36, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Place of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(36, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(36, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departmant";
            // 
            // lbltrh
            // 
            this.lbltrh.AutoSize = true;
            this.lbltrh.ForeColor = System.Drawing.Color.Red;
            this.lbltrh.Location = new System.Drawing.Point(381, 394);
            this.lbltrh.Name = "lbltrh";
            this.lbltrh.Size = new System.Drawing.Size(20, 25);
            this.lbltrh.TabIndex = 4;
            this.lbltrh.Text = "*";
            this.lbltrh.Visible = false;
            // 
            // radKadin
            // 
            this.radKadin.AutoSize = true;
            this.radKadin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radKadin.Location = new System.Drawing.Point(303, 230);
            this.radKadin.Name = "radKadin";
            this.radKadin.Size = new System.Drawing.Size(98, 29);
            this.radKadin.TabIndex = 3;
            this.radKadin.TabStop = true;
            this.radKadin.Text = "Female";
            this.radKadin.UseVisualStyleBackColor = false;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(221, 177);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(130, 30);
            this.txtSoyad.TabIndex = 17;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(221, 123);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(130, 30);
            this.txtAd.TabIndex = 18;
            // 
            // txtTcNo
            // 
            this.txtTcNo.BeepOnError = true;
            this.txtTcNo.Location = new System.Drawing.Point(221, 69);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(130, 30);
            this.txtTcNo.TabIndex = 16;
            this.txtTcNo.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(36, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(36, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(36, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "National ID Number";
            // 
            // radErkek
            // 
            this.radErkek.AutoSize = true;
            this.radErkek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radErkek.Location = new System.Drawing.Point(214, 230);
            this.radErkek.Name = "radErkek";
            this.radErkek.Size = new System.Drawing.Size(76, 29);
            this.radErkek.TabIndex = 3;
            this.radErkek.TabStop = true;
            this.radErkek.Text = "Male";
            this.radErkek.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.KayıtDno);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dTarih);
            this.panel1.Controls.Add(this.lbltrh);
            this.panel1.Controls.Add(this.cmbDyeri);
            this.panel1.Controls.Add(this.lblHata);
            this.panel1.Controls.Add(this.cmbBirim);
            this.panel1.Controls.Add(this.radKadin);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.radErkek);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtTcNo);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 495);
            this.panel1.TabIndex = 22;
            // 
            // KayıtDno
            // 
            this.KayıtDno.Enabled = false;
            this.KayıtDno.Location = new System.Drawing.Point(221, 23);
            this.KayıtDno.Name = "KayıtDno";
            this.KayıtDno.Size = new System.Drawing.Size(100, 30);
            this.KayıtDno.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Record No";
            // 
            // btnKayitD
            // 
            this.btnKayitD.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnKayitD.Location = new System.Drawing.Point(6, 513);
            this.btnKayitD.Name = "btnKayitD";
            this.btnKayitD.Size = new System.Drawing.Size(422, 67);
            this.btnKayitD.TabIndex = 23;
            this.btnKayitD.Text = "Update Record";
            this.btnKayitD.UseVisualStyleBackColor = false;
            this.btnKayitD.Click += new System.EventHandler(this.btnKayitD_Click);
            // 
            // KayitDegistirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 592);
            this.Controls.Add(this.btnKayitD);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KayitDegistirForm";
            this.Text = "KayitDegistirForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltrh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox KayıtDno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKayitD;
        public System.Windows.Forms.DateTimePicker dTarih;
        public System.Windows.Forms.ComboBox cmbDyeri;
        public System.Windows.Forms.ComboBox cmbBirim;
        public System.Windows.Forms.MaskedTextBox txtTel;
        public System.Windows.Forms.RadioButton radKadin;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.MaskedTextBox txtTcNo;
        public System.Windows.Forms.RadioButton radErkek;
    }
}