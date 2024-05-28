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


                Entiteti.Radnik r = new Entiteti.Radnik();

                r.Ime = "Nemanja";
                r.Prezime = "Stamenkovic";
                r.Jmbg = "1205995734829";
                r.Adresa = "Somborski bulevar 12";
                r.BrRadneKnjizice = 978;
                r.ImeRoditelja = "Aleksa";
                r.StrucnaSprema = "VI stepen";
                r.DatumRodj = new DateTime(1995,5, 12); // videti da li moze drugacije da se napise //inace ovo je (godina,mesec,dan)
                r.ZaZelenilo = 1;
                r.ZaHigijenu = 0;
                r.ZaObjekat = 0;
                //r.IdZP = 5;
                //r.IdGrupe = 1;

                s.Save(r);
                //s.SaveOrUpdate(r); //ima i ova mogucnost, ali sada je isto Save i SaveOrUpdate

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
                    NazivG = "NovaGrupa",
                    
                };

                Radnik r = new Radnik()
                {
                    Ime = "Niša",
                    Prezime = "",
                    Jmbg = "Da",
                    Adresa = "",
                    BrRadneKnjizice = 1,
                    ImeRoditelja = "",
                    StrucnaSprema = "",
                    DatumRodj = new DateTime(),
                    ZaZelenilo = 1,
                    ZaHigijenu = 1,
                    ZaObjekat = 0
                };

                Radnik r1 = new Radnik()
                {
                    Ime = "Niš",
                    Prezime = "",
                    Jmbg = "Da",
                    Adresa = "",
                    BrRadneKnjizice = 1,
                    ImeRoditelja = "",
                    StrucnaSprema = "",
                    DatumRodj = new DateTime(),
                    ZaZelenilo = 1,
                    ZaHigijenu = 1,
                    ZaObjekat = 0
                };



                s.Save(gr);

                r.PripadaGrupi = gr;
                s.Save(r);

                r1.PripadaGrupi = gr;
                s.Save(r1);

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
