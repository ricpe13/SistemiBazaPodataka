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
    public partial class IzmeniGrupuForm : Form
    {
        GrupaRadnikaPregled? grupa;
        GrupeRadnikaForm? forma;
        public IzmeniGrupuForm()
        {
            InitializeComponent();
        }
        public IzmeniGrupuForm(GrupaRadnikaPregled g, GrupeRadnikaForm forma)
        {
            grupa = g;
            InitializeComponent();
            this.forma = forma;
        }
        private async void cmdDodajGrupuRadnika_Click(object sender, EventArgs e)
        {
            if(grupa!=null)
            {
                grupa.NazivG = txtNaziv.Text;

                await DTOManager.azurirajGrupuRadnika(grupa);

                MessageBox.Show("Uspesno ste azurirali grupu radnika");
                forma.popuniPodacimaGrupeRadnika();
            }
            else
            {
                MessageBox.Show("Niste uspeli da azurirate grupu radnika");
            }
            Close();
        }
    }
}
