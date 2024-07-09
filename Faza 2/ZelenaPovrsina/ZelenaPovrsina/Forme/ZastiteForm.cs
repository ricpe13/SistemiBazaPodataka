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
    public partial class ZastiteForm : Form
    {
        public ZastiteForm()
        {
            InitializeComponent();
        }

        private async void btnObrisiZastitu_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zastitu koju zelite da obrisete!");
                return;
            }

            int idZ = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu zastitu";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiKlupu(idZ);
                MessageBox.Show("Brisanje zastite je uspesno obavljeno!");
                this.popuniPodacimaZastite();
            }
            else
            {
                MessageBox.Show("Brisanje zastite nije obavljeno!");
            }
        }

        private void ZastiteForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaZastite();
        }

        public void popuniPodacimaZastite()
        {


            listView1.Items.Clear();
            List<ZastitaPregled> podaci = DTOManager.vratiSveZastite();



            foreach (ZastitaPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdZastite.ToString(), r.Institucija, r.DatumOd.ToString(), r.NovcanaSredstva.ToString(), r.OpisZnacaja });

                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private void btnDodajZastitu_Click(object sender, EventArgs e)
        {

        }
    }
}
