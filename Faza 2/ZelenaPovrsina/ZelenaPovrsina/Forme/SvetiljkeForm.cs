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
    public partial class SvetiljkeForm : Form
    {
        public SvetiljkeForm()
        {
            InitializeComponent();
        }

        private void SvetiljkeForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaSvetiljke();
        }

        public void popuniPodacimaSvetiljke()
        {


            listView1.Items.Clear();
            List<SvetiljkaPregled> podaci = DTOManager.vratiSveSvetiljke();



            foreach (SvetiljkaPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdO.ToString(), r.IdParka.ToString(), r.RedniBr.ToString(), r.Tip, r.BrSijalica.ToString() });

                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite svetiljku koju zelite da obrisete!");
                return;
            }

            int idSvetiljke = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu svetiljku";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiKlupu(idSvetiljke);
                MessageBox.Show("Brisanje svetiljke je uspesno obavljeno!");
                this.popuniPodacimaSvetiljke();
            }
            else
            {
                MessageBox.Show("Brisanje svetiljke nije obavljeno!");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite svetiljku koju biste želeli da izmenite!");
                return;
            }
            int idD = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            SvetiljkaPregled d = await DTOManager.vratiSvetiljku(idD);
            IzmeniSvetiljkuForm forma = new IzmeniSvetiljkuForm(d, this);
            forma.ShowDialog();
        }
    }
}
