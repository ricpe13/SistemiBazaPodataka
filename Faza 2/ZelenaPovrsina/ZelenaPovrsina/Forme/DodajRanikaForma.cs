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
    public partial class DodajRanikaForma : Form
    {
        ZelenaPovrsinaBasic zelenaPovrsina;
        public DodajRanikaForma()
        {
            InitializeComponent();
        }
        public DodajRanikaForma(ZelenaPovrsinaBasic z)
        {
            InitializeComponent();
            zelenaPovrsina = z;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RadnikBasic radnik = new RadnikBasic();
            radnik.Ime = textBoxIme.Text;
            radnik.Prezime= textBoxPrezime.Text;
            radnik.Jmbg = textBoxJMBG.Text;
            radnik.Adresa= textBoxAdresa.Text;
            radnik.BrRadneKnjizice = Int32.Parse(textBoxBrRad.Text);
            radnik.ImeRoditelja = textBoxRod.Text;
            radnik.DatumRodj = datumRodjenja.Value;
            radnik.ZaHigijenu=Int32.Parse(textBoxHig.Text);
            radnik.ZaZelenilo = Int32.Parse(textBoxZel.Text);
            radnik.ZaObjekat = Int32.Parse(textBoxObj.Text);
            radnik.ZelenaPovrsina = Int32.Parse(textBoxZP.Text);
            //radnik.GrupaRadnika = null;
            DTOManager.dodajRadnika(radnik);
            MessageBox.Show("Uspesno ste dodali novog radnika");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
