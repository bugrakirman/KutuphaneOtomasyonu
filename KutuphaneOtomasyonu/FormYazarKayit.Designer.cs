namespace KutuphaneOtomasyonu
{
    partial class frmYazarKayit
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbYazarKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.btnYazarKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(279, 10);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(219, 20);
            this.txtAra.TabIndex = 21;
            // 
            // cmbYazarKategori
            // 
            this.cmbYazarKategori.FormattingEnabled = true;
            this.cmbYazarKategori.Location = new System.Drawing.Point(126, 110);
            this.cmbYazarKategori.Name = "cmbYazarKategori";
            this.cmbYazarKategori.Size = new System.Drawing.Size(125, 21);
            this.cmbYazarKategori.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kategori";
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.HorizontalScrollbar = true;
            this.lstYazarlar.Location = new System.Drawing.Point(279, 36);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(219, 173);
            this.lstYazarlar.TabIndex = 18;
            //this.lstYazarlar.SelectedIndexChanged += new System.EventHandler(this.lstYazarlar_SelectedIndexChanged);
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Location = new System.Drawing.Point(126, 73);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtYazarSoyad.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yazar Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yazar Adı";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(126, 36);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(125, 20);
            this.txtYazarAd.TabIndex = 14;
            // 
            // btnYazarKaydet
            // 
            this.btnYazarKaydet.Location = new System.Drawing.Point(126, 148);
            this.btnYazarKaydet.Name = "btnYazarKaydet";
            this.btnYazarKaydet.Size = new System.Drawing.Size(125, 23);
            this.btnYazarKaydet.TabIndex = 13;
            this.btnYazarKaydet.Text = "yazarı Kaydet";
            this.btnYazarKaydet.UseVisualStyleBackColor = true;
            this.btnYazarKaydet.Click += new System.EventHandler(this.btnYazarKaydet_Click);
            // 
            // frmYazarKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 335);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.cmbYazarKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstYazarlar);
            this.Controls.Add(this.txtYazarSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.btnYazarKaydet);
            this.Name = "frmYazarKayit";
            this.Text = "FormYazarKayit";
            this.Load += new System.EventHandler(this.frmYazarKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cmbYazarKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Button btnYazarKaydet;
    }
}