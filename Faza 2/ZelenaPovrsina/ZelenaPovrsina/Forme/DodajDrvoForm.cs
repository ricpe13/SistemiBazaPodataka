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
    public partial class DodajDrvoForm : Form
    {
        public DodajDrvoForm()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            DrvoBasic drvo = new DrvoBasic();
            drvo.Tip = "drvo";
            drvo.VisinaKrosnje = Int32.Parse(txtVisina.Text);
            drvo.Vrsta=txtVrsta.Text;
            drvo.DatumSadnje = dateTime.Value;
            drvo.PovrsinaK = Int32.Parse(txtPovrsina.Text);
            drvo.ObimDebla = Int32.Parse(txtObim.Text);
            int park = Int32.Parse(txtPark.Text);
            int zastita = Int32.Parse(txtZastita.Text);

            await DTOManager.dodajDrvo(drvo, park, zastita);
            MessageBox.Show("Uspesno ste dodali drvo");
            
            this.Close();
        }
    }
}
