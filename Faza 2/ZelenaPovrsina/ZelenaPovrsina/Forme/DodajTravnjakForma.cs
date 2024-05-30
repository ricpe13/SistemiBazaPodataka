using System;
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
    public partial class DodajTravnjakForma : Form
    {
        public DodajTravnjakForma()
        {
            InitializeComponent();
        }

        private void btnDodajT_Click(object sender, EventArgs e)
        {
            TravnjakBasic t = new TravnjakBasic();
            t.TipZ = "travnjak";
            t.NazivGradskeOpstine = txtOpstina.Text;
            t.ZonaUgrozenosti = txtZona.Text;
            t.AdresaZgrade = txtAdresa.Text;
            t.PovrsinaT = Int32.Parse(txtPT.Text);

            DTOManager.dodajTravnjak(t);

            MessageBox.Show("Uspesno ste dodali travnjak!");
            this.Close();
        }
    }
}
