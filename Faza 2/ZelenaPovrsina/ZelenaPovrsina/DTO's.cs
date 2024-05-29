

namespace ZelenaPovrsina
{
    #region Prodavnica
    public class ZelenaPovrsinaPregled
    {
        public int Id;
        public string NazivGradskeOpstine;
        public string ZonaUgrozenosti;
        public string TipZ;
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
        public int Id;
        public string NazivGradskeOpstine;
        public string ZonaUgrozenosti;
        public string TipZ;
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

        public RadnikBasic(int idR, string ime, string prezime, string jmbg, string adresa, int brRadneKnjizice, string imeRoditelja, int zaZelenilo, int zaHigijenu, int zaObjekat, string strucnaSprema, DateTime datumRodj)
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

        public SefBasic(int idRad, string matbr)
        {
            IdRad = idRad;
            Matbr = matbr;
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
    public class ParkBasic
    {

    }

    public class ParkPregled
    {

    }

    #endregion

    #region Objekat
    public class ObjekatBasic
    {
        public int IdO { get; set; }
        public int IdParka { get; set; }
        public int RedniBr { get; set; }
        public string Tip { get; set; }

        public ObjekatBasic(int ido, int idparka, int rednibr, string tip)
        {
            this.IdO = ido;
            this.IdParka = idparka;
            this.RedniBr = rednibr;
            this.Tip = tip;
        }
        public ObjekatBasic()
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

        public DrvoBasic()
        {

        }
        public DrvoBasic(int id, int rednibr, string tip, int visinakrosnje, string vrsta, DateTime datumsadnje, double povrsinak, double obimdebla) : base(id, rednibr, tip)
        {
            this.VisinaKrosnje = visinakrosnje;
            this.Vrsta = vrsta;
            this.DatumSadnje = datumsadnje;
            this.PovrsinaK = povrsinak;
            this.ObimDebla = obimdebla;
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
        public KlupaBasic(int id, int rednibr, string tip, string materijal) : base(id, rednibr, tip)
        {
            this.Materijal = materijal;
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
        public SvetiljkaBasic(int id, int rednibr, string tip, int brsijalica) : base(id, rednibr, tip)
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
        public DecijeIgralisteBasic(int id, int rednibr, string tip, int brigracaka, int pesak, int starost) : base(id, rednibr, tip)
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
        public FontanaBasic(int id, int rednibr, string tip, int brprskalica, int povrsinaf) : base(id, rednibr, tip)
        {
            this.BrPrskalica = brprskalica;
            this.PovrsinaF = povrsinaf;
    

        }
    }

    #endregion

    #region Spomenik



    #endregion

    #region Skulptura



    #endregion

}