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
    public partial class SpomeniciForm : Form
    {
        public SpomeniciForm()
        {
            InitializeComponent();
        }

        private void SpomeniciForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaSpomenike();
        }

        public void popuniPodacimaSpomenike()
        {


            listView1.Items.Clear();
            List<SpomenikPregled> podaci = DTOManager.vratiSveSpomenike();



            foreach (SpomenikPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdO.ToString(), r.IdParka.ToString(), r.RedniBr.ToString(), r.Tip, r.NazivS });

                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite spomenik koji zelite da obrisete!");
                return;
            }

            int idSpomenika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani spomenik";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiKlupu(idSpomenika);
                MessageBox.Show("Brisanje spomenika je uspesno obavljeno!");
                this.popuniPodacimaSpomenike();
            }
            else
            {
                MessageBox.Show("Brisanje spomenika nije obavljeno!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajSpomenikForm form = new DodajSpomenikForm();
            form.ShowDialog();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite spomenik koji biste želeli da izmenite!");
                return;
            }
            int idD = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            SpomenikPregled d = await DTOManager.vratiSpomenik(idD);
            IzmeniSpomenikForm forma = new IzmeniSpomenikForm(d, this);
            forma.ShowDialog();
        }
    }
}
