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
    public partial class DodajDecijeIgralisteForm : Form
    {
        public DodajDecijeIgralisteForm()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            DecijeIgralisteBasic d = new DecijeIgralisteBasic();
            d.Tip = "decije igraliste";
            d.Starost = Int32.Parse(txtStarost.Text);
            d.BrIgracaka = Int32.Parse(txtBr.Text);
            d.Pesak = Int32.Parse(txtPesak.Text);
            int park = Int32.Parse(txtPark.Text);

            await DTOManager.dodajDecijeIgraliste(d,park);
            MessageBox.Show("Uspesno ste dodali decije igraliste");
            this.Close();
        }
    }
}
