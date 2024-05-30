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
    }
}
