namespace ZelenaPovrsina.Entiteti
{
    public class ZasticeniObjekat : Objekat
    {
        public virtual int IdZO { get; protected set; }
        //public virtual int IdZastite { get; set; }
        public virtual string TipZO { get;  set; }
        public virtual string NazivSpom { get; set; }
        public virtual string AutorSkul { get; set; }
        public virtual Zastita PodZastitomZO { get; set; }
        
    }
}