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
    public partial class DodajSkulpturuForm : Form
    {
        public DodajSkulpturuForm()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            SkulpturaBasic s = new SkulpturaBasic();
            s.Autor = txtAutor.Text;
            s.Tip = "skulptura";
            int park = Int32.Parse(txtPark.Text);
            int zastita = Int32.Parse(txtZastita.Text);

            await DTOManager.dodajSkulpturu(s, park, zastita);
            MessageBox.Show("Uspesno ste dodali skulpturu");

            this.Close();
        }
    }
}
