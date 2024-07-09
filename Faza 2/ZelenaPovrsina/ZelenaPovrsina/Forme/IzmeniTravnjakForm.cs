using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Forme
{
    public partial class IzmeniTravnjakForm : Form
    {
        TravnjakPregled? travnjak;
        TravnjaciForm forma;
        public IzmeniTravnjakForm()
        {
            InitializeComponent();
        }
        public IzmeniTravnjakForm(TravnjakPregled t, TravnjaciForm forma)
        {
            travnjak = t;
            InitializeComponent();
            this.forma = forma;
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(travnjak!=null)
            {
                travnjak.NazivGradskeOpstine = txtOpstina.Text;
                travnjak.AdresaZgrade = txtAdresa.Text;
                travnjak.PovrsinaT = Int32.Parse(txtPT.Text);
                travnjak.ZonaUgrozenosti = txtZona.Text;
                await DTOManager.azurirajTravnjak(travnjak);
                MessageBox.Show("Uspesno ste azurirali travnjak");
                forma.popuniPodacimaTravnjaci();
            }
            else
            {

            }
        }
    }
}
