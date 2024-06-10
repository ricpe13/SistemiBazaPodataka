namespace DatabaseAccess
{
    public static class DataProvider
    {
        #region Radnik
        public async static Task<Result<bool, ErrorMessage>> dodajRadnika(RadnikPregled r, int IdGR=0, int IdZP)
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
                ZelenaPovrsina z = await s.LoadAsync<ZelenaPovrsina>(IdZP); //trebalo bi da je tako
                o.AngazovanZaZP = z;

                if (IdGR != 0) //trebalo bi da se tako radi za zastitu
                {
                    GrupaRadnika g = await s.LoadAsync<GrupaRadnika>(IdGR);
                    o.PripadaGrupi = g;
                }

                await s.SaveAsync(o);
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
                return "Došlo je do greške prilikom prikupljanja informacija o radniku.".ToError(400);
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

        public async static Task<Result<RadnikPregled, ErrorMessage>> azurirajRadnika(RadnikPregled p)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Radnik o = s.Load<Radnik>(p.IdR);
                o.Adresa = p.Adresa;
                o.StrucnaSprema = p.StrucnaSprema;
                o.ZaZelenilo = p.ZaZelenilo;
                o.ZaHigijenu = p.ZaHigijenu;
                o.ZaObjekat = p.ZaObjekat;
                //treba i za izzmenu id zelene povrsine ali ne znamo kako, nismo nznnali ni za 2. deo

                await s.UpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguce azurirati radnika.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return p;
        }




        #endregion

        #region Park

        public async static Task<Result<bool, ErrorMessage>> dodajPark(ParkPregled park, int IdGR)
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
                    TipZ = park.TipZ,
                    NazivP = park.NazivP,
                    PovrsinaP = park.PovrsinaP
                };
                GrupaRadnika z = await s.LoadAsync<GrupaRadnika>(IdGR); //trebalo bi da je tako
                o.GrupaRadnika = z;

                await s.SaveAsync(o);
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

        public async static Task<Result<bool, ErrorMessage>> dodajGrupuRadnika(GrupaRadnikaPregled grupaRadnika, int IdParka, int IdSefa)
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
                Park z = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                o.Park = z;
                Sef ss = await s.LoadAsync<Sef>(IdSefa); //trebalo bi da je tako
                o.Sef = ss;

                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguće dodati grupu radnika.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiGrupuRadnika(int id)
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


        public async static Task<Result<GrupaRadnikaPregled, ErrorMessage>> azurirajGrupuRadnika(GrupaRadnikaPregled p)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                GrupaRadnika o = s.Load<GrupaRadnika>(p.IdG);
                o.NazivG = p.NazivG;

                await s.UpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguce azurirati grupu radnika.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return p;
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

                await s.SaveAsync(o);
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

                await s.SaveAsync(d);
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


        public async static Task<Result<DrvoredPregled, ErrorMessage>> azurirajDrvored(DrvoredPregled p)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Drvored o = s.Load<Drvored>(p.IdZ);
                o.VrstaDrveta = p.VrstaDrveta;
                o.BrojStabala = p.BrojStabala;

                await s.UpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguce zurirati drvored.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return p;
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


        #region DecijeIgraliste

        public async static Task<Result<bool, ErrorMessage>> dodajDecijeIgraliste(DecijeIgralistePregled r)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                DecijeIgraliste o = new()
                {
                    Tip = r.Tip,
                    BrIgracaka = r.BrIgracaka,
                    Pesak = r.Pesak,
                    Starost = r.Starost,
                };

                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguce dodati decije igraliste.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<DecijeIgralistePregled>, ErrorMessage> vratiSvaDecijaIgralista()
        {

            List<DecijeIgralistePregled> decijaigralista = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.DecijeIgraliste> svaDecijaIgralista = from o in s.Query<Entiteti.DecijeIgraliste>()
                                                          select o;

                foreach (Entiteti.DecijeIgraliste r in svaDecijaIgralista)
                {
                    decijaigralista.Add(new DecijeIgralistePregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o decijim igralistima.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return decijaigralista;
        }


        public static async Task<Result<DecijeIgralistePregled, ErrorMessage>> vratiDecijeIgraliste(int id)
        {
            DecijeIgralistePregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.DecijeIgraliste p = await s.LoadAsync<Entiteti.DecijeIgraliste>(id);
                pp = new DecijeIgralistePregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o decijem igralistu.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiDecijeIgraliste(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                DecijeIgraliste o = await s.LoadAsync<DecijeIgraliste>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati decije igraliste.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public async static Task<Result<DecijeIgralistePregled, ErrorMessage>> azurirajDecijeIgraliste(DecijeIgralistePregled p)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                DecijeIgraliste o = s.Load<DecijeIgraliste>(p.IdO);
                o.BrIgracaka = p.BrIgracaka;
                o.Pesak = p.Pesak;
                o.Starost = p.Starost;

                await s.UpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguce azurirati decije igraliste.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return p;
        }

        #endregion


        #region Fontana

        public async static Task<Result<bool, ErrorMessage>> dodajFontanu(FontanaPregled r, int IdParka)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Fontana o = new()
                {
                    Tip = r.Tip,
                    BrPrskalica = r.BrPrskalica,
                    PovrsinaF = r.PovrsinaF,
                };
                Park z = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                o.PripadaParku = z;

                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguce dodati fontanu.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<FontanaPregled>, ErrorMessage> vratiSveFontane()
        {

            List<FontanaPregled> fontane = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Fontana> sveFontane = from o in s.Query<Entiteti.Fontana>()
                                                                           select o;

                foreach (Entiteti.Fontana r in sveFontane)
                {
                    fontane.Add(new FontanaPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o fontanama.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return fontane;
        }


        public static async Task<Result<FontanaPregled, ErrorMessage>> vratiFontanu(int id)
        {
            FontanaPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Fontana p = await s.LoadAsync<Entiteti.Fontana>(id);
                pp = new FontanaPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o fontani.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiFontanu(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Fontana o = await s.LoadAsync<Fontana>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati fontanu.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public async static Task<Result<FontanaPregled, ErrorMessage>> azurirajFontanu(FontanaPregled p)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Fontana o = s.Load<Fontana>(p.IdO);
                o.BrPrskalica = p.BrPrskalica;
                

                await s.UpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguce azurirati fontanu.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return p;
        }




        #endregion


        #region Klupa

        public async static Task<Result<bool, ErrorMessage>> dodajKlupu(KlupaPregled r, int IdParka)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Klupa o = new()
                {
                    Tip = r.Tip,
                    Materijal = r.Materijal,
                };
                Park z = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                o.PripadaParku = z;

                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguce dodati klupu.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<KlupaPregled>, ErrorMessage> vratiSveKlupe()
        {

            List<KlupaPregled> klupe = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Klupa> sveKlupe = from o in s.Query<Entiteti.Klupa>()
                                                                           select o;

                foreach (Entiteti.Klupa r in sveKlupe)
                {
                    klupe.Add(new KlupaPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o klupama.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return klupe;
        }


        public static async Task<Result<KlupaPregled, ErrorMessage>> vratiKlupu(int id)
        {
            KlupaPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Klupa p = await s.LoadAsync<Entiteti.Klupa>(id);
                pp = new KlupaPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o klupi.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiKlupu (int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Klupa o = await s.LoadAsync<Klupa>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati klupu.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }


        #endregion

        #region Skuptura

        public async static Task<Result<bool, ErrorMessage>> dodajSkulpturu(SkulpturaPregled r, int IdZastite, int IdParka)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Skulptura o = new()
                {
                    Tip = r.Tip,
                    Autor = r.Autor,
                    
                };
                Zastita z = await s.LoadAsync<Zastita>(IdZastite); //trebalo bi da je tako
                o.Zastita = z;
                Park p = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                o.PripadaParku = p;




                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguce dodati skulpturu.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<SkulpturaPregled>, ErrorMessage> vratiSveSkulpture()
        {

            List<SkulpturaPregled> skulpture = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Skulptura> sveSkulpture = from o in s.Query<Entiteti.Skulptura>()
                                                                           select o;

                foreach (Entiteti.Skulptura r in sveSkulpture)
                {
                    skulpture.Add(new SkulpturaPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o skulpturama.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return skulpture;
        }


        public static async Task<Result<SkulpturaPregled, ErrorMessage>> vratiSkulpturu(int id)
        {
            SkulpturaPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Skulptura p = await s.LoadAsync<Entiteti.Skulptura>(id);
                pp = new SkulpturaPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o skulpturi.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiSkulpturu(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguce otvoriti sesiju.".ToError(403);
                }

                Skulptura o = await s.LoadAsync<Skulptura>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati skulpturu.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        #endregion

        #region Spomenik

        public async static Task<Result<bool, ErrorMessage>> dodajSpomenik(SpomenikPregled r, int IdZastite, int IdParka)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Spomenik o = new()
                {
                    Tip = r.Tip,
                    NazivS = r.NazivS,
                    
                };
                Zastita z = await s.LoadAsync<Zastita>(IdZastite); //trebalo bi da je tako
                o.Zastita = z;
                Park p = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                o.PripadaParku = p;

                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguce dodati spomenik.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<SpomenikPregled>, ErrorMessage> vratiSveSpomenike()
        {

            List<SpomenikPregled> spomenici = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Spomenik> sviSpomenici = from o in s.Query<Entiteti.Spomenik>()
                                                                           select o;

                foreach (Entiteti.Spomenik r in sviSpomenici)
                {
                    spomenici.Add(new SpomenikPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o spomenicima.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return spomenici;
        }


        public static async Task<Result<SpomenikPregled, ErrorMessage>> vratiSpomenik(int id)
        {
            SpomenikPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Spomenik p = await s.LoadAsync<Entiteti.Spomenik>(id);
                pp = new SpomenikPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o spomenik.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiSpomenik(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Spomenik o = await s.LoadAsync<Spomenik>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati spomenik.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        #endregion

        #region Svetiljka

        public async static Task<Result<bool, ErrorMessage>> dodajSvetiljku(SvetiljkaPregled r, int IdParka)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Svetiljka o = new()
                {
                    Tip = r.Tip,
                    BrSijalica = r.BrSijalica,
                };
                Park z = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                o.PripadaParku = z;

                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguce dodati svetiljku.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<SvetiljkaPregled>, ErrorMessage> vratiSveSvetiljke()
        {

            List<SvetiljkaPregled> svetiljke = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Svetiljka> sveSvetiljke = from o in s.Query<Entiteti.Svetiljka>()
                                                                           select o;

                foreach (Entiteti.Svetiljka r in sveSvetiljke)
                {
                    svetiljke.Add(new SvetiljkaPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o svetiljkama.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return svetiljke;
        }


        public static async Task<Result<SvetiljkaPregled, ErrorMessage>> vratiSvetiljku(int id)
        {
            SvetiljkaPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Svetiljka p = await s.LoadAsync<Entiteti.Svetiljka>(id);
                pp = new SvetiljkaPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o svetiljki.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiSvetiljku(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Svetiljka o = await s.LoadAsync<Svetiljka>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati svetiljku.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public async static Task<Result<SvetiljkaPregled, ErrorMessage>> azurirajSvetiljku(SvetiljkaPregled p)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Svetiljka o = s.Load<Svetiljka>(p.IdO);
                o.BrSijalica = p.BrSijalica;

                await s.UpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguce azurirati svetiljku.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return p;
        }



        #endregion

        #region Drvo

        public async static Task<Result<bool, ErrorMessage>> dodajDrvo(DrvoPregled r, int IdZastite=0, int IdParka)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

           

                Drvo o = new()
                {
                    Tip = r.Tip,
                    VisinaKrosnje = r.VisinaKrosnje,
                    Vrsta = r.Vrsta,
                    DatumSadnje = r.DatumSadnje,
                    PovrsinaK = r.PovrsinaK,
                    ObimDebla = r.ObimDebla,
                };

                if (IdZastite != 0) //trebalo bi da se tako radi za zastitu
                {
                    Zastita z = await s.LoadAsync<Zastita>(IdZastite);
                    o.PodZastitomDrvo = z; 
                }
                Park p = await s.LoadAsync<Park>(IdParka); //trebalo bi da je tako
                o.PripadaParku = p;

                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguce dodati drvo.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<DrvoPregled>, ErrorMessage> vratiSvaDrveca()
        {

            List<DrvoPregled> drva = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Drvo> svaDrva = from o in s.Query<Entiteti.Drvo>()
                                                               select o;

                foreach (Entiteti.Drvo r in svaDrva)
                {
                    drva.Add(new DrvoPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o drvecu.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return drva;
        }


        public static async Task<Result<DrvoPregled, ErrorMessage>> vratiDrvo(int id)
        {
            DrvoPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Drvo p = await s.LoadAsync<Entiteti.Drvo>(id);
                pp = new DrvoPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o drvetu.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiDrvo(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Drvo o = await s.LoadAsync<Drvo>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati drvo.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public async static Task<Result<DrvoPregled, ErrorMessage>> azurirajDrvo(DrvoPregled p)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Drvo o = s.Load<Drvo>(p.IdO);
                o.VisinaKrosnje = p.VisinaKrosnje;
                o.PovrsinaK = p.PovrsinaK;
                o.ObimDebla = p.ObimDebla;

                await s.UpdateAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguce azurirati drvo.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return p;
        }


        #endregion

        #region Zastita

        public async static Task<Result<bool, ErrorMessage>> dodajZastitu(ZastitaPregled r)
        {
            ISession? s = null;
            try
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Zastita o = new()
                {
                    Institucija = r.Institucija,
                    DatumOd = r.DatumOd,
                    NovcanaSredstva = r.NovcanaSredstva,
                    OpisZnacaja = r.OpisZnacaja,
                    
                };

                await s.SaveAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return GetError("Nemoguće dodati zastitu.", 404);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        public static Result<List<ZastitaPregled>, ErrorMessage> vratiSveZastite()
        {

            List<ZastitaPregled> zastite = new();
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                IEnumerable<Entiteti.Zastita> sveZastite = from o in s.Query<Entiteti.Zastita>()
                                                          select o;

                foreach (Entiteti.Zastita r in sveZastite)
                {
                    zastite.Add(new ZastitaPregled(r));
                }

            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o zastitama.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return zastite;
        }


        public static async Task<Result<ZastitaPregled, ErrorMessage>> vratiZastitu(int id)
        {
            ZastitaPregled pp = new();

            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Entiteti.Zastita p = await s.LoadAsync<Entiteti.Zastita>(id);
                pp = new ZastitaPregled(p);
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o zastiti.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return pp;
        }

        public async static Task<Result<bool, ErrorMessage>> obrisiZastitu(int id)
        {
            ISession? s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Zastita o = await s.LoadAsync<Zastita>(id);

                await s.DeleteAsync(o);
                await s.FlushAsync();
            }
            catch (Exception)
            {
                return "Nemoguće obrisati zastitu.".ToError(400);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }


        #endregion

        #region Sef
        //ne znam da li se sef radi isto kao i ovo ostalo
        #endregion
    }
}
