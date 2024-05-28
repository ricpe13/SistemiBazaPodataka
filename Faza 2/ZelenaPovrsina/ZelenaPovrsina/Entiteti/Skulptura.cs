
namespace ZelenaPovrsina.Entiteti
{
    public class Skulptura : Objekat
    {
        public required virtual string Autor { get; set; }
        public virtual Zastita Zastita { get; set; }
    }
}
