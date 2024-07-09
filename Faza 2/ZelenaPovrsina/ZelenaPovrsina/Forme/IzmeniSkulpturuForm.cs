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
    public partial class IzmeniSkulpturuForm : Form
    {
        SkulpturaPregled? skulptura;
        SkulptureForm? forma;
        public IzmeniSkulpturuForm()
        {
            InitializeComponent();
        }
        public IzmeniSkulpturuForm(SkulpturaPregled s, SkulptureForm forma)
        {
            this.skulptura = s;
            InitializeComponent();
            this.forma = forma;
        }

        private void IzmeniSkulpturuForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if(skulptura != null)
            {
                skulptura.Autor = txtAutor.Text;

                await DTOManager.azurirajSkulpturu(skulptura);
                MessageBox.Show("Uspesno ste azurirali skulpturu");
                forma.popuniPodacimaSkulpture();
            }
            else
            {
                MessageBox.Show("Niste uspeli da azurirate skultpuru");
            }
            Close();
        }
    }
}
