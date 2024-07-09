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
    public partial class ParkoviForm : Form
    {
        public ParkoviForm()
        {
            InitializeComponent();
        }

        private void ParkoviForm_Load_1(object sender, EventArgs e)
        {
            popuniPodacimaParkovi();
        }

        public void popuniPodacimaParkovi()
        {


            listView1.Items.Clear();
            List<ParkPregled> podaci = DTOManager.vratiSveParkove();



            foreach (ParkPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(), r.NazivP, r.PovrsinaP.ToString() });
                // fali za broj objekata
                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DodajParkForma form = new DodajParkForma();
            form.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite park koji želite da izmenite!");
                return;
            }

            int idParka = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ParkBasic p = await DTOManager.vratiPark(idParka);
            IzmeniParkForm forma = new IzmeniParkForm(p, this);
            forma.ShowDialog();
        }

        private async void btnObrisiPark_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite park koji zelite da obrisete!");
                return;
            }

            int idParka = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani park?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiPark(idParka);
                MessageBox.Show("Brisanje parka je uspesno obavljeno!");
                this.popuniPodacimaParkovi();
            }
            else
            {
                MessageBox.Show("Brisanje parka nije obavljeno!");
            }
        }

        
    }
}
