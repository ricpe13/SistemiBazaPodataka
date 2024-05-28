
namespace ZelenaPovrsina.Entiteti
{
    public abstract class ZasticeniObjekat : Objekat
    {
        public required virtual string TipZO { get;  set; }
        public virtual string? NazivSpom { get; set; }
        public virtual string? AutorSkul { get; set; }
        public virtual Zastita PodZastitomZO { get; set; }
        
    }
}
