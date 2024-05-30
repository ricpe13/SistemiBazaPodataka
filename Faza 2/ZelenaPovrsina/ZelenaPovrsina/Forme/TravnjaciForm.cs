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
    public partial class TravnjaciForm : Form
    {
        public TravnjaciForm()
        {
            InitializeComponent();
        }

        private void TravnjaciForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaTravnjaci();
        }

        public void popuniPodacimaTravnjaci()
        {


            listView1.Items.Clear();
            List<TravnjakPregled> podaci = DTOManager.vratiSveTravnjake();



            foreach (TravnjakPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(), r.AdresaZgrade, r.PovrsinaT.ToString() });
                
                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }







        private void btnDodajTravnjak_Click(object sender, EventArgs e)
        {
            DodajTravnjakForma forma = new DodajTravnjakForma();
            forma.ShowDialog();
        }
    }
}
