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
    public partial class ParkoviForm : Form
    {
        public ParkoviForm()
        {
            InitializeComponent();
        }

        private void ParkoviForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaParkovi();
        }

        public void popuniPodacimaParkovi()
        {


            listView1.Items.Clear();
            List<ParkPregled> podaci = DTOManager.vratiSveParkove();



            foreach (ParkPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(), r.NazivP, r.PovrsinaP.ToString() });
                // fali za broj objekata
                listView1.Items.Add(item);

            }



            listView1.Refresh();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DodajParkForma form = new DodajParkForma();
            form.ShowDialog();
        }
    }
}
