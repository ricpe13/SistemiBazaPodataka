using System;
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

        private void btnParkovi_Click(object sender, EventArgs e)
        {
            ParkoviForm forma = new ParkoviForm();
            forma.ShowDialog();
        }

        private void btnTravnjaci_Click(object sender, EventArgs e)
        {
            TravnjaciForm forma = new TravnjaciForm();
            forma.ShowDialog();
        }

        private void btnDrvoredi_Click(object sender, EventArgs e)
        {
            DrvorediForm forma = new DrvorediForm();
            forma.ShowDialog();
        }

        private void btnObjekti_Click(object sender, EventArgs e)
        {
            ObjektiForm forma = new ObjektiForm();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZastiteForm forma = new ZastiteForm();
            forma.ShowDialog();
        }
    }
}
