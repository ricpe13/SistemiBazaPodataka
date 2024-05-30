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

        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            DodajRanikaForma forma = new DodajRanikaForma();
            forma.ShowDialog();
        }
    }
}
