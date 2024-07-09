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
    public partial class SkulptureForm : Form
    {
        public SkulptureForm()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite skulpturu koju zelite da obrisete!");
                return;
            }

            int idSkulpture = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu skulpturu";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiSkulpturu(idSkulpture);
                MessageBox.Show("Brisanje skulpture je uspesno obavljeno!");
                this.popuniPodacimaSkulpture();
            }
            else
            {
                MessageBox.Show("Brisanje skulpture nije obavljeno!");
            }
        }

        private void SkulptureForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaSkulpture();
        }

        public void popuniPodacimaSkulpture()
        {


            listView1.Items.Clear();
            List<SkulpturaPregled> podaci = DTOManager.vratiSveSkulpture();



            foreach (SkulpturaPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdO.ToString(), r.IdParka.ToString(), r.RedniBr.ToString(), r.Tip, r.Autor });

                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajSkulpturuForm form = new DodajSkulpturuForm();
            form.ShowDialog();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite skulpturu koju biste želeli da izmenite!");
                return;
            }
            int idD = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            SkulpturaPregled d = await DTOManager.vratiSkulpturu(idD);
            IzmeniSkulpturuForm forma = new IzmeniSkulpturuForm(d, this);
            forma.ShowDialog();
        }
    }
}
