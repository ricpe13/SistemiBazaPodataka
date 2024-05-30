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
    public partial class DodajDrvoredForma : Form
    {
        public DodajDrvoredForma()
        {
            InitializeComponent();
        }

        private void btnDodajDrvor_Click(object sender, EventArgs e)
        {
            DrvoredBasic d = new DrvoredBasic();
            d.TipZ = "drvored";
            d.NazivGradskeOpstine = txtOpstinaDrvored.Text;
            d.ZonaUgrozenosti = txtZonaDrvored.Text;
            d.Ulica = txtUlicaDrvored.Text;
            d.Duzina = Int32.Parse(txtDuzinaDrvored.Text);
            d.VrstaDrveta = txtVrstaDrvored.Text;
            d.BrojStabala = Int32.Parse(txtBrojDrvored.Text);

            DTOManager.dodajDrvored(d);

            MessageBox.Show("Uspesno ste dodali Park!");
            this.Close();
        }
    }
}
