﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZelenaPovrsina.Forme
{
    public partial class TravnjaciForm : Form
    {
        public TravnjaciForm()
        {
            InitializeComponent();
        }

        private void btnDodajTravnjak_Click(object sender, EventArgs e)
        {
            DodajTravnjakForma forma = new DodajTravnjakForma();
            forma.ShowDialog();
        }
    }
}
