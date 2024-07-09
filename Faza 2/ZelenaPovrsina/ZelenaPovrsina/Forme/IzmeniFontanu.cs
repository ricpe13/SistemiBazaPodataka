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
    public partial class IzmeniFontanu : Form
    {
        FontanaPregled? fontana;
        FontaneForm? forma;
        public IzmeniFontanu()
        {
            InitializeComponent();
        }
        public IzmeniFontanu(FontanaPregled f, FontaneForm forma)
        {
            fontana = f;
            InitializeComponent();
            this.forma = forma;
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if(fontana!=null)
            {
                fontana.BrPrskalica = Int32.Parse(txtBrPrs.Text);
                fontana.PovrsinaF = Int32.Parse(txtPov.Text);
                await DTOManager.azurirajFontanu(fontana);
                MessageBox.Show("Uspesno ste izmenili fontanu");
                forma.popuniPodacimaFontane();
            }
            else
            {
                MessageBox.Show("Niste uspeli da izmenite fontanu");
            }
            Close();
        }
    }
}
