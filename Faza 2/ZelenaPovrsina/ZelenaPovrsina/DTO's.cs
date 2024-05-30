



namespace ZelenaPovrsina
{
    #region ZelenaPovrsina
    public class ZelenaPovrsinaPregled
    {
        public int Id { get; set; }
        public string NazivGradskeOpstine { get; set; }
        public string ZonaUgrozenosti { get; set; }
        public string TipZ { get; set; }
        public ZelenaPovrsinaPregled()
        {

        }

        public ZelenaPovrsinaPregled(int id, string naziv, string zona, string tipz) : this()
        {
            Id = id;
            NazivGradskeOpstine = naziv;
            ZonaUgrozenosti = zona;
            TipZ = tipz;
        }
    }
    public class ZelenaPovrsinaBasic
    {
        public int Id { get; set; }
        public string NazivGradskeOpstine { get; set; }
        public string ZonaUgrozenosti { get; set; }
        public string TipZ { get; set; }
        public virtual IList<RadnikBasic> RadniciZP { get; set; }
        public ZelenaPovrsinaBasic()
        {
            RadniciZP = new List<RadnikBasic>();
        }
        public ZelenaPovrsinaBasic(int id, string naziv, string zona, string tipz) : this()
        {
            Id = id;
            NazivGradskeOpstine = naziv;
            ZonaUgrozenosti = zona;
            TipZ = tipz;
        }
    }

    #endregion

    #region Radnik
    public class RadnikPregled
    {
        public int IdR;
        public string Ime;
        public string Prezime;
        public string Jmbg;
        public string Adresa;
        public int BrRadneKnjizice;
        public string ImeRoditelja;
        public string StrucnaSprema;
        public DateTime DatumRodj;
        public int ZaZelenilo;
        public int ZaHigijenu;
        public int ZaObjekat;

        public RadnikPregled(int idR, string ime, string prezime, string jmbg, string adresa, int brRadneKnjizice, string imeRoditelja, string strucnaSprema, DateTime datumRodj, int zaZelenilo, int zaHigijenu, int zaObjekat)
        {
            IdR = idR;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            Adresa = adresa;
            BrRadneKnjizice = brRadneKnjizice;
            ImeRoditelja = imeRoditelja;
            StrucnaSprema = strucnaSprema;
            DatumRodj = datumRodj;
            ZaZelenilo = zaZelenilo;
            ZaHigijenu = zaHigijenu;
            ZaObjekat = zaObjekat;
        }
        public RadnikPregled()
        {

        }
    }

    public class RadnikBasic
    {
        public int IdR;
        public string Ime;
        public string Prezime;
        public string Jmbg;
        public string Adresa;
        public int BrRadneKnjizice;
        public string ImeRoditelja;
        public int ZaZelenilo;
        public int ZaHigijenu;
        public int ZaObjekat;
        public string StrucnaSprema;
        public DateTime DatumRodj;
        public ZelenaPovrsinaBasic ZelenaPovrsina;
        public GrupaRadnikaBasic GrupaRadnika;

        public RadnikBasic(int idR, string ime, string prezime, string jmbg, string adresa, int brRadneKnjizice, string imeRoditelja, int zaZelenilo, int zaHigijenu, int zaObjekat, string strucnaSprema, DateTime datumRodj, ZelenaPovrsinaBasic zp, GrupaRadnikaBasic gr)
        {
            IdR = idR;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            Adresa = adresa;
            BrRadneKnjizice = brRadneKnjizice;
            ImeRoditelja = imeRoditelja;
            ZaZelenilo = zaZelenilo;
            ZaHigijenu = zaHigijenu;
            ZaObjekat = zaObjekat;
            StrucnaSprema = strucnaSprema;
            DatumRodj = datumRodj;
            ZelenaPovrsina = zp;
            GrupaRadnika = gr;

        }

        public RadnikBasic()
        {

        }
    }

    #endregion

    #region GrupaRadnika

    public class GrupaRadnikaPregled
    {
        public int Idg;
        public string NazivG;
        public GrupaRadnikaPregled(int idg, string nazivG)
        {
            Idg = idg;
            NazivG = nazivG;
        }
        public GrupaRadnikaPregled()
        {

        }
    }

    public class GrupaRadnikaBasic
    {
        public int IdG;
        public string NazivG;
        public ParkBasic Park;
        public SefBasic Sef;
        private Park park;
        private Sef sef;

        public virtual IList<RadnikBasic> RadniciGrupe { get; set; }

        public GrupaRadnikaBasic()
        {
            RadniciGrupe = new List<RadnikBasic>();
        }

        public GrupaRadnikaBasic(int idg, string nazivG)
        {
            NazivG = nazivG;
            IdG = idg;
        }

    }
    #endregion

    #region Sef

    public class SefBasic
    {
        public int IdRad;
        public string Matbr;
        public GrupaRadnikaBasic GrupaRadnika;

        public SefBasic() { }
        public SefBasic(int idRad, string matbr, GrupaRadnikaBasic gr)
        {
            IdRad = idRad;
            Matbr = matbr;
            GrupaRadnika = gr;
        }
    }

    public class SefPregled
    {
        public int IdRad;
        public string Matbr;

        public SefPregled(int idr, string matbr)
        {
            Matbr = matbr;
            IdRad = idr;
        }
        public SefPregled()
        {

        }

        

        
    }
    #endregion

    #region Park
    public class ParkPregled : ZelenaPovrsinaPregled
    {
        
        public string NazivP;
        public double PovrsinaP;
        
        public ParkPregled()
        {

        }

        public ParkPregled(int id, string naziv, string zona, string tipz, string nazivp, double povrsinap) : base(id,naziv,zona,tipz)
        {
            NazivP = nazivp;
            PovrsinaP = povrsinap;
        }
    }


    public class ParkBasic : ZelenaPovrsinaBasic
    {
        public string NazivP;
        public double PovrsinaP;
        public GrupaRadnikaBasic GrupaRadnika;

        public ParkBasic()
        {

        }

        public ParkBasic(int id, string naziv, string zona, string tipz, string nazivp, double povrsinap) : base(id, naziv, zona, tipz)
        {
            NazivP = nazivp;
            PovrsinaP = povrsinap;
        }
    }

    #endregion

    #region Drvored

    public class DrvoredPregled : ZelenaPovrsinaPregled
    {

        public string Ulica;
        public double Duzina;
        public string VrstaDrveta;
        public int BrojStabala;

        public DrvoredPregled()
        {

        }

        public DrvoredPregled(int id, string naziv, string zona, string tipz, string ulica, double duzina, string vrstad, int brstabala) : base(id, naziv, zona, tipz)
        {
            Ulica = ulica;
            Duzina = duzina;
            VrstaDrveta = vrstad;
            BrojStabala = brstabala;
        }
    }

    public class DrvoredBasic : ZelenaPovrsinaBasic
    {

        public string Ulica;
        public double Duzina;
        public string VrstaDrveta;
        public int BrojStabala;

        public DrvoredBasic()
        {

        }

        public DrvoredBasic(int id, string naziv, string zona, string tipz, string ulica, double duzina, string vrstad, int brstabala) : base(id, naziv, zona, tipz)
        {
            Ulica = ulica;
            Duzina = duzina;
            VrstaDrveta = vrstad;
            BrojStabala = brstabala;
        }
    }


    #endregion

    #region Travnjak

    public class TravnjakPregled : ZelenaPovrsinaPregled
    {

        public string AdresaZgrade;
        public int PovrsinaT;

        public TravnjakPregled()
        {

        }

        public TravnjakPregled(int id, string naziv, string zona, string tipz, string adresazgrade, int povrsinat) : base(id, naziv, zona, tipz)
        {
            AdresaZgrade = adresazgrade;
            PovrsinaT = povrsinat;
        }
    }

    public class TravnjakBasic : ZelenaPovrsinaBasic
    {

        public string AdresaZgrade;
        public int PovrsinaT;

        public TravnjakBasic()
        {

        }

        public TravnjakBasic(int id, string naziv, string zona, string tipz, string adresazgrade, int povrsinat) : base(id, naziv, zona, tipz)
        {
            AdresaZgrade = adresazgrade;
            PovrsinaT = povrsinat;
        }
    }


    #endregion

    #region Objekat
    public class ObjekatBasic
    {
        public int IdO { get; set; }
        public ParkBasic PripadaParku { get; set; }
        public int RedniBr { get; set; }
        public string Tip { get; set; }

        public ObjekatBasic(int ido, ParkBasic park, int rednibr, string tip)
        {
            IdO = ido;
            PripadaParku = park;
            RedniBr = rednibr;
            Tip = tip;
        }
        public ObjekatBasic()
        {

        }

        
    }

    public class ObjekatPregled
    {
        public int IdO { get; set; }
        public ParkBasic PripadaParku { get; set; }
        public int RedniBr { get; set; }
        public string Tip { get; set; }

        public ObjekatPregled(int ido, int rednibr, string tip)
        {
            IdO = ido;
            RedniBr = rednibr;
            Tip = tip;
        }
        public ObjekatPregled()
        {

        }
    }

    #endregion

    #region Drvo

    public class DrvoBasic : ObjekatBasic
    {
        public int VisinaKrosnje;
        public string Vrsta;
        public DateTime DatumSadnje;
        public double PovrsinaK;
        public double ObimDebla;
        public ZastitaBasic Zastita;

        public DrvoBasic()
        {

        }
        public DrvoBasic(int id, ParkBasic park, int rednibr, string tip, int visinakrosnje, string vrsta, DateTime datumsadnje, double povrsinak, double obimdebla, ZastitaBasic zas) : base(id, park, rednibr, tip)
        {
            VisinaKrosnje = visinakrosnje;
            Vrsta = vrsta;
            DatumSadnje = datumsadnje;
            PovrsinaK = povrsinak;
            ObimDebla = obimdebla;
            Zastita = zas;
        }
    }

    public class DrvoPregled : ObjekatPregled
    {
        public int VisinaKrosnje;
        public string Vrsta;
        public DateTime DatumSadnje;
        public double PovrsinaK;
        public double ObimDebla;

        public DrvoPregled() { }

        public DrvoPregled(int ido, int rednibr, string tip, int visinaKrosnje, string vrsta, DateTime datumSadnje, double povrsinaK, double obimDebla) : base(ido, rednibr, tip)
        {
            VisinaKrosnje = visinaKrosnje;
            Vrsta = vrsta;
            DatumSadnje = datumSadnje;
            PovrsinaK = povrsinaK;
            ObimDebla = obimDebla;
        }
    }

    #endregion

    #region Klupa

    public class KlupaBasic : ObjekatBasic
    {
        public string Materijal;

        public KlupaBasic()
        {

        }
        public KlupaBasic(int id,ParkBasic park, int rednibr, string tip, string materijal) : base(id,park, rednibr, tip)
        {
            Materijal = materijal;
        }
    }

    public class KlupaPregled : ObjekatPregled
    {
        public string Materijal;
        public KlupaPregled() { 

        }

        public KlupaPregled(int id, int rednibr, string tip, string materijal) : base(id, rednibr, tip)
        {
            Materijal = materijal;
        }
    }


    #endregion

    #region Svetiljka

    public class SvetiljkaBasic : ObjekatBasic
    {
        public int BrSijalica;
        public SvetiljkaBasic()
        {

        }
        public SvetiljkaBasic(int id,ParkBasic park, int rednibr, string tip, int brsijalica) : base(id,park, rednibr, tip)
        {
            this.BrSijalica = brsijalica;
        }
    }

    public class SvetiljkaPregled : ObjekatPregled
    {
        public int BrSijalica;
        public SvetiljkaPregled()
        {

        }
        public SvetiljkaPregled(int id, int rednibr, string tip, int brsijalica) : base(id, rednibr, tip)
        {
            this.BrSijalica = brsijalica;
        }
    }

    #endregion

    #region DecijeIgraliste

    public class DecijeIgralisteBasic : ObjekatBasic
    {
        public int BrIgracaka;
        public int Pesak;
        public int Starost;
        public DecijeIgralisteBasic()
        {

        }
        public DecijeIgralisteBasic(int id,ParkBasic park, int rednibr, string tip, int brigracaka, int pesak, int starost) : base(id,park, rednibr, tip)
        {
            this.BrIgracaka = brigracaka;
            this.Pesak = pesak;
            this.Starost = starost;


        }
    }

    public class DecijeIgralistePregled : ObjekatPregled
    {
        public int BrIgracaka;
        public int Pesak;
        public int Starost;
        public DecijeIgralistePregled()
        {

        }
        public DecijeIgralistePregled(int id, int rednibr, string tip, int brigracaka, int pesak, int starost) : base(id, rednibr, tip)
        {
            this.BrIgracaka = brigracaka;
            this.Pesak = pesak;
            this.Starost = starost;


        }
    }

    #endregion

    #region Fontana

    public class FontanaBasic : ObjekatBasic
    {
        public int BrPrskalica;
        public int PovrsinaF;

        public FontanaBasic()
        {

        }
        public FontanaBasic(int id,ParkBasic park, int rednibr, string tip, int brprskalica, int povrsinaf) : base(id,park, rednibr, tip)
        {
            BrPrskalica = brprskalica;
            PovrsinaF = povrsinaf;
    

        }

        public class FontanaPregled : ObjekatPregled
        {
            public int BrPrskalica;
            public int PovrsinaF;

            public FontanaPregled()
            {

            }
            public FontanaPregled(int id, int rednibr, string tip, int brprskalica, int povrsinaf) : base(id, rednibr, tip)
            {
                BrPrskalica = brprskalica;
                PovrsinaF = povrsinaf;


            }
        }
    }

    #endregion

    #region Spomenik
    
    public class SpomenikBasic:ObjekatBasic
    {
        public string NazivS;
        public ZastitaBasic Zastita;

        public SpomenikBasic() { }  

        public SpomenikBasic(int id,ParkBasic park, int rbr, string t, string naz,ZastitaBasic zastita):base(id,park,rbr,t)
        {
            NazivS = naz;
            Zastita = zastita;
        }
    }

    public class SpomenikPregled:ObjekatPregled
    {
        public string NazivS;

        public SpomenikPregled() { }

        public SpomenikPregled(int id,int rednibr, string tip, string naziv):base(id,rednibr,tip)
        {
            NazivS = naziv;
        }
    }


    #endregion

    #region Skulptura

    public class SkulpturaBasic:ObjekatBasic
    {
        public string Autor;
        public ZastitaBasic Zastita;

        public SkulpturaBasic()
        {

        }
        public SkulpturaBasic(int id,ParkBasic park,int rbr, string tip, string autor, ZastitaBasic zastita) : base(id,park,rbr,tip)
        {
            Autor = autor;
            Zastita = zastita;
        }
    }

    public class SkulpturaPregled:ObjekatPregled
    {
        public string Autor;

        public SkulpturaPregled() { }

        public SkulpturaPregled(int id,int rbr,string t,string autor) : base(id,rbr,t)
        {
            Autor = autor;
        }
    }



    #endregion

    #region Zastita

    public class ZastitaBasic
    {
        public int IdZastite;
        public string Institucija;
        public DateTime DatumOd;
        public int NovcanaSredstva;
        public string OpisZnacaja;

        public virtual IList<Skulptura> Skulpture { get; set; } = [];
        public virtual IList<Spomenik> Spomenici { get; set; } = [];
        public virtual IList<Drvo> Drvece { get; set; } = [];

        public ZastitaBasic() { }
        public ZastitaBasic(int idZastite, string institucija, DateTime datumOd, int novcanaSredstva, string opisZnacaja)
        {
            IdZastite = idZastite;
            Institucija = institucija;
            DatumOd = datumOd;
            NovcanaSredstva = novcanaSredstva;
            OpisZnacaja = opisZnacaja;
        }
    }

    public class ZastitaPregled
    {
        public int IdZastite;
        public string Institucija;
        public DateTime DatumOd;
        public int NovcanaSredstva;
        public string OpisZnacaja;

        
        public ZastitaPregled() { }
        public ZastitaPregled(int id, string ins, DateTime dat, int nov, string opis)
        {
            IdZastite = id;
            Institucija = ins;
            DatumOd = dat;
            NovcanaSredstva=nov;
            OpisZnacaja = opis;
        }

    }

    #endregion

}