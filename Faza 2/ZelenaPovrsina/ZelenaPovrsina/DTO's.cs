

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
        public string DatumRodj;
        public ZelenaPovrsinaBasic ZelenaPovrsina;
        public GrupaRadnikaBasic GrupaRadnika;

        public RadnikBasic(int idR, string ime, string prezime, string jmbg, string adresa, int brRadneKnjizice, string imeRoditelja, int zaZelenilo, int zaHigijenu, int zaObjekat, string strucnaSprema, string datumRodj)
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
}
