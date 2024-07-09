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
    public partial class DodajKlupuForma : Form
    {
        public DodajKlupuForma()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            KlupaBasic k = new KlupaBasic();
            k.Tip = "klupa";
            k.Materijal = txtMat.Text;
            int val = Int32.Parse(txtPark.Text);

            await DTOManager.dodajKlupu(k, val);
            MessageBox.Show("Uspesno ste dodali klupu!");
            this.Close();
        }
    }
}
