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

    public partial class DodajGrupuForma : Form
    {
        ParkBasic park = new ParkBasic();
        public DodajGrupuForma()
        {
            InitializeComponent();
        }

        public DodajGrupuForma(ParkBasic p)
        {
            InitializeComponent();
            park = p;
        }

        private void cmdDodajGrupuRadnika_Click(object sender, EventArgs e)
        {
            GrupaRadnikaBasic gr = new GrupaRadnikaBasic();
            gr.NazivG = txtNaziv.Text;
            DTOManager.dodajGrupuRadnika(gr);

            park.
        }
    }
}
