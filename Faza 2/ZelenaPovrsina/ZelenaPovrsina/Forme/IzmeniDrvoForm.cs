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
    public partial class IzmeniDrvoForm : Form
    {
        DrvoPregled? drvo;
        DrveceForm? forma;
        public IzmeniDrvoForm()
        {
            InitializeComponent();
        }
        public IzmeniDrvoForm(DrvoPregled d, DrveceForm forma)
        {
            drvo = d;
            InitializeComponent();
            this.forma = forma;
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (drvo != null)
            {
                drvo.VisinaKrosnje = Int32.Parse(txtVisina.Text);
                drvo.ObimDebla = Int32.Parse(txtObim.Text);
                drvo.PovrsinaK = Int32.Parse(txtPovrsina.Text);

                await DTOManager.azurirajDrvo(drvo);
                MessageBox.Show("Uspesno ste izmenili igraliste");
                forma.popuniPodacimaDrvece();
            }
            else
            {
                MessageBox.Show("Niste uspeli da izmenite decije igraliste");
            }
            Close();
        }
    }
}
