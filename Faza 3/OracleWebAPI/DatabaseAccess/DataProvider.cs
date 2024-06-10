using DatabaseAccess.Entiteti;

namespace DatabaseAccess
{
    public static class DataProvider
    {
        #region Radnik
        public async static Task<Result<bool, ErrorMessage>> dodajRadnika(RadnikPregled r)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Radnik o = new()
                {
                    Ime = r.Ime,
                    Prezime = r.Prezime,
                    Jmbg = r.Jmbg,
                    Adresa = r.Adresa,
                    BrRadneKnjizice = r.BrRadneKnjizice,
                    ImeRoditelja = r.ImeRoditelja,
                    StrucnaSprema = r.StrucnaSprema,
                    DatumRodj = r.DatumRodj,
                    ZaZelenilo = r.ZaZelenilo,
                    ZaHigijenu = r.ZaHigijenu,
                    ZaObjekat = r.ZaObjekat,
                };

                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguće dodati radnika.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<RadnikPregled>, ErrorMessage> vratiSveRadnike()
        {

            List<RadnikPregled> radnici = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Radnik> sviRadnici = from o in s.Query<Entiteti.Radnik>()
                                                                            select o;

                foreach (Entiteti.Radnik r in sviRadnici)
                {
                    radnici.Add(new RadnikPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o radnicima.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return radnici;
        }


        public static async Task<Result<RadnikPregled, ErrorMessage>> vratiRadnika(int id)
        {
            RadnikPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Radnik p = await s.LoadAsync<Entiteti.Radnik>(id);
                pp = new RadnikPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o odeljenjima.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }


        public async static Task<Result<bool, ErrorMessage>> obrisiRadnika(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Radnik o = await s.LoadAsync<Radnik>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati radnika.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
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

        public async static Task<Result<bool, ErrorMessage>> dodajPark(ParkPregled park)
        {
            ISession? s = null;
            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Park o = new()
                {
                    NazivGradskeOpstine = park.NazivGradskeOpstine,
                    ZonaUgrozenosti = park.ZonaUgrozenosti,
                    TipZ = park.TipZ,//ovo proveriti
                    NazivP = park.NazivP,
                    PovrsinaP = park.PovrsinaP
                };

                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguće dodati park.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiPark(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Park o = await s.LoadAsync<Park>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati park.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<ParkPregled>, ErrorMessage> vratiSveParkove()
        {
            List<ParkPregled> parkovi = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Park> sviParkovi = from o in s.Query<Entiteti.Park>()
                                                                         select o;

                foreach (Entiteti.Park r in sviParkovi)
                {
                    parkovi.Add(new ParkPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o parkovima.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return parkovi;
        }

        public static async Task <Result<ParkPregled, ErrorMessage>> vratiPark(int id)
        {
            ParkPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Park p = await s.LoadAsync<Entiteti.Park>(id);
                pp = new ParkPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o parku.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        #endregion

        #region GrupaRadnika

        public async static Task<Result<bool, ErrorMessage>> dodajGrupuRadnika(GrupaRadnikaPregled grupaRadnika)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                GrupaRadnika o = new()
                {
                    NazivG = grupaRadnika.NazivG,
                };
                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguće dodati prodavnicu.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisigrupu(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                GrupaRadnika o = await s.LoadAsync<GrupaRadnika>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati grupu radnika.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }



        public static Result<List<GrupaRadnikaPregled>, ErrorMessage> vratiSveGrupe()
        {
            List<GrupaRadnikaPregled> grupa = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<GrupaRadnika> grupe = from o in s.Query<Entiteti.GrupaRadnika>()
                                            select o;
                foreach (GrupaRadnika g in grupe)
                {
                    
                    grupa.Add(new GrupaRadnikaPregled(g));
                }
            }

            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o grupama radnika.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return grupa;
        }

        public static async Task <Result<GrupaRadnikaPregled, ErrorMessage>> vratiGrupu(int id)
        {
            GrupaRadnikaPregled pb = new ();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.GrupaRadnika p = await s.LoadAsync<Entiteti.GrupaRadnika>(id);
                pb = new GrupaRadnikaPregled(p);

               
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o grupi radnika.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pb;
        }

        #endregion


        #region Travnjak

        public async static Task<Result<bool, ErrorMessage>> dodajTravnjak(TravnjakPregled travnjak)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Travnjak o = new()
                {
                    NazivGradskeOpstine = travnjak.NazivGradskeOpstine,
                    ZonaUgrozenosti = travnjak.ZonaUgrozenosti,
                    TipZ = travnjak.TipZ,
                    AdresaZgrade = travnjak.AdresaZgrade,
                    PovrsinaT = travnjak.PovrsinaT,
                };

                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguće dodati travnjak.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiTravnnjak(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Travnjak o = await s.LoadAsync<Travnjak>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati travnjak.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }


        public static Result<List<TravnjakPregled>, ErrorMessage> vratiSveTravnjake()
        {
            List<TravnjakPregled> travnjaci = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Travnjak> sviTravnjaci = from o in s.Query<Entiteti.Travnjak>()
                                                                         select o;

                foreach (Entiteti.Travnjak r in sviTravnjaci)
                {
                    travnjaci.Add(new TravnjakPregled(r));
                }
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o travnjacima.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return travnjaci;
        }

        public static async Task<Result<TravnjakPregled, ErrorMessage>> vratiTravnjak(int id)
        {
            TravnjakPregled pb = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Travnjak p = await s.LoadAsync<Entiteti.Travnjak>(id);
                pb = new TravnjakPregled(p);


            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o travnjaku.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pb;
        }


        #endregion


        #region Drvored

        public async static Task<Result<bool, ErrorMessage>> dodajDrvored(DrvoredPregled drvored)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Drvored d = new()
                {
                    NazivGradskeOpstine = drvored.NazivGradskeOpstine,
                    ZonaUgrozenosti = drvored.ZonaUgrozenosti,
                    TipZ = drvored.TipZ,
                    Ulica = drvored.Ulica,
                    Duzina = drvored.Duzina,
                    VrstaDrveta = drvored.VrstaDrveta,
                };

                await s.SaveOrUpdateAsync(d);
                await s.FlushAsync();

            }
            catch (Exception)
            {
                return GetError("Nemoguće dodati drvored.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }



        public async static Task<Result<bool, ErrorMessage>> obrisiDrvored(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Drvored o = await s.LoadAsync<Drvored>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati drvored.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
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


            public static Result<List<DrvoredPregled>, ErrorMessage> vratiSveDrvorede()
            {
                List<DrvoredPregled> drvoredi = new();
                ISession? s = null;
            try
                {
                    s = DataLayer.GetSession();

                    if (!(s?.IsConnected ?? false))
                    {
                        return "Nemoguće otvoriti sesiju.".ToError(403);
                    }

                    IEnumerable<Entiteti.Drvored> sviDrvoredi = from o in s.Query<Entiteti.Drvored>()
                                                                           select o;

                    foreach (Entiteti.Drvored r in sviDrvoredi)
                    {
                        drvoredi.Add(new DrvoredPregled(r));
                    }

                }
                catch (Exception)
                {
                    return "Došlo je do greške prilikom prikupljanja informacija o drvoredima.".ToError(400);
                }
                finally
                {
                    s?.Close();
                    s?.Dispose();
                }

                return drvoredi;
            }

            public static async Task<Result<DrvoredPregled, ErrorMessage>> vratiDrvored(int id)
            {
                DrvoredPregled pb = new();
                ISession? s = null;

                try
                {
                    s = DataLayer.GetSession();

                    if (!(s?.IsConnected ?? false))
                    {
                        return "Nemoguće otvoriti sesiju.".ToError(403);
                    }

                    Entiteti.Drvored p = await s.LoadAsync<Entiteti.Drvored>(id);
                    pb = new DrvoredPregled(p);


                }
                catch (Exception)
                {
                    return "Došlo je do greške prilikom prikupljanja informacija o drvoredu.".ToError(400);
                }
                finally
                {
                    s?.Close();
                    s?.Dispose();
                }

                return pb;
            }


        #endregion
    }
}
