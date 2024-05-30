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
    public partial class RadniciForm : Form
    {
        public RadniciForm()
        {
            InitializeComponent();
        }

        private void RadniciForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaRadnici();
        }

        public void popuniPodacimaRadnici()
        {


            listView1.Items.Clear();
            List<RadnikPregled> podaci = DTOManager.vratiSveRadnike();



            foreach (RadnikPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdR.ToString(), r.Ime, r.Prezime, r.Jmbg, r.Adresa, r.BrRadneKnjizice.ToString(), r.ImeRoditelja, r.StrucnaSprema, r.DatumRodj.ToString(), r.ZaZelenilo.ToString(), r.ZaHigijenu.ToString(), r.ZaObjekat.ToString()});
                //NE ZNAM KAKO ZA IDGRUPE I ZELENE POVRSINE
                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }





        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            DodajRanikaForma forma = new DodajRanikaForma();
            forma.ShowDialog();
            popuniPodacimaRadnici();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }

            int idRadnik = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog radnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiRadnika(idRadnik);
                MessageBox.Show("Brisanje zaposlenog je uspesno obavljeno!");
                this.popuniPodacimaRadnici();
            }
            else
            {

            }
        }
    }
}

