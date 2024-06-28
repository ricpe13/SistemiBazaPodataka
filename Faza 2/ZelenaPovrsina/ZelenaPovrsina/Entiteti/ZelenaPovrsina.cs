
namespace ZelenaPovrsina.Entiteti
{
    public class ZelenaPovrsina
    {
        public virtual int IdZ { get; protected set; }
        public virtual string? NazivGradskeOpstine { get; set; }
        public virtual string? ZonaUgrozenosti { get; set; }
        public virtual string? TipZ { get; set; }


        public virtual IList<Radnik> RadniciZP { get; set; }

        public ZelenaPovrsina()
        {
            RadniciZP = new List<Radnik>();
        }

    }
}