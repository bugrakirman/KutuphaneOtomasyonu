﻿namespace KutuphaneOtomasyonu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapKayıtToolStripMenuItem,
            this.yazarKayıtToolStripMenuItem,
            this.uyeKayıtToolStripMenuItem,
            this.kitapKiralamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapKayıtToolStripMenuItem
            // 
            this.kitapKayıtToolStripMenuItem.Name = "kitapKayıtToolStripMenuItem";
            this.kitapKayıtToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.kitapKayıtToolStripMenuItem.Text = "Kitap Kayıt";
            this.kitapKayıtToolStripMenuItem.Click += new System.EventHandler(this.kitapKayıtToolStripMenuItem_Click);
            // 
            // yazarKayıtToolStripMenuItem
            // 
            this.yazarKayıtToolStripMenuItem.Name = "yazarKayıtToolStripMenuItem";
            this.yazarKayıtToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.yazarKayıtToolStripMenuItem.Text = "Yazar Kayıt";
            this.yazarKayıtToolStripMenuItem.Click += new System.EventHandler(this.yazarKayıtToolStripMenuItem_Click);
            // 
            // uyeKayıtToolStripMenuItem
            // 
            this.uyeKayıtToolStripMenuItem.Name = "uyeKayıtToolStripMenuItem";
            this.uyeKayıtToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.uyeKayıtToolStripMenuItem.Text = "Uye Kayıt";
            this.uyeKayıtToolStripMenuItem.Click += new System.EventHandler(this.uyeKayıtToolStripMenuItem_Click);
            // 
            // kitapKiralamaToolStripMenuItem
            // 
            this.kitapKiralamaToolStripMenuItem.Name = "kitapKiralamaToolStripMenuItem";
            this.kitapKiralamaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.kitapKiralamaToolStripMenuItem.Text = "Kitap Kiralama";
            this.kitapKiralamaToolStripMenuItem.Click += new System.EventHandler(this.kitapKiralamaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKiralamaToolStripMenuItem;
    }
}

