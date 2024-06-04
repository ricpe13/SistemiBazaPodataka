namespace ZelenaPovrsina.Entiteti
{
    public class Sef
    {
        public virtual int IdRad { get; protected set; }
        public virtual string Matbr { get; set; }

        public virtual GrupaRadnika GrupaRadnika { get; set; }
    }
}