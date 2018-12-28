namespace KutuphaneOtomasyonu
{
    partial class frmKitapKayit
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
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKitapKategori = new System.Windows.Forms.ComboBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbKitapYazarlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(141, 49);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(125, 20);
            this.txtKitapAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı";
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.Location = new System.Drawing.Point(141, 198);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(125, 23);
            this.btnKitapKaydet.TabIndex = 2;
            this.btnKitapKaydet.Text = "Kitabı Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            this.btnKitapKaydet.Click += new System.EventHandler(this.btnKitapKaydet_Click);
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.HorizontalScrollbar = true;
            this.lstKitaplar.Location = new System.Drawing.Point(299, 49);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(219, 173);
            this.lstKitaplar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yazar Soyadı";
            // 
            // cmbKitapKategori
            // 
            this.cmbKitapKategori.FormattingEnabled = true;
            this.cmbKitapKategori.Location = new System.Drawing.Point(141, 123);
            this.cmbKitapKategori.Name = "cmbKitapKategori";
            this.cmbKitapKategori.Size = new System.Drawing.Size(125, 21);
            this.cmbKitapKategori.TabIndex = 9;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(299, 23);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(219, 20);
            this.txtAra.TabIndex = 10;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // cmbKitapYazarlar
            // 
            this.cmbKitapYazarlar.FormattingEnabled = true;
            this.cmbKitapYazarlar.Location = new System.Drawing.Point(141, 86);
            this.cmbKitapYazarlar.Name = "cmbKitapYazarlar";
            this.cmbKitapYazarlar.Size = new System.Drawing.Size(125, 21);
            this.cmbKitapYazarlar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yazar Soyadı";
            // 
            // frmKitapKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 328);
            this.Controls.Add(this.cmbKitapYazarlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.cmbKitapKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.btnKitapKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapAd);
            this.Name = "frmKitapKayit";
            this.Text = "FormKitapKayit";
            this.Load += new System.EventHandler(this.frmKitapKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKitapKategori;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cmbKitapYazarlar;
        private System.Windows.Forms.Label label2;
    }
}