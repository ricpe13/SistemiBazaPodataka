namespace DatabaseAccess.Entiteti
{
    internal class Park : ZelenaPovrsina
    {
        internal protected virtual string? NazivP { get; set; }
        internal protected virtual double? PovrsinaP { get; set; }

        internal protected virtual GrupaRadnika? GrupaRadnika { get; set; } //za one to one

        internal protected virtual IList<Objekat>? Objekti { get; set; } = [];

        //public Park()
        //{
        //    Objekti = new List<Objekat>();
        //}
    }
}