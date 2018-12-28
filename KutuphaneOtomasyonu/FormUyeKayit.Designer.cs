namespace KutuphaneOtomasyonu
{
    partial class frmUyeKayit
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
            this.lstUyeler = new System.Windows.Forms.ListBox();
            this.txtUyeSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUyeAd = new System.Windows.Forms.TextBox();
            this.btnUyeKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(281, 14);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(219, 20);
            this.txtAra.TabIndex = 30;
            // 
            // lstUyeler
            // 
            this.lstUyeler.FormattingEnabled = true;
            this.lstUyeler.HorizontalScrollbar = true;
            this.lstUyeler.Location = new System.Drawing.Point(281, 40);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(219, 173);
            this.lstUyeler.TabIndex = 27;
            // 
            // txtUyeSoyad
            // 
            this.txtUyeSoyad.Location = new System.Drawing.Point(128, 77);
            this.txtUyeSoyad.Name = "txtUyeSoyad";
            this.txtUyeSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtUyeSoyad.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Uye Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Uye Adı";
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.Location = new System.Drawing.Point(128, 40);
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(125, 20);
            this.txtUyeAd.TabIndex = 23;
            // 
            // btnUyeKaydet
            // 
            this.btnUyeKaydet.Location = new System.Drawing.Point(137, 190);
            this.btnUyeKaydet.Name = "btnUyeKaydet";
            this.btnUyeKaydet.Size = new System.Drawing.Size(125, 23);
            this.btnUyeKaydet.TabIndex = 22;
            this.btnUyeKaydet.Text = "Üyeyi Kaydet";
            this.btnUyeKaydet.UseVisualStyleBackColor = true;
            this.btnUyeKaydet.Click += new System.EventHandler(this.btnUyeKaydet_Click_1);
            // 
            // frmUyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUyeler);
            this.Controls.Add(this.txtUyeSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUyeAd);
            this.Controls.Add(this.btnUyeKaydet);
            this.Name = "frmUyeKayit";
            this.Text = "FormUyeKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUyeler;
        private System.Windows.Forms.TextBox txtUyeSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUyeAd;
        private System.Windows.Forms.Button btnUyeKaydet;
    }
}