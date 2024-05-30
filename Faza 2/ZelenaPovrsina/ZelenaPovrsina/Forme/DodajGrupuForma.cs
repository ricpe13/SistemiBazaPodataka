using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZelenaPovrsina.Forme
{

    public partial class DodajGrupuForma : Form
    {
        ParkPregled park;
        public DodajGrupuForma()
        {
            InitializeComponent();
        }

        public DodajGrupuForma(ParkPregled p)
        {
            InitializeComponent();
            park = p;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            parkovi.Items.Clear();
            List<ParkPregled> podaci = DTOManager.vratiSveParkove();



            foreach (ParkPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(), r.NazivP, r.PovrsinaP.ToString() });
                // fali za broj objekata
                parkovi.Items.Add(item);

            }



            parkovi.Refresh();

        }
        private void cmdDodajGrupuRadnika_Click(object sender, EventArgs e)
        {
            GrupaRadnikaBasic gr = new GrupaRadnikaBasic();
            gr.NazivG = txtNaziv.Text;
            DTOManager.dodajGrupuRadnika(gr);


        }



        private void parkoviBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajGrupuForma_Load(object sender, EventArgs e)
        {

        }
    }
}
