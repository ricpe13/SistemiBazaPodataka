
namespace ZelenaPovrsina.Entiteti
{
    public class Zastita
    {
        public virtual int IdZastite { get; protected set; }
        public virtual string Institucija { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual int NovcanaSredstva { get; set; }
        public virtual string OpisZnacaja { get; set; }

        public virtual IList<Skulptura> Skulpture { get; set; }
        public virtual IList<Spomenik> Spomenici { get; set; }
        public virtual IList<Drvo> Drvece { get; set; }

        public Zastita()
        {
            Skulpture = new List<Skulptura>();
            Spomenici= new List<Spomenik>();
            Drvece = new List<Drvo>();
        }

        
    }
}