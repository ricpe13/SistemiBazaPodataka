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
    public partial class GrupeRadnikaForm : Form
    {
        public GrupeRadnikaForm()
        {
            InitializeComponent();
        }

        private void GrupeRadnikaForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaGrupeRadnika();
        }

        public void popuniPodacimaGrupeRadnika()
        {


            listView1.Items.Clear();
            List<GrupaRadnikaPregled> podaci = DTOManager.vratiSveGrupeRadnika();



            foreach (GrupaRadnikaPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdG.ToString(), r.NazivG }); //fali za idParka
                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            DodajGrupuForma forma = new DodajGrupuForma();
            forma.ShowDialog();
        }



        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite grupu radnika koju zelite da obrisete!");
                return;
            }

            int idGrupeRadnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu grupu radnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiGrupuRadnika(idGrupeRadnika);
                MessageBox.Show("Brisanje grupe radnika je uspesno obavljeno!");
                this.popuniPodacimaGrupeRadnika();
            }
            else
            {
                MessageBox.Show("Brisanje grupe radnika nije obavljeno!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite grupu radnika koju biste želeli da izmenite!");
                return;
            }
            int idG = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            GrupaRadnikaPregled d = await DTOManager.vratiGrupuRadnika(idG);
            IzmeniGrupuForm forma = new IzmeniGrupuForm(d, this);
            forma.ShowDialog();
        }
    }
}
