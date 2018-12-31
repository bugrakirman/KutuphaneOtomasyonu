namespace KutuphaneOtomasyonu
{
    partial class frmKitapKiralama
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
            this.cmbKiralaKitapAdi = new System.Windows.Forms.ComboBox();
            this.cmbKiralaUyeAdi = new System.Windows.Forms.ComboBox();
            this.dtpKirala = new System.Windows.Forms.DateTimePicker();
            this.btnKirala = new System.Windows.Forms.Button();
            this.btnİade = new System.Windows.Forms.Button();
            this.gbKirala = new System.Windows.Forms.GroupBox();
            this.btnKitapKirala = new System.Windows.Forms.Button();
            this.gbİade = new System.Windows.Forms.GroupBox();
            this.btnKitapİade = new System.Windows.Forms.Button();
            this.cmbİadeUyeAdi = new System.Windows.Forms.ComboBox();
            this.cmbİadeKitapAdi = new System.Windows.Forms.ComboBox();
            this.gbKirala.SuspendLayout();
            this.gbİade.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKiralaKitapAdi
            // 
            this.cmbKiralaKitapAdi.FormattingEnabled = true;
            this.cmbKiralaKitapAdi.Location = new System.Drawing.Point(6, 19);
            this.cmbKiralaKitapAdi.Name = "cmbKiralaKitapAdi";
            this.cmbKiralaKitapAdi.Size = new System.Drawing.Size(200, 21);
            this.cmbKiralaKitapAdi.TabIndex = 0;
            // 
            // cmbKiralaUyeAdi
            // 
            this.cmbKiralaUyeAdi.FormattingEnabled = true;
            this.cmbKiralaUyeAdi.Location = new System.Drawing.Point(6, 56);
            this.cmbKiralaUyeAdi.Name = "cmbKiralaUyeAdi";
            this.cmbKiralaUyeAdi.Size = new System.Drawing.Size(200, 21);
            this.cmbKiralaUyeAdi.TabIndex = 1;
            // 
            // dtpKirala
            // 
            this.dtpKirala.Location = new System.Drawing.Point(6, 95);
            this.dtpKirala.Name = "dtpKirala";
            this.dtpKirala.Size = new System.Drawing.Size(200, 20);
            this.dtpKirala.TabIndex = 2;
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(71, 12);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 23);
            this.btnKirala.TabIndex = 3;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // btnİade
            // 
            this.btnİade.Location = new System.Drawing.Point(340, 12);
            this.btnİade.Name = "btnİade";
            this.btnİade.Size = new System.Drawing.Size(75, 23);
            this.btnİade.TabIndex = 4;
            this.btnİade.Text = "İade";
            this.btnİade.UseVisualStyleBackColor = true;
            this.btnİade.Click += new System.EventHandler(this.btnİade_Click);
            // 
            // gbKirala
            // 
            this.gbKirala.Controls.Add(this.btnKitapKirala);
            this.gbKirala.Controls.Add(this.cmbKiralaKitapAdi);
            this.gbKirala.Controls.Add(this.cmbKiralaUyeAdi);
            this.gbKirala.Controls.Add(this.dtpKirala);
            this.gbKirala.Location = new System.Drawing.Point(13, 52);
            this.gbKirala.Name = "gbKirala";
            this.gbKirala.Size = new System.Drawing.Size(218, 188);
            this.gbKirala.TabIndex = 5;
            this.gbKirala.TabStop = false;
            this.gbKirala.Text = "Kitap Kirala";
            // 
            // btnKitapKirala
            // 
            this.btnKitapKirala.Location = new System.Drawing.Point(131, 154);
            this.btnKitapKirala.Name = "btnKitapKirala";
            this.btnKitapKirala.Size = new System.Drawing.Size(75, 23);
            this.btnKitapKirala.TabIndex = 7;
            this.btnKitapKirala.Text = "Kirala";
            this.btnKitapKirala.UseVisualStyleBackColor = true;
            this.btnKitapKirala.Click += new System.EventHandler(this.btnKitapKirala_Click);
            // 
            // gbİade
            // 
            this.gbİade.Controls.Add(this.btnKitapİade);
            this.gbİade.Controls.Add(this.cmbİadeUyeAdi);
            this.gbİade.Controls.Add(this.cmbİadeKitapAdi);
            this.gbİade.Location = new System.Drawing.Point(279, 52);
            this.gbİade.Name = "gbİade";
            this.gbİade.Size = new System.Drawing.Size(218, 188);
            this.gbİade.TabIndex = 6;
            this.gbİade.TabStop = false;
            this.gbİade.Text = "Kitap İade";
            // 
            // btnKitapİade
            // 
            this.btnKitapİade.Location = new System.Drawing.Point(131, 154);
            this.btnKitapİade.Name = "btnKitapİade";
            this.btnKitapİade.Size = new System.Drawing.Size(75, 23);
            this.btnKitapİade.TabIndex = 11;
            this.btnKitapİade.Text = "İade";
            this.btnKitapİade.UseVisualStyleBackColor = true;
            this.btnKitapİade.Click += new System.EventHandler(this.btnKitapİade_Click);
            // 
            // cmbİadeUyeAdi
            // 
            this.cmbİadeUyeAdi.FormattingEnabled = true;
            this.cmbİadeUyeAdi.Location = new System.Drawing.Point(6, 56);
            this.cmbİadeUyeAdi.Name = "cmbİadeUyeAdi";
            this.cmbİadeUyeAdi.Size = new System.Drawing.Size(200, 21);
            this.cmbİadeUyeAdi.TabIndex = 9;
            // 
            // cmbİadeKitapAdi
            // 
            this.cmbİadeKitapAdi.FormattingEnabled = true;
            this.cmbİadeKitapAdi.Location = new System.Drawing.Point(6, 19);
            this.cmbİadeKitapAdi.Name = "cmbİadeKitapAdi";
            this.cmbİadeKitapAdi.Size = new System.Drawing.Size(200, 21);
            this.cmbİadeKitapAdi.TabIndex = 8;
            // 
            // frmKitapKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 318);
            this.Controls.Add(this.gbİade);
            this.Controls.Add(this.gbKirala);
            this.Controls.Add(this.btnİade);
            this.Controls.Add(this.btnKirala);
            this.Name = "frmKitapKiralama";
            this.Text = "FormKitapKiralama";
            this.Load += new System.EventHandler(this.frmKitapKiralama_Load);
            this.gbKirala.ResumeLayout(false);
            this.gbİade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKiralaKitapAdi;
        private System.Windows.Forms.ComboBox cmbKiralaUyeAdi;
        private System.Windows.Forms.DateTimePicker dtpKirala;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Button btnİade;
        private System.Windows.Forms.GroupBox gbKirala;
        private System.Windows.Forms.GroupBox gbİade;
        private System.Windows.Forms.Button btnKitapKirala;
        private System.Windows.Forms.Button btnKitapİade;
        private System.Windows.Forms.ComboBox cmbİadeUyeAdi;
        private System.Windows.Forms.ComboBox cmbİadeKitapAdi;
    }
}