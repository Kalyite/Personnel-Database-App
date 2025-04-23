namespace vtUygulama1
{
    partial class KayitSilForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKayitNo = new System.Windows.Forms.TextBox();
            this.txtTcNoS = new System.Windows.Forms.TextBox();
            this.txtSAd = new System.Windows.Forms.TextBox();
            this.txtSoyadS = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "National ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Surname";
            // 
            // txtKayitNo
            // 
            this.txtKayitNo.Enabled = false;
            this.txtKayitNo.Location = new System.Drawing.Point(125, 19);
            this.txtKayitNo.Name = "txtKayitNo";
            this.txtKayitNo.Size = new System.Drawing.Size(74, 22);
            this.txtKayitNo.TabIndex = 1;
            // 
            // txtTcNoS
            // 
            this.txtTcNoS.Enabled = false;
            this.txtTcNoS.Location = new System.Drawing.Point(125, 63);
            this.txtTcNoS.Name = "txtTcNoS";
            this.txtTcNoS.Size = new System.Drawing.Size(120, 22);
            this.txtTcNoS.TabIndex = 1;
            // 
            // txtSAd
            // 
            this.txtSAd.Enabled = false;
            this.txtSAd.Location = new System.Drawing.Point(125, 107);
            this.txtSAd.Name = "txtSAd";
            this.txtSAd.Size = new System.Drawing.Size(100, 22);
            this.txtSAd.TabIndex = 1;
            // 
            // txtSoyadS
            // 
            this.txtSoyadS.Enabled = false;
            this.txtSoyadS.Location = new System.Drawing.Point(125, 151);
            this.txtSoyadS.Name = "txtSoyadS";
            this.txtSoyadS.Size = new System.Drawing.Size(100, 22);
            this.txtSoyadS.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtSoyadS);
            this.groupBox1.Controls.Add(this.txtSAd);
            this.groupBox1.Controls.Add(this.txtTcNoS);
            this.groupBox1.Controls.Add(this.txtKayitNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(50, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KayitSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "KayitSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KayitSilForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtKayitNo;
        public System.Windows.Forms.TextBox txtTcNoS;
        public System.Windows.Forms.TextBox txtSAd;
        public System.Windows.Forms.TextBox txtSoyadS;
    }
}