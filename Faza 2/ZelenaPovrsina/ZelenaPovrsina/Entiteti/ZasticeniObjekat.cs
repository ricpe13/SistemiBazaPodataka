
namespace ZelenaPovrsina.Entiteti
{
    public class ZasticeniObjekat : Objekat
    {
        public virtual int IdZastite { get; set; }
        public required virtual string TipZO { get;  set; }
        public virtual string? NazivSpom { get; set; }
        public virtual string? AutorSkul { get; set; }
        public virtual Zastita PodZastitomZO { get; set; }
        
    }
}
