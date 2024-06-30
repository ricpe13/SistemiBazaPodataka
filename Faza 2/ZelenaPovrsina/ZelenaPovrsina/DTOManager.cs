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

        public static async Task<RadnikPregled> vratiRadnika(int id)
        {
            RadnikPregled db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Radnik d = await session.LoadAsync<Radnik>(id);
                    db = new RadnikPregled(d.IdR, d.Ime, d.Prezime, d.Jmbg, d.Adresa, d.BrRadneKnjizice, d.ImeRoditelja, d.StrucnaSprema, d.DatumRodj, d.ZaZelenilo, d.ZaHigijenu, d.ZaObjekat);
                    // fali za zelenu povrsinu i grupu, a ako se koristi Pregled onda nema errora
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

            return db;
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

        public static async Task<RadnikBasic?> azurirajRadnika(RadnikBasic? r)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null && r != null)
                {
                    Radnik o = await session.LoadAsync<Radnik>(r.IdR);
                    o.Adresa = r.Adresa;
                    o.StrucnaSprema = r.StrucnaSprema;
                    o.ZaZelenilo = r.ZaZelenilo;
                    o.ZaHigijenu = r.ZaHigijenu;
                    o.ZaObjekat = r.ZaObjekat;
                    //treba i za izmenu Id zelene povrsine, ali ne znam kako

                    await session.UpdateAsync(o);
                    await session.FlushAsync();
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

        public static async Task<ParkBasic> vratiPark(int id)
        {
            ParkBasic db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Park d = await session.LoadAsync<Park>(id);
                    db = new ParkBasic(d.IdZ, d.NazivGradskeOpstine, d.ZonaUgrozenosti, d.TipZ, d.NazivP, d.PovrsinaP);
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

            return db;
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


        public static async Task<GrupaRadnikaBasic?> azurirajGrupuRadnika(GrupaRadnikaBasic? r)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null && r != null)
                {
                    GrupaRadnika o = await session.LoadAsync<GrupaRadnika>(r.IdG);
                    o.NazivG = r.NazivG;

                    await session.UpdateAsync(o);
                    await session.FlushAsync();
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

            return r;
        }


        public static List<GrupaRadnikaPregled> vratiSveGrupeRadnika()
        {
            List<GrupaRadnikaPregled> grupeRadnika = [];
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    IEnumerable<GrupaRadnika> sveGrupeRadnika =
                        from o in session.Query<GrupaRadnika>()
                        select o;

                    foreach (GrupaRadnika t in sveGrupeRadnika)
                    {
                        grupeRadnika.Add(new GrupaRadnikaPregled(t.IdG, t.NazivG));
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

            return grupeRadnika;
        }

        public static async Task<GrupaRadnikaBasic> vratiGrupuRadnika(int id)
        {
            GrupaRadnikaBasic db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    GrupaRadnika d = await session.LoadAsync<GrupaRadnika>(id);
                    db = new GrupaRadnikaBasic(d.IdG, d.NazivG);
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

            return db;
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


        public static async Task<TravnjakBasic> vratiTravnjak(int id)
        {
            TravnjakBasic db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Travnjak d = await session.LoadAsync<Travnjak>(id);
                    db = new TravnjakBasic(d.IdZ, d.NazivGradskeOpstine, d.ZonaUgrozenosti, d.TipZ, d.AdresaZgrade, d.PovrsinaT);
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

            return db;
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


        public static async Task<DrvoredBasic?> azurirajDrvored(DrvoredBasic? r)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null && r != null)
                {
                    Drvored o = await session.LoadAsync<Drvored>(r.Id);
                    o.VrstaDrveta = r.VrstaDrveta;
                    o.BrojStabala = r.BrojStabala;

                    await session.UpdateAsync(o);
                    await session.FlushAsync();
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

            return r;
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

        public static async Task<DrvoredBasic> vratiDrvored(int id)
        {
            DrvoredBasic db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Drvored d = await session.LoadAsync<Drvored>(id);
                    db = new DrvoredBasic(d.IdZ, d.NazivGradskeOpstine, d.ZonaUgrozenosti, d.TipZ, d.Ulica, d.Duzina, d.VrstaDrveta, d.BrojStabala);
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

            return db;
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
                    DecijeIgraliste o = new DecijeIgraliste();
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
                        decijaIgralista.Add(new DecijeIgralistePregled(r.Id, r.RedniBroj, r.PripadaParku.IdZ, r.Tip, r.BrIgracaka, r.Pesak, r.Starost));
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


        public static async Task<DecijeIgralisteBasic?> azurirajDecijeIgraliste(DecijeIgralisteBasic? r)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null && r != null)
                {
                    DecijeIgraliste o = await session.LoadAsync<DecijeIgraliste>(r.IdO);
                    o.BrIgracaka = r.BrIgracaka;
                    o.Pesak = r.Pesak;
                    o.Starost = r.Starost;

                    await session.UpdateAsync(o);
                    await session.FlushAsync();
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

            return r;
        }


        public static async Task<DecijeIgralistePregled> vratiDecijeIgraliste(int id)
        {
            DecijeIgralistePregled db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    DecijeIgraliste d = await session.LoadAsync<DecijeIgraliste>(id);
                    db = new DecijeIgralistePregled(d.Id, d.PripadaParku?.IdZ, d.RedniBroj, d.Tip, d.BrIgracaka, d.Pesak, d.Starost);
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

            return db;
        }


        #endregion

        #region Fontana

        public static async Task<bool> dodajFontanu(FontanaBasic v)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Park z = await s.LoadAsync<Park>(v.PripadaParku?.Id);
                    Fontana d = new Fontana();

                    d.BrPrskalica = v.BrPrskalica;
                    d.PovrsinaF = v.PovrsinaF;
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


        public static async Task<FontanaBasic?> azurirajFontanu(FontanaBasic? r)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null && r != null)
                {
                    Fontana o = await session.LoadAsync<Fontana>(r.IdO);
                    o.BrPrskalica = r.BrPrskalica;

                    await session.UpdateAsync(o);
                    await session.FlushAsync();
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

            return r;
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
                        fontane.Add(new FontanaPregled(t.Id, t.PripadaParku?.IdZ, t.RedniBroj, t.Tip, t.BrPrskalica, t.PovrsinaF));
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

        public static async Task<FontanaPregled> vratiFontanu(int id)
        {
            FontanaPregled db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Fontana d = await session.LoadAsync<Fontana>(id);
                    db = new FontanaPregled(d.Id, d.PripadaParku?.IdZ, d.RedniBroj, d.Tip, d.BrPrskalica, d.PovrsinaF);
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

            return db;
        }


        #endregion

        #region Klupa

        public static async Task<bool> dodajKlupu(KlupaBasic v)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Park p = await s.LoadAsync<Park>(v.PripadaParku?.Id);
                    Klupa d = new Klupa()
                    { Materijal = v.Materijal };
                    d.RedniBroj = v.RedniBr;
                    d.Tip = v.Tip;
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
                        klupe.Add(new KlupaPregled(t.Id, t.PripadaParku?.IdZ, t.RedniBroj, t.Tip, t.Materijal));
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


        public static async Task<KlupaPregled> vratiKlupu(int id)
        {
            KlupaPregled db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Klupa d = await session.LoadAsync<Klupa>(id);
                    db = new KlupaPregled(d.Id, d.PripadaParku?.IdZ, d.RedniBroj, d.Tip, d.Materijal);
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

            return db;
        }


        #endregion

        #region Skulptura

        public static async Task<bool> dodajSkulpturu(SkulpturaBasic v)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Zastita z = await s.LoadAsync<Zastita>(v.Zastita.IdZastite);
                    Park p = await s.LoadAsync<Park>(v.PripadaParku?.Id);
                    Skulptura d = new Skulptura()
                    { Autor = v.Autor, Zastita = z }; 

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
                        skulpture.Add(new SkulpturaPregled(t.Id, t.PripadaParku?.IdZ, t.RedniBroj, t.Tip, t.Autor)); //fali za Zastitu ali ne znam
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


        public static async Task<SkulpturaPregled> vratiSkulpturu(int id)
        {
            SkulpturaPregled db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Skulptura d = await session.LoadAsync<Skulptura>(id);
                    db = new SkulpturaPregled(d.Id, d.PripadaParku.IdZ, d.RedniBroj, d.Tip, d.Autor); //fali za Zastitu, ali nemamo je ni u DTOs u SkulpturaPrelged
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

            return db;
        }


        #endregion

        #region Spomenik

        public static async Task<bool> dodajSpomenik(SpomenikBasic v)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Zastita z = await s.LoadAsync<Zastita>(v.Zastita.IdZastite);
                    Park p = await s.LoadAsync<Park>(v.PripadaParku?.Id);
                    Spomenik d = new Spomenik()
                    { NazivS = v.NazivS };

                    d.Zastita = z;
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
                        spomenici.Add(new SpomenikPregled(t.Id, t.PripadaParku.IdZ, t.RedniBroj, t.Tip, t.NazivS)); //nema ono za Zastita
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

        public static async Task<SpomenikPregled> vratiSpomenik(int id)
        {
            SpomenikPregled db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Spomenik d = await session.LoadAsync<Spomenik>(id);
                    db = new SpomenikPregled(d.Id, d.PripadaParku?.IdZ, d.RedniBroj, d.Tip, d.NazivS); //nema ono za Zastita
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

            return db;
        }



        #endregion

        #region Svetiljka

        public static async Task<bool> dodajSvetiljku(SvetiljkaBasic v)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Park z = await s.LoadAsync<Park>(v.PripadaParku?.Id);
                    Svetiljka d = new Svetiljka()
                    { BrSijalica = v.BrSijalica};

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

        public static async Task<SvetiljkaBasic?> azurirajSvetiljku(SvetiljkaBasic? r)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null && r != null)
                {
                    Svetiljka o = await session.LoadAsync<Svetiljka>(r.IdO);
                    o.BrSijalica = r.BrSijalica;

                    await session.UpdateAsync(o);
                    await session.FlushAsync();
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

            return r;
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
                        svetiljke.Add(new SvetiljkaPregled(t.Id, t.PripadaParku?.IdZ, t.RedniBroj, t.Tip, t.BrSijalica));
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


        public static async Task<SvetiljkaPregled> vratiSvetiljku(int id)
        {
            SvetiljkaPregled db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Svetiljka d = await session.LoadAsync<Svetiljka>(id);
                    db = new SvetiljkaPregled(d.Id, d.PripadaParku?.IdZ, d.RedniBroj, d.Tip, d.BrSijalica);
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

            return db;
        }

        #endregion

        #region Drvo

        public static async Task<bool> dodajDrvo(DrvoBasic v, int IdZastite = 0)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (s != null)
                {
                    Park p = await s.LoadAsync<Park>(v.PripadaParku?.Id);
                    Zastita z = await s.LoadAsync<Zastita>(v.Zastita.IdZastite);
                    Drvo d = new Drvo();

                    d.RedniBroj = v.RedniBr;
                    d.Tip = v.Tip;
                    d.VisinaKrosnje = v.VisinaKrosnje;
                    d.Vrsta = v.Vrsta;
                    d.DatumSadnje = v.DatumSadnje;
                    d.PovrsinaK = v.PovrsinaK;
                    d.ObimDebla = v.ObimDebla;

                    d.PodZastitomDrvo = z;
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

        public static async Task<DrvoBasic?> azurirajDrvo(DrvoBasic? r)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null && r != null)
                {
                    Drvo o = await session.LoadAsync<Drvo>(r.IdO);
                    o.VisinaKrosnje = r.VisinaKrosnje;
                    o.PovrsinaK = r.PovrsinaK;
                    o.ObimDebla = r.ObimDebla;

                    await session.UpdateAsync(o);
                    await session.FlushAsync();
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

            return r;
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
                        drvece.Add(new DrvoPregled(t.Id, t.PripadaParku.IdZ, t.RedniBroj, t.Tip, t.VisinaKrosnje, t.Vrsta, t.DatumSadnje, t.PovrsinaK, t.ObimDebla)); //nema za PripadaParku i fali za Zastitu ali ne znam
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

        public static async Task<DrvoPregled> vratiDrvo(int id)
        {
            DrvoPregled db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Drvo d = await session.LoadAsync<Drvo>(id);
                    db = new DrvoPregled(d.Id, d.RedniBroj, d.PripadaParku.IdZ, d.Tip, d.VisinaKrosnje, d.Vrsta, d.DatumSadnje, d.PovrsinaK, d.ObimDebla); //nema ono za PripadaParku i Zastita
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

            return db;
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

        public static async Task<ZastitaBasic> vratiZastitu(int id)
        {
            ZastitaBasic db = new();
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Zastita d = await session.LoadAsync<Zastita>(id);
                    db = new ZastitaBasic(d.IdZastite, d.Institucija, d.DatumOd, d.NovcanaSredstva, d.OpisZnacaja);
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

            return db;
        }


        #endregion
    }
}
