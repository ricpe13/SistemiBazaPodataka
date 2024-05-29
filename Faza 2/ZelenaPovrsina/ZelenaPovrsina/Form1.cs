using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cmdUcitavanjeRadnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o radniku za zadatim id-jem
                ZelenaPovrsina.Entiteti.Radnik r = s.Load<ZelenaPovrsina.Entiteti.Radnik>(1);

                MessageBox.Show(r.Jmbg);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
                //MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeRadnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Entiteti.ZelenaPovrsina z = new Entiteti.ZelenaPovrsina()
                {
                    NazivGradskeOpstine = "crveni krst",
                    ZonaUgrozenosti = "B",
                    TipZ = "travnjak"
                };

                Entiteti.Radnik r = new Entiteti.Radnik();
                
                r.Ime = "Mihajlo";
                r.Prezime = "Jovic";
                r.Jmbg = "1111111111111";
                r.Adresa = "Bubanjska 55";
                r.BrRadneKnjizice = 999;
                r.ImeRoditelja = "Aleksa";
                r.StrucnaSprema = "VI stepen";
                r.DatumRodj = new DateTime(1995, 5, 12); 
                r.ZaZelenilo = 1;
                r.ZaHigijenu = 0;
                r.ZaObjekat = 0;
                
                s.Save(z);
                
                r.AngazovanZaZP = z;
                

                s.Save(r);
                
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManyToOneRadnikGrupa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radnik r = s.Load<Radnik>(1); //ovde se pise id radnika

                MessageBox.Show(r.Ime + " " + r.Prezime + " " + r.BrRadneKnjizice);
                MessageBox.Show(r.PripadaGrupi.NazivG);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdOneToManyGrupaRadnik_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.GrupaRadnika gr = s.Load<ZelenaPovrsina.Entiteti.GrupaRadnika>(1);

                foreach (Radnik r in gr.RadniciGrupe)
                {
                    MessageBox.Show(r.Ime + " " + r.Prezime + " " + r.BrRadneKnjizice);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajRadnikaUGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaRadnika gr = new GrupaRadnika()
                {
                    NazivG = "NovaGrupa"
                    
                };
                Park p = new Park()
                {
                    NazivP="Lelele"
                };
                Radnik radnik = new Radnik()
                {
                    Ime = "mmmm",
                    Prezime = "A",
                    Jmbg = "1234567891123",
                    Adresa = "A",
                    BrRadneKnjizice = 22,
                    ImeRoditelja = "A",
                    StrucnaSprema = "A",
                    DatumRodj = new DateTime(),
                    ZaZelenilo = 1,
                    ZaHigijenu = 1,
                    ZaObjekat = 0
                };
                Sef sef = new Sef()
                {
                    Matbr = "1111111111111"
                };


                Radnik r = new Radnik()
                {
                    Ime = "Niša",
                    Prezime = "A",
                    Jmbg = "Da",
                    Adresa = "A",
                    BrRadneKnjizice = 1,
                    ImeRoditelja = "A",
                    StrucnaSprema = "A",
                    DatumRodj = new DateTime(),
                    ZaZelenilo = 1,
                    ZaHigijenu = 1,
                    ZaObjekat = 0
                };

                Radnik r1 = new Radnik()
                {
                    Ime = "Niš",
                    Prezime = "J",
                    Jmbg = "2222222222222",
                    Adresa = "A",
                    BrRadneKnjizice = 25,
                    ImeRoditelja = "A",
                    StrucnaSprema = "A",
                    DatumRodj = new DateTime(),
                    ZaZelenilo = 1,
                    ZaHigijenu = 1,
                    ZaObjekat = 0
                };

                sef.GrupaRadnika = gr;
                gr.Sef = sef;
                gr.Park = p;
                p.GrupaRadnika = gr;

                r.PripadaGrupi = gr;
                s.Save(r);

                r1.PripadaGrupi = gr;
                s.Save(r1);
                
                s.Save(gr);

                gr.RadniciGrupe.Add(r);
                gr.RadniciGrupe.Add(r1);

                s.Save(gr);
                s.Flush(); //ovo ima na 2. snimku
                s.Close(); //i ovo ima na 2. snimku

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdVratiPark_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Park gr = s.Load<ZelenaPovrsina.Entiteti.Park>(0);


                MessageBox.Show($"{gr.GrupaRadnika.IdG}");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
                //MessageBox.Show(ec.Message);
            }
        }
    }
}
