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
    public partial class IzmeniSpomenikForm : Form
    {
        SpomenikPregled? spomenik;
        SpomeniciForm? forma;
        public IzmeniSpomenikForm()
        {
            InitializeComponent();
        }
        public IzmeniSpomenikForm(SpomenikPregled s, SpomeniciForm forma)
        {
            spomenik = s;
            InitializeComponent();
            this.forma = forma;
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (spomenik != null)
            {
                spomenik.NazivS = txtNaziv.Text;
                await DTOManager.azurirajSpomenik(spomenik);
                MessageBox.Show("Uspesno ste azurirali spomenik");
                forma.popuniPodacimaSpomenike();
            }
            else
            {
                MessageBox.Show("Niste uspeli da azurirate spomenik");
            }
            Close();
        }
    }
}
