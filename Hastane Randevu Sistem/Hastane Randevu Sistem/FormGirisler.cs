﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistem
{
    public partial class FormGirisler : Form
    {
        public FormGirisler()
        {
            InitializeComponent();
        }
        // Hasta Girişe tıkladığında hastanın kullanıcı girişine dair panel açılsın
        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            FormHastaGiris hastaGiris = new FormHastaGiris();
            hastaGiris.Show();
            this.Hide();
        }
        // Doktor girişe tıkladığında doktorun kullanıcı girişine dair panel açılsın
        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            FormDoktorGiris doktorGiris = new FormDoktorGiris();
            doktorGiris.Show();
            this.Hide();
        }
        // Sekreter girişe tıkladığında sekreterin kullanıcı girişine dair panel açılsın
        private void btnsekretergiris_Click(object sender, EventArgs e)
        {
            FormSekreterGiris sekreterGiris = new FormSekreterGiris();
            sekreterGiris.Show();
            this.Hide();
        }

        private void FormGirisler_Load(object sender, EventArgs e)
        {

        }
    }
}
