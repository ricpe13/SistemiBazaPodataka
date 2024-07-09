using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ZelenaPovrsina.Forme
{
    public partial class IzmeniRadnikaForma : Form
    {
        RadnikPregled? radnik;
        RadniciForm? forma;
        public IzmeniRadnikaForma()
        {
            InitializeComponent();
        }
        public IzmeniRadnikaForma(RadnikPregled r, RadniciForm? forma)
        {
            radnik = r;
            InitializeComponent();
            this.forma = forma;

        }
        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (radnik != null)
            {
                RadnikBasic r = new RadnikBasic();
                r.Ime = txtIme.Text;
                r.Prezime = txtPrezime.Text;
                r.Adresa = txtAdresa.Text;
                r.BrRadneKnjizice = Int32.Parse(txtBr.Text);
                await DTOManager.azurirajRadnika(r);
                MessageBox.Show("Uspesno ste izmenili radnika!");
                forma!.popuniPodacimaRadnici();

            }
            else
            {
                MessageBox.Show("Niste uspeli da izmenite radnika!");
            }
            Close();
        }
    }
}
