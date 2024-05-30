namespace ZelenaPovrsina.Entiteti
{
    public class Park : ZelenaPovrsina
    {
        public virtual string NazivP { get; set; }
        public virtual double PovrsinaP { get; set; }

        public virtual GrupaRadnika? GrupaRadnika { get; set; } //za one to one

        public virtual IList<Objekat> Objekti { get; set; } = [];

        //public Park()
        //{
        //    Objekti = new List<Objekat>();
        //}
    }
}