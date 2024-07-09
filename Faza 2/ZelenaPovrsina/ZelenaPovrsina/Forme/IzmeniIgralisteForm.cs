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
    public partial class IzmeniIgralisteForm : Form
    {
        DecijeIgralistePregled? igraliste;
        DecijaIgralistaForm? forma;
        public IzmeniIgralisteForm()
        {
            InitializeComponent();
        }
        public IzmeniIgralisteForm(DecijeIgralistePregled i, DecijaIgralistaForm forma)
        {
            igraliste = i;
            InitializeComponent();
            this.forma = forma;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(igraliste!=null)
            {
                igraliste.BrIgracaka = Int32.Parse(txtBr.Text);

                await DTOManager.azurirajDecijeIgraliste(igraliste);
                MessageBox.Show("Uspesno ste izmenili igraliste");
                forma.popuniPodacimaDecijaIgralista();
            }
            else
            {
                MessageBox.Show("Niste uspeli da izmenite decije igraliste");
            }
            Close();
        }
    }
}
