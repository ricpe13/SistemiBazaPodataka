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
    public partial class DecijaIgralistaForm : Form
    {
        public DecijaIgralistaForm()
        {
            InitializeComponent();
        }

        private void DecijaIgralistaForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaDecijaIgralista();
        }

        public void popuniPodacimaDecijaIgralista()
        {


            listView1.Items.Clear();
            List<DecijeIgralistePregled> podaci = DTOManager.vratiSvaDecijaIgralista();



            foreach (DecijeIgralistePregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdO.ToString(), r.IdParka.ToString(), r.RedniBr.ToString(), r.Tip, r.BrIgracaka.ToString(), r.Pesak.ToString(), r.Starost.ToString() });

                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite decije igraliste koje zelite da obrisete!");
                return;
            }

            int idDI = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano decije igraliste";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiKlupu(idDI);
                MessageBox.Show("Brisanje decijeg igralista je uspesno obavljeno!");
                this.popuniPodacimaDecijaIgralista();
            }
            else
            {
                MessageBox.Show("Brisanje decijeg igralista nije obavljeno!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajDecijeIgralisteForm form = new DodajDecijeIgralisteForm();
            form.ShowDialog();
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dečije igralište koje biste želeli da izmenite!");
                return;
            }
            int idIgr = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DecijeIgralistePregled d = await DTOManager.vratiDecijeIgraliste(idIgr);
            IzmeniIgralisteForm forma = new IzmeniIgralisteForm(d, this);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
