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
    public partial class IzmeniParkForm : Form
    {
        ParkBasic? park;
        ParkoviForm? forma;
        public IzmeniParkForm()
        {
            InitializeComponent();
        }

        public IzmeniParkForm(ParkBasic? p, ParkoviForm? forma)
        {
            park = p;
            InitializeComponent();
            this.forma = forma;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(park!=null)
            {
                park.NazivP = txtNaziv.Text;
                park.ZonaUgrozenosti = txtZona.Text;
                park.NazivGradskeOpstine = txtOpstina.Text;
                park.PovrsinaP = Int32.Parse(txtPovrsina.Text);

                await DTOManager.azurirajPark(park);
                MessageBox.Show("Uspesno ste izmenili park");
                forma.popuniPodacimaParkovi();
            }
            else
            {
                MessageBox.Show("Niste uspeli da izmenite park");
            }
            Close();
        }
    }
}
