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
    public partial class DodajFontanuForm : Form
    {
        public DodajFontanuForm()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            FontanaBasic f = new FontanaBasic();
            f.BrPrskalica = Int32.Parse(txtBrPrs.Text);
            f.PovrsinaF = Int32.Parse(txtPov.Text);
            int park = Int32.Parse(txtPark.Text);
            f.Tip = "fontana";
            await DTOManager.dodajFontanu(f, park);
            MessageBox.Show("Uspesno ste dodali park");
            this.Close();
        }
    }
}
