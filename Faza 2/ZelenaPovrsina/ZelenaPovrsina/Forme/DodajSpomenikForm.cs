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
    public partial class DodajSpomenikForm : Form
    {
        public DodajSpomenikForm()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            SpomenikBasic s = new SpomenikBasic();
            s.Tip = "spomenik";
            s.NazivS = txtNaziv.Text;
            int park = Int32.Parse(txtPark.Text);
            int zastita = Int32.Parse(txtZastita.Text);

            await DTOManager.dodajSpomenik(s, park, zastita);
            MessageBox.Show("Uspesno ste dodali spomenik");
            this.Close();
        }
    }
}
