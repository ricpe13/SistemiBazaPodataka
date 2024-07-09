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
    public partial class FontaneForm : Form
    {
        public FontaneForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajFontanuForm form = new DodajFontanuForm();
            form.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite fontanu koju zelite da obrisete!");
                return;
            }

            int idFontane = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu fontanu";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiKlupu(idFontane);
                MessageBox.Show("Brisanje fontane je uspesno obavljeno!");
                this.popuniPodacimaFontane();
            }
            else
            {
                MessageBox.Show("Brisanje fontane nije obavljeno!");
            }
        }

        private void FontaneForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaFontane();
        }

        public void popuniPodacimaFontane()
        {


            listView1.Items.Clear();
            List<FontanaPregled> podaci = DTOManager.vratiSveFontane();



            foreach (FontanaPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdO.ToString(), r.IdParka.ToString(), r.RedniBr.ToString(), r.Tip, r.BrPrskalica.ToString(), r.PovrsinaF.ToString() });

                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite fontanu koju biste želeli da izmenite!");
                return;
            }
            int idF = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            FontanaPregled d = await DTOManager.vratiFontanu(idF);
            IzmeniFontanu forma = new IzmeniFontanu(d, this);
            forma.ShowDialog();
        }
    }
}
