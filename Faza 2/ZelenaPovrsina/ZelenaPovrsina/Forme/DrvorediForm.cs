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
    public partial class DrvorediForm : Form
    {
        public DrvorediForm()
        {
            InitializeComponent();
        }

        private void DrvoredForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaDrvoredi();
        }

        public void popuniPodacimaDrvoredi()
        {


            listView1.Items.Clear();
            List<DrvoredPregled> podaci = DTOManager.vratiSveDrvorede();



            foreach (DrvoredPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(), r.Ulica, r.Duzina.ToString(), r.VrstaDrveta, r.BrojStabala.ToString() });
                //NE ZNAM KAKO ZA IDGRUPE I ZELENE POVRSINE
                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            DodajDrvoredForma forma = new DodajDrvoredForma();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite drvored koji zelite da obrisete!");
                return;
            }

            int idDrvored = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani drvored?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiRadnika(idDrvored);
                MessageBox.Show("Brisanje drvoreda je uspesno obavljeno!");
                this.popuniPodacimaDrvoredi();
            }
            else
            {

            }
        }

        private void DrvorediForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaDrvorede();
        }

        public void popuniPodacimaDrvorede()
        {


            listView1.Items.Clear();
            List<DrvoredPregled> podaci = DTOManager.vratiSveDrvorede();



            foreach (DrvoredPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(), r.Ulica, r.Duzina.ToString(), r.VrstaDrveta, r.BrojStabala.ToString() });
                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite drvored koji biste želeli da izmenite!");
                return;
            }
            int idD = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DrvoredBasic d = await DTOManager.vratiDrvored(idD);
            IzmeniDrvoredForm forma = new IzmeniDrvoredForm(d, this);
            forma.ShowDialog();
        }
    }
}
