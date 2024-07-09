
namespace ZelenaPovrsina.Entiteti
{
    public class Objekat
    {
        public virtual int Id { get; set; }
        public virtual Park? PripadaParku { get; set; }
        public virtual int RedniBroj { get; set; }
        public virtual string? Tip { get; set; }

    }
}
