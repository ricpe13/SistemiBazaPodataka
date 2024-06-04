
namespace ZelenaPovrsina.Entiteti
{
    public class GrupaRadnika
    {
        public virtual int IdG { get; protected set; }
        public  virtual string NazivG { get; set; }
        

        public  virtual Park Park { get; set; } //zbog one to one se pise
        public  virtual Sef Sef { get; set; }
        public virtual IList<Radnik> RadniciGrupe { get; set; }

        public GrupaRadnika()
        {
            RadniciGrupe = new List<Radnik>();
        }
    }
}