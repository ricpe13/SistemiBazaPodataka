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
    public partial class DodajParkForma : Form
    {
        public DodajParkForma()
        {
            InitializeComponent();
        }

        private void cmdDodajPark_Click(object sender, EventArgs e)
        {
            ParkBasic p = new ParkBasic();
            p.TipZ = "park";
            p.NazivGradskeOpstine = txtOpst.Text;
            p.ZonaUgrozenosti=txtZona.Text;
            p.NazivP=txtNaziv.Text;
            p.PovrsinaP=Int32.Parse(txtPov.Text);

            DTOManager.dodajPark(p);

            MessageBox.Show("Uspesno ste dodali Park!");
            this.Close();
        }
    }
}
