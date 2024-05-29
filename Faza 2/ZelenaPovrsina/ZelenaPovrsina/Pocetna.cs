﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZelenaPovrsina
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnRadnici_Click(object sender, EventArgs e)
        {
            RadniciForm forma = new RadniciForm();
            forma.ShowDialog();
        }

        private void btnGrupeRadnika_Click(object sender, EventArgs e)
        {
            GrupeRadnikaForm forma = new GrupeRadnikaForm();
            forma.ShowDialog();
        }
    }
}
