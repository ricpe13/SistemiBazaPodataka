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
    public partial class RadniciForm : Form
    {
        public RadniciForm()
        {
            InitializeComponent();
        }

        private void RadniciForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaRadnici();
        }

        public void popuniPodacimaRadnici()
        {


            listaRadnika.Items.Clear();
            List<RadnikPregled> podaci = DTOManager.vratiSveRadnike();



            foreach (RadnikPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Adresa, p.BrojTelefona, p.RadniDan, p.Subota, p.Nedelja });
                listaRadnika.Items.Add(item);

            }



            listaRadnika.Refresh();
        }





        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            DodajRanikaForma forma = new DodajRanikaForma();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
