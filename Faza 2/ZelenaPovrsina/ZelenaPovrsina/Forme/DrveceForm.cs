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
    public partial class DrveceForm : Form
    {
        public DrveceForm()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite drvo koje zelite da obrisete!");
                return;
            }

            int idD = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano drvo";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiKlupu(idD);
                MessageBox.Show("Brisanje drveta je uspesno obavljeno!");
                this.popuniPodacimaDrvece();
            }
            else
            {
                MessageBox.Show("Brisanje drveta nije obavljeno!");
            }
        }

        private void DrveceForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaDrvece();
        }

        public void popuniPodacimaDrvece()
        {


            listView1.Items.Clear();
            List<DrvoPregled> podaci = DTOManager.vratiSvaDrveca();



            foreach (DrvoPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdO.ToString(), r.IdParka.ToString(), r.RedniBr.ToString(), r.Tip, r.VisinaKrosnje.ToString(), r.Vrsta, r.DatumSadnje.ToString(), r.PovrsinaK.ToString(), r.ObimDebla.ToString() });

                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajDrvoForm form = new DodajDrvoForm();
            form.ShowDialog();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite drvo koje biste želeli da izmenite!");
                return;
            }
            int idD = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DrvoPregled d = await DTOManager.vratiDrvo(idD);
            IzmeniDrvoForm forma = new IzmeniDrvoForm(d, this);
            forma.ShowDialog();
        }
    }
}
