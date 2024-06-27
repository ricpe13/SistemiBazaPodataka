using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenaPovrsina.Entiteti;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZelenaPovrsina.DTO
{
    internal class DTOManager
    {
        #region Radnik
        
        public static async Task<bool> dodajRadnika(RadnikBasic r)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Radnik o = new Radnik();

                    o.Ime = r.Ime;
                    o.Prezime = r.Prezime;
                    o.Jmbg = r.Jmbg;
                    o.Adresa = r.Adresa;
                    o.BrRadneKnjizice = r.BrRadneKnjizice;
                    o.ImeRoditelja = r.ImeRoditelja;
                    o.StrucnaSprema = r.StrucnaSprema;
                    o.DatumRodj = r.DatumRodj;
                    o.ZaZelenilo = r.ZaZelenilo;
                    o.ZaHigijenu = r.ZaHigijenu;
                    o.ZaObjekat = r.ZaObjekat;
                    // ZelenaPovrsina.Entiteti.ZelenaPovrsina zp = s.Load<ZelenaPovrsina.Entiteti.ZelenaPovrsina>(r.ZelenaPovrsina.Id);
                    // o.AngazovanZaZP = zp;

                    await s.SaveAsync(o);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
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

            return r;
        }




        #endregion

        #region Park

        public static async Task<bool> dodajPark(ParkBasic park)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Park p = new Park();

                    p.NazivP = park.NazivP;
                    p.TipZ = park.TipZ;
                    p.ZonaUgrozenosti = park.ZonaUgrozenosti;
                    p.PovrsinaP = park.PovrsinaP;
                    p.NazivGradskeOpstine = park.NazivGradskeOpstine;

                    await s.SaveAsync(p);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
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

        public static List<ParkPregled> vratiSveParkove()
        {
            List<ParkPregled> parkovi = new List<ParkPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ZelenaPovrsina.Entiteti.Park> sviParkovi = from o in s.Query<ZelenaPovrsina.Entiteti.Park>()
                                                                         select o;

                foreach (ZelenaPovrsina.Entiteti.Park r in sviParkovi)
                {
                    parkovi.Add(new ParkPregled(r.IdZ, r.NazivGradskeOpstine, r.ZonaUgrozenosti,r.TipZ,r.NazivP,r.PovrsinaP));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return parkovi;
        }

        public static ParkBasic vratiPark(int id)
        {
            ParkBasic pb = new ParkBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                ZelenaPovrsina.Entiteti.Park p = s.Load<ZelenaPovrsina.Entiteti.Park>(id);
                pb = new ParkBasic(p.IdZ, p.NazivGradskeOpstine, p.ZonaUgrozenosti, p.TipZ, p.NazivP, p.PovrsinaP);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.FormatExceptionMessage());
            }

            return pb;
        }

        #endregion

        #region GrupaRadnika

        public static async Task<bool> dodajGrupuRadnika(GrupaRadnikaBasic v)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    GrupaRadnika g = new GrupaRadnika();

                    g.NazivG = v.NazivG;
                    ZelenaPovrsina.Entiteti.Park p = s.Load<ZelenaPovrsina.Entiteti.Park>(v.Park.Id);
                    g.Park = p;
                    s.Save(g); s.Flush(); s.Close();

                    await s.SaveAsync(g);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }


        public static List<GrupaRadnikaBasic> vratiSveGrupe()
        {
            List<GrupaRadnikaBasic> grupaBasic = new List<GrupaRadnikaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<GrupaRadnika> grupe = from o in s.Query<ZelenaPovrsina.Entiteti.GrupaRadnika>()
                                            select o;
                foreach (GrupaRadnika g in grupe)
                {
                    GrupaRadnikaBasic grupa = DTOManager.vratiGrupu(g.IdG);
                    grupaBasic.Add(grupa);
                }
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.FormatExceptionMessage());
            }

            return grupaBasic;
        }

        public static GrupaRadnikaBasic vratiGrupu(int id)
        {
            GrupaRadnikaBasic pb = new GrupaRadnikaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                ZelenaPovrsina.Entiteti.GrupaRadnika p = s.Load<ZelenaPovrsina.Entiteti.GrupaRadnika>(id);
                pb = new GrupaRadnikaBasic(p.IdG, p.NazivG);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.FormatExceptionMessage());
            }

            return pb;
        }

        #endregion


        #region Travnjak

        public static async Task<bool> dodajTravnjak(TravnjakBasic travnjak)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Travnjak t = new Travnjak();

                    t.TipZ = travnjak.TipZ;
                    t.AdresaZgrade = travnjak.AdresaZgrade;
                    t.PovrsinaT = travnjak.PovrsinaT;
                    t.NazivGradskeOpstine = travnjak.NazivGradskeOpstine;
                    t.ZonaUgrozenosti = travnjak.ZonaUgrozenosti;

                    await s.SaveAsync(t);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
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


        public static List<TravnjakPregled> vratiSveTravnjake()
        {
            List<TravnjakPregled> travnjaci = new List<TravnjakPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ZelenaPovrsina.Entiteti.Travnjak> sviTravnjaci = from o in s.Query<ZelenaPovrsina.Entiteti.Travnjak>()
                                                                         select o;

                foreach (ZelenaPovrsina.Entiteti.Travnjak r in sviTravnjaci)
                {
                    travnjaci.Add(new TravnjakPregled(r.IdZ, r.NazivGradskeOpstine, r.ZonaUgrozenosti, r.TipZ, r.AdresaZgrade, r.PovrsinaT));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return travnjaci;
        }




        #endregion


        #region Drvored

        public static async Task<bool> dodajDrvored(DrvoredBasic drvored)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Drvored d = new Drvored();

                    d.TipZ = drvored.TipZ;
                    d.Ulica = drvored.Ulica;
                    d.Duzina = drvored.Duzina;
                    d.VrstaDrveta = drvored.VrstaDrveta;
                    d.BrojStabala = drvored.BrojStabala;
                    d.NazivGradskeOpstine = drvored.NazivGradskeOpstine;
                    d.ZonaUgrozenosti = drvored.ZonaUgrozenosti;

                    await s.SaveAsync(d);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }



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


            public static DrvoredBasic azurirajDrvored(DrvoredBasic d)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    ZelenaPovrsina.Entiteti.Drvored o = s.Load<ZelenaPovrsina.Entiteti.Drvored>(d.Id);
                    o.VrstaDrveta = d.VrstaDrveta;
                    o.BrojStabala = d.BrojStabala;

                    s.Update(o);
                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    //handle exceptions
                }

                return d;
            }


            public static List<DrvoredPregled> vratiSveDrvorede()
            {
                List<DrvoredPregled> drvoredi = new List<DrvoredPregled>();
                try
                {
                    ISession s = DataLayer.GetSession();

                    IEnumerable<ZelenaPovrsina.Entiteti.Drvored> sviDrvoredi = from o in s.Query<ZelenaPovrsina.Entiteti.Drvored>()
                                                                           select o;

                    foreach (ZelenaPovrsina.Entiteti.Drvored r in sviDrvoredi)
                    {
                        drvoredi.Add(new DrvoredPregled(r.IdZ, r.NazivGradskeOpstine, r.ZonaUgrozenosti, r.TipZ, r.Ulica, r.Duzina, r.VrstaDrveta, r.BrojStabala));
                    }

                    s.Close();
                }
                catch (Exception ec)
                {
                    //handle exceptions
                }

                return drvoredi;
            }




        #endregion

        #region DecijeIgraliste

        public static async Task<bool> dodajDecijeIgraliste(DecijeIgralisteBasic r)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    DecijeIgraliste o = new DecijeIgraliste(); //ne znam sta je ovde greska

                    o.Tip = r.Tip;
                    o.BrIgracaka = r.BrIgracaka;
                    o.Pesak = r.Pesak;
                    o.Starost = r.Starost;

                    await s.SaveAsync(o);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }


        public static List<RadnikPregled> vratiSvaDecijaIgralista()
        {
            List<DecijeIgralisteBasic> decijaigralista = new List<DecijeIgralisteBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ZelenaPovrsina.Entiteti.DecijeIgraliste> svaDecijaIgralista = from o in s.Query<ZelenaPovrsina.Entiteti.DecijeIgraliste>()
                                                                         select o;

                foreach (ZelenaPovrsina.Entiteti.DecijeIgraliste r in svaDecijaIgralista)
                {
                    decijaigralista.Add(new DecijeIgralisteBasic(r.Tip, r.BrIgracaka, r.Pesak, r.Starost));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return decijaigralista;
        }

        public static void obrisiDecijeIgraliste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.DecijeIgraliste r = s.Load<ZelenaPovrsina.Entiteti.DecijeIgraliste>(id);

                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static DecijeIgralisteBasic azurirajDecijeIgraliste(DecijeIgralisteBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.DecijeIgraliste o = s.Load<ZelenaPovrsina.Entiteti.DecijeIgraliste>(r.IdO);
                o.BrIgracaka = r.BrIgracaka;
                o.Pesak = r.Pesak;
                o.Starost = r.Starost;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return r;
        }


        #endregion

        #region Fontana

        public static async Task<bool> dodajFontanu(FontanaBasic v, int IdParka)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Fontana d = new Fontana(); //ne znam sta je greska

                    d.BrPrskalica = v.BrPrskalica;
                    d.PovrsinaF = v.PovrsinaF;
                    Park z = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                    d.PripadaParku = z;

                    await s.SaveAsync(d);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }




        #endregion

        #region Klupa

        public static async Task<bool> dodajKlupu(KlupaBasic v, int IdParka)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Klupa d = new Klupa(); //ne znam sta je greska

                    d.RedniBroj = v.RedniBr;
                    d.Tip = v.Tip;
                    d.Materijal = v.Materijal;
                    Park p = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                    d.PripadaParku = p;


                    await s.SaveAsync(d);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }


        #endregion

        #region Skulptura

        public static async Task<bool> dodajSkulpturu(SkulpturaBasic v, int IdZastite, int IdParka)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Skulptura d = new Skulptura(); //opet


                    d.Autor = v.Autor;
                    Zastita z = await s.LoadAsync<Zastita>(IdZastite); //trebalo bi da je tako
                    d.Zastita = z;
                    Park p = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                    d.PripadaParku = p;


                    await s.SaveAsync(d);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }


        #endregion

        #region Spomenik

        public static async Task<bool> dodajSpomenik(SpomenikBasic v, int IdZastite, int IdParka)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Spomenik d = new Spomenik();

                    d.NazivS = v.NazivS;
                    Zastita z = await s.LoadAsync<Zastita>(IdZastite); //trebalo bi da je tako
                    d.Zastita = z;
                    Park p = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                    d.PripadaParku = p;

                    await s.SaveAsync(d);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }



        #endregion

        #region Svetiljka

        public static async Task<bool> dodajSvetiljku(SvetiljkaBasic v, int IdParka)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Svetiljka d = new Svetiljka();

                    d.BrSijalica = v.BrSijalica;
                    Park z = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                    d.PripadaParku = z;

                    await s.SaveAsync(d);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }



        #endregion

        #region Drvo

        public static async Task<bool> dodajDrvo(DrvoBasic v, int IdParka, int IdZastite = 0)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Drvo d = new Drvo();

                    d.RedniBroj = v.RedniBr;
                    d.Tip = v.Tip;
                    d.VisinaKrosnje = v.VisinaKrosnje;
                    d.Vrsta = v.Vrsta;
                    d.DatumSadnje = v.DatumSadnje;
                    d.PovrsinaK = v.PovrsinaK;
                    d.ObimDebla = v.ObimDebla;
                    //pogledati za Zastitu kako, ima ono PodZastitom

                    if (IdZastite != 0) //trebalo bi da se tako radi za zastitu
                    {
                        Zastita z = await s.LoadAsync<Zastita>(IdZastite);
                        d.PodZastitomDrvo = z;
                    }
                    Park p = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                    d.PripadaParku = p;

                    await s.SaveAsync(d);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }



        #endregion

        #region Zastita

        public static async Task<bool> dodajZastitu(ZastitaBasic v)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Zastita d = new Zastita();

                    d.Institucija = v.Institucija;
                    d.DatumOd = v.DatumOd;
                    d.NovcanaSredstva = v.NovcanaSredstva;
                    d.OpisZnacaja = v.OpisZnacaja;

                    await s.SaveAsync(d);
                    await s.FlushAsync();
                    return true;
                }

                throw new Exception("Greska pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                s?.Close();
            }
        }



        #endregion
    }
}
