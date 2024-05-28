namespace ZelenaPovrsina.Entiteti
{
    public class GrupaRadnika
    {
        public virtual int IdG { get; protected set; }
        public required virtual string NazivG { get; set; }
        

        public required virtual Park Park { get; set; } //zbog one to one se pise
        public required virtual Sef Sef { get; set; }
        public virtual IList<Radnik> RadniciGrupe { get; set; } = [];

        //public GrupaRadnika() { 
        //    RadniciGrupe = new List<Radnik>();
        //}
    }
}