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
    public partial class DodajSvetiljkuForm : Form
    {
        public DodajSvetiljkuForm()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            SvetiljkaBasic s = new SvetiljkaBasic();
            s.BrSijalica = Int32.Parse(txtBrSij.Text);
            int park = Int32.Parse(txtPark.Text);
            s.Tip = "svetiljka";

            await DTOManager.dodajSvetiljku(s, park);
            MessageBox.Show("Uspesno ste dodali svetiljku");
            this.Close();

        }
    }
}
