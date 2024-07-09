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
    public partial class IzmeniKlupuForm : Form
    {
        KlupaPregled? klupa;
        KlupeForm? forma;
        public IzmeniKlupuForm()
        {
            InitializeComponent();
        }
        public IzmeniKlupuForm(KlupaPregled k, KlupeForm forma)
        {
            klupa = k;
            InitializeComponent();
            this.forma = forma;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if(klupa!=null)
            {
                klupa.Materijal = txtMat.Text;
                await DTOManager.azurirajKlupu(klupa);
                MessageBox.Show("Uspesno ste azurirali klupu");
                forma.popuniPodacimaKlupe();
            }
            else
            {
                MessageBox.Show("Niste uspeli da azurirate klupu");
            }
            Close();
        }
    }
}
