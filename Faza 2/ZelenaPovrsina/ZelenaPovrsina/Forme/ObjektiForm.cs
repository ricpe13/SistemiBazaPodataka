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
    public partial class ObjektiForm : Form
    {
        public ObjektiForm()
        {
            InitializeComponent();
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KlupeForm forma = new KlupeForm();
            forma.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SpomeniciForm forma = new SpomeniciForm();
            forma.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FontaneForm forma = new FontaneForm();
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DrveceForm forma = new DrveceForm();
            forma.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SkulptureForm forma = new SkulptureForm();
            forma.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DecijaIgralistaForm forma = new DecijaIgralistaForm();
            forma.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SvetiljkeForm forma = new SvetiljkeForm();
            forma.ShowDialog();
        }
    }
}
