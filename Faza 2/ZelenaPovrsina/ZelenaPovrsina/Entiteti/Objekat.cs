
namespace ZelenaPovrsina.Entiteti
{
    public abstract class Objekat
    {
        public virtual required int Id { get; set; }
        public virtual Park PripadaParku { get; set; }
        public virtual int RedniBroj { get; set; }
        public virtual string Tip { get; set; }

    }
}
