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
    public partial class KlupeForm : Form
    {
        public KlupeForm()
        {
            InitializeComponent();
        }


        private void KlupeForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaKlupe();
        }

        public void popuniPodacimaKlupe()
        {


            listView1.Items.Clear();
            List<KlupaPregled> podaci = DTOManager.vratiSveKlupe();



            foreach (KlupaPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdO.ToString(), r.IdParka.ToString(), r.RedniBr.ToString(), r.Tip, r.Materijal });

                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite klupu koju zelite da obrisete!");
                return;
            }

            int idKlupa = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu klupu";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiKlupu(idKlupa);
                MessageBox.Show("Brisanje klupe je uspesno obavljeno!");
                this.popuniPodacimaKlupe();
            }
            else
            {
                MessageBox.Show("Brisanje klupe nije obavljeno!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajKlupuForma form = new DodajKlupuForma();
            form.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite klupu koju biste želeli da izmenite!");
                return;
            }
            int idD = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            KlupaPregled d = await DTOManager.vratiKlupu(idD);
            IzmeniKlupuForm forma = new IzmeniKlupuForm(d, this);
            forma.ShowDialog();
        }
    }
}
