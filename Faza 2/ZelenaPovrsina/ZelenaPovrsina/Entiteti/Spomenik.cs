
namespace ZelenaPovrsina.Entiteti
{
    public class Spomenik : Objekat
    {
        public required virtual string NazivS { get; set; }
        public virtual Zastita Zastita { get; set; }
    }
}
