using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.DTO
{
    internal class DTOManager
    {
        #region Radnik
        public static void dodajRadnika(RadnikBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Radnik o = new ZelenaPovrsina.Entiteti.Radnik();

                o.Ime = r.Ime;
                o.Prezime = r.Prezime;
                o.Jmbg = r.Jmbg;
                o.Adresa = r.Adresa;
                o.BrRadneKnjizice = r.BrRadneKnjizice;
                o.ImeRoditelja = r.ImeRoditelja;
                o.StrucnaSprema = r.StrucnaSprema;
                o.DatumRodj = r.DatumRodj;
                o.ZaZelenilo = r.ZaZelenilo;
                o.ZaZelenilo = r.ZaZelenilo;
                o.ZaHigijenu = r.ZaHigijenu;
                o.ZaObjekat = r.ZaObjekat;
                // ZelenaPovrsina.Entiteti.ZelenaPovrsina zp = s.Load<ZelenaPovrsina.Entiteti.ZelenaPovrsina>(r.ZelenaPovrsina.Id);
                // o.AngazovanZaZP = zp;

                s.SaveOrUpdate(o);



                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());

            }
        }

        public static List<RadnikPregled> vratiSveRadnike()
        {
            List<RadnikPregled> radnici = new List<RadnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ZelenaPovrsina.Entiteti.Radnik> sviRadnici = from o in s.Query<ZelenaPovrsina.Entiteti.Radnik>()
                                                                            select o;

                foreach (ZelenaPovrsina.Entiteti.Radnik r in sviRadnici)
                {
                    radnici.Add(new RadnikPregled(r.IdR, r.Ime, r.Prezime, r.Jmbg, r.Adresa, r.BrRadneKnjizice, r.ImeRoditelja, 
                        r.StrucnaSprema, r.DatumRodj, r.ZaZelenilo, r.ZaHigijenu, r.ZaObjekat));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return radnici;
        }

        public static void obrisiRadnika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Radnik r = s.Load<ZelenaPovrsina.Entiteti.Radnik>(id);

                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static RadnikBasic azurirajRadnika(RadnikBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Radnik o = s.Load<ZelenaPovrsina.Entiteti.Radnik>(r.IdR);
                o.Adresa = r.Adresa;
                o.StrucnaSprema = r.StrucnaSprema;
                o.ZaZelenilo = r.ZaZelenilo;
                o.ZaHigijenu = r.ZaHigijenu;
                o.ZaObjekat = r.ZaObjekat;
                //treba i za izmenu Id zelene povrsine, ali ne znam kako

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }




        #endregion

        #region Park

        public static void dodajPark(ParkBasic park)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Park p = new Park();

                p.NazivP = park.NazivP;
                p.TipZ = park.TipZ;
                p.ZonaUgrozenosti = park.ZonaUgrozenosti;
                p.PovrsinaP = park.PovrsinaP;
                p.NazivGradskeOpstine = park.NazivGradskeOpstine;

                s.Save(p); s.Flush(); s.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.FormatExceptionMessage());
            }
        }

        public static void obrisiPark(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Park p = s.Load<ZelenaPovrsina.Entiteti.Park>(id);

                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion


        #region Travnjak

        public static void dodajTravnjak(TravnjakBasic travnjak)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Travnjak t = new Travnjak();

                t.TipZ = travnjak.TipZ;
                t.AdresaZgrade = travnjak.AdresaZgrade;
                t.PovrsinaT = travnjak.PovrsinaT;
                t.NazivGradskeOpstine = travnjak.NazivGradskeOpstine;
                t.ZonaUgrozenosti = travnjak.ZonaUgrozenosti;


                s.Save(t); s.Flush(); s.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.FormatExceptionMessage());
            }
        }

        public static void obrisiTravnjak(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Travnjak t = s.Load<ZelenaPovrsina.Entiteti.Travnjak>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion


        #region Drvored

        public static void dodajDrvored(DrvoredBasic drvored)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    ZelenaPovrsina.Entiteti.Drvored d = new Drvored();
                    
                    d.TipZ = drvored.TipZ;
                    d.Ulica = drvored.Ulica;
                    d.Duzina = drvored.Duzina;
                    d.VrstaDrveta = drvored.VrstaDrveta;
                    d.BrojStabala = drvored.BrojStabala;
                    d.NazivGradskeOpstine = drvored.NazivGradskeOpstine;
                    d.ZonaUgrozenosti = drvored.ZonaUgrozenosti;


                s.Save(d); s.Flush(); s.Close();


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.FormatExceptionMessage());
                }
            }



            public static void obrisiDrvored(int id)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    ZelenaPovrsina.Entiteti.Drvored d = s.Load<ZelenaPovrsina.Entiteti.Drvored>(id);

                    s.Delete(d);
                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    //handle exceptions
                }
            }
        #endregion
    }
}
