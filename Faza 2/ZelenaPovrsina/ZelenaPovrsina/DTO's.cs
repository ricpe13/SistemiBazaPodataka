

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

    public ZelenaPovrsinaPregled(int id,string naziv,string zona,string tipz):this()
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
        public virtual IList<Radnik> RadniciZP { get; set; } 
        public ZelenaPovrsinaBasic()
        {
            RadniciZP = new List<RadnikBasic>();
        }
        public ZelenaPovrsinaBasic(int id,string naziv,string zona,string tipz):this()
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
        public string? ImeRoditelja;
        public string? StrucnaSprema;
        public DateTime DatumRodj;
        public int ZaZelenilo;
        public int ZaHigijenu;
        public int ZaObjekat;
    }
    #endregion
}
