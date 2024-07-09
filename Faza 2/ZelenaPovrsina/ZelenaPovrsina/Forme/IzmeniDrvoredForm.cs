using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Forme
{
    public partial class IzmeniDrvoredForm : Form
    {
        DrvoredBasic? drvored;
        DrvorediForm? forma;
        public IzmeniDrvoredForm()
        {
            InitializeComponent();
        }
        public IzmeniDrvoredForm(DrvoredBasic d, DrvorediForm forma)
        {
            drvored = d;
            InitializeComponent();
            this.forma = forma;
        }

        private async void btnDodajDrvor_Click(object sender, EventArgs e)
        {
            if(drvored!=null)
            {
                drvored.Duzina=Int32.Parse(txtDuzinaDrvored.Text);
                drvored.BrojStabala=Int32.Parse(txtBrojDrvored.Text);
                await DTOManager.azurirajDrvored(drvored);
                MessageBox.Show("Uspesno ste izmenili drvored");
                forma.popuniPodacimaDrvoredi();
            }
        }
    }
}
