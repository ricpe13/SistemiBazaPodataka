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
            TravnjakBasic p = new TravnjakBasic();
            p.TipZ = "travnjak";
            p.NazivGradskeOpstine = txtOpstina.Text;
            p.ZonaUgrozenosti = txtZona.Text;
            p.AdresaZgrade = txtAdresa.Text;
            p.PovrsinaT = Int32.Parse(txtPT.Text);

            DTOManager.dodajTravnjak(p);

            MessageBox.Show("Uspesno ste dodali Park!");
            this.Close();
        }
    }
}
