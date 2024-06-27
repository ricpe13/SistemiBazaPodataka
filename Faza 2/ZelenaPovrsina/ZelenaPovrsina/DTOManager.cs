using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenaPovrsina.Entiteti;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            List<RadnikPregled> radnici = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Radnik> sviRadnici =
                    from o in session.Query<Radnik>()
                        select o;

                    foreach (Radnik r in sviRadnici)
                    {
                        radnici.Add(new RadnikPregled(r.IdR, r.Ime, r.Prezime, r.Jmbg, r.Adresa, r.BrRadneKnjizice, r.ImeRoditelja,
                        r.StrucnaSprema, r.DatumRodj, r.ZaZelenilo, r.ZaHigijenu, r.ZaObjekat));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return radnici;
        }

        public static async Task<bool> obrisiRadnika(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Radnik a = await session.LoadAsync<Radnik>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali radnika");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete radnika");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
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

        public static async Task<bool> obrisiPark(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Park a = await session.LoadAsync<Park>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali park");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete park!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static List<ParkPregled> vratiSveParkove()
        {
            List<ParkPregled> parkovi = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Park> sviParkovi =
                        from o in session.Query<Park>()
                        select o;

                    foreach (Park r in sviParkovi)
                    {
                        parkovi.Add(new ParkPregled(r.IdZ, r.NazivGradskeOpstine, r.ZonaUgrozenosti, r.TipZ, r.NazivP, r.PovrsinaP));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
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


        public static async Task<bool> obrisiGrupuRadnika(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    GrupaRadnika a = await session.LoadAsync<GrupaRadnika>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali grupu radnika");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete grupu radnika!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }


        //public static List<GrupaRadnikaPregled> vratiSveGrupe()
        //{
        //    List<GrupaRadnikaPregled> grupeRadnika = [];
        //    ISession? session = null;

        //    try
        //    {
        //        session = DataLayer.GetSession();

        //        if (session != null)
        //        {
        //            IEnumerable<GrupaRadnika> sveGrupeRadnika =
        //                from o in session.Query<GrupaRadnika>()
        //                select o;

        //            foreach (GrupaRadnika t in sveGrupeRadnika)
        //            {
        //                GrupaRadnikaBasic grupa = DTOManager.vratiGrupu(g.IdG);
        //                grupeRadnika.Add(grupa);
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.FormatExceptionMessage());
        //    }
        //    finally
        //    {
        //        session?.Close();
        //    }

        //    return grupeRadnika;
        //}

        //nesto nije dobro ovo vratiSveGrupe



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


        public static async Task<bool> obrisiTravnjak(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Travnjak a = await session.LoadAsync<Travnjak>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali travnjak");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete travnjak!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static List<TravnjakPregled> vratiSveTravnjake()
        {
            List<TravnjakPregled> travnjaci = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Travnjak> sviTravnjaci =
                        from o in session.Query<Travnjak>()
                        select o;

                    foreach (Travnjak r in sviTravnjaci)
                    {
                        travnjaci.Add(new TravnjakPregled(r.IdZ, r.NazivGradskeOpstine, r.ZonaUgrozenosti, r.TipZ, r.AdresaZgrade, r.PovrsinaT));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
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


        public static async Task<bool> obrisiDrvored(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Drvored a = await session.LoadAsync<Drvored>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali drvored");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete drvored!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
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
                List<DrvoredPregled> drvoredi = [];
                ISession? session = null;

                try
                {
                    session = DataLayer.GetSession();

                    if (session != null)
                    {
                        IEnumerable<Drvored> sviDrvoredi =
                            from o in session.Query<Drvored>()
                            select o;

                        foreach (Drvored r in sviDrvoredi)
                        {
                            drvoredi.Add(new DrvoredPregled(r.IdZ, r.NazivGradskeOpstine, r.ZonaUgrozenosti, r.TipZ, r.Ulica, r.Duzina, r.VrstaDrveta, r.BrojStabala));
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.FormatExceptionMessage());
                }
                finally
                {
                    session?.Close();
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

        public static List<DecijeIgralistePregled> vratiSvaDecijaIgralista()
        {
            List<DecijeIgralistePregled> decijaIgralista = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<DecijeIgraliste> svaDecijaIgralista =
                        from o in session.Query<DecijeIgraliste>()
                        select o;

                    foreach (DecijeIgraliste r in svaDecijaIgralista)
                    {
                        decijaIgralista.Add(new DecijeIgralistePregled(r.Tip, r.BrIgracaka, r.Pesak, r.Starost)); //ne znam zasto ima gresku
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return decijaIgralista;
        }


        public static async Task<bool> obrisiDecijeIgraliste(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    DecijeIgraliste a = await session.LoadAsync<DecijeIgraliste>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali decije igraliste");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete decije igraliste!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
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


        public static async Task<bool> obrisiFontanu(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Fontana a = await session.LoadAsync<Fontana>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali fontanu");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete fontanu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }



        public static List<FontanaPregled> vratiSveFontane()
        {
            List<FontanaPregled> fontane = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Fontana> sveFontane =
                        from o in session.Query<Fontana>()
                        select o;

                    foreach (Fontana t in sveFontane)
                    {
                        fontane.Add(new FontanaPregled(t.Id, t.RedniBroj, t.Tip, t.BrPrskalica, t.PovrsinaF)); //nema ono za PripadaParku
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return fontane;
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

        public static async Task<bool> obrisiKlupu(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Klupa a = await session.LoadAsync<Klupa>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali klupu");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete klupu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }




        public static List<KlupaPregled> vratiSveKlupe()
        {
            List<KlupaPregled> klupe = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Klupa> sveKlupe =
                        from o in session.Query<Klupa>()
                        select o;

                    foreach (Klupa t in sveKlupe)
                    {
                        klupe.Add(new KlupaPregled(t.Id, t.RedniBroj, t.Tip, t.Materijal)); //nema ono za PripadaParku
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return klupe;
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

        public static async Task<bool> obrisiSkulpturu(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Skulptura a = await session.LoadAsync<Skulptura>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali skulpturu");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete skulpturu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }



        public static List<SkulpturaPregled> vratiSveSkulpture()
        {
            List<SkulpturaPregled> skulpture = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Skulptura> sveSkulpture =
                        from o in session.Query<Skulptura>()
                        select o;

                    foreach (Skulptura t in sveSkulpture)
                    {
                        skulpture.Add(new SkulpturaPregled(t.Id, t.RedniBroj, t.Tip, t.Autor)); //nema za PripadaParku i fali za Zastitu ali ne znam
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return skulpture;
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

        public static async Task<bool> obrisiSpomenik(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Spomenik a = await session.LoadAsync<Spomenik>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali spomenik");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete spomenik!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }



        public static List<SpomenikPregled> vratiSveSpomenike()
        {
            List<SpomenikPregled> spomenici = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Spomenik> sviSpomenici =
                        from o in session.Query<Spomenik>()
                        select o;

                    foreach (Spomenik t in sviSpomenici)
                    {
                        spomenici.Add(new SpomenikPregled(t.Id, t.RedniBroj, t.Tip, t.NazivS)); //nema ono za PripadaParku i Zastita
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return spomenici;
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

        public static async Task<bool> obrisiSvetiljku(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Svetiljka a = await session.LoadAsync<Svetiljka>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali svetiljku");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete svetiljku!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }



        public static List<SvetiljkaPregled> vratiSveSvetiljke()
        {
            List<SvetiljkaPregled> svetiljke = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Svetiljka> sveSvetiljke =
                        from o in session.Query<Svetiljka>()
                        select o;

                    foreach (Svetiljka t in sveSvetiljke)
                    {
                        svetiljke.Add(new SkulpturaPregled(t.Id, t.RedniBroj, t.Tip, t.BrSijalica)); //nema za PripadaParku i ne znam gresku
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return svetiljke;
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
                    Drvo d = new Drvo(); //neka greska

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

        public static async Task<bool> obrisiDrvo(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Drvo a = await session.LoadAsync<Drvo>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali drvo");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete drvo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }


        public static List<DrvoPregled> vratiSvaDrveca()
        {
            List<DrvoPregled> drvece = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Drvo> svaDrveca =
                        from o in session.Query<Drvo>()
                        select o;

                    foreach (Drvo t in svaDrveca)
                    {
                        drvece.Add(new DrvoPregled(t.Id, t.RedniBroj, t.Tip, t.VisinaKrosnje, t.Vrsta, t.DatumSadnje, t.PovrsinaK, t.ObimDebla)); //nema za PripadaParku i fali za Zastitu ali ne znam
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return drvece;
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

        public static async Task<bool> obrisiZastitu(int id)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Zastita a = await session.LoadAsync<Zastita>(id);

                    await session.DeleteAsync(a);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno ste obrisali zastitu");
                    return true;
                }
                throw new Exception("Niste uspeli da obrisete zastitu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static List<ZastitaPregled> vratiSveZastite()
        {
            List<ZastitaPregled> zastite = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<Zastita> sveZastite =
                        from o in session.Query<Zastita>()
                        select o;

                    foreach (Zastita t in sveZastite)
                    {
                        zastite.Add(new ZastitaPregled(t.IdZastite, t.Institucija, t.DatumOd, t.NovcanaSredstva, t.OpisZnacaja));  
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

            return zastite;
        }

        #endregion
    }
}
