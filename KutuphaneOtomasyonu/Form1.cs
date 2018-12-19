﻿using Kutuphane.Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmKitapKayit frmKitapKayit;
        private void kitapKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKitapKayit == null || frmKitapKayit.IsDisposed)
            {
                frmKitapKayit = new frmKitapKayit
                {
                    Text = "Kitap Kayıt",
                    MdiParent = this
                };
                frmKitapKayit.Show();
            }
        }
        public static Context Context { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            Context = new MockData().Context;
        }
    }
}
