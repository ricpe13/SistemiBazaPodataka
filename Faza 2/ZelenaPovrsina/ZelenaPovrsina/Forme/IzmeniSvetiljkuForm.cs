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
    public partial class IzmeniSvetiljkuForm : Form
    {
        SvetiljkaPregled? svetiljka;
        SvetiljkeForm? forma;
        public IzmeniSvetiljkuForm()
        {
            InitializeComponent();
        }
        public IzmeniSvetiljkuForm(SvetiljkaPregled s, SvetiljkeForm forma)
        {
            svetiljka = s;
            InitializeComponent();
            this.forma = forma;
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if(svetiljka!=null)
            {
                svetiljka.BrSijalica = Int32.Parse(txtBrSij.Text);
                await DTOManager.azurirajSvetiljku(svetiljka);
                MessageBox.Show("Uspesno ste azurirali svetiljku");
                forma.popuniPodacimaSvetiljke();
            }
            else
            {
                MessageBox.Show("Niste uspeli da azurirate svetiljku");
            }
            Close();
        }
    }
}
