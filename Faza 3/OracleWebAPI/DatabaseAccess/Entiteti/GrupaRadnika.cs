namespace DatabaseAccess.Entiteti
{
    internal class GrupaRadnika
    {
        internal protected virtual int IdG { get; protected set; }
        internal protected virtual string? NazivG { get; set; }


        internal protected virtual Park? Park { get; set; } //zbog one to one se pise
        internal protected virtual Sef? Sef { get; set; }
        internal protected virtual IList<Radnik>? RadniciGrupe { get; set; }

        internal GrupaRadnika()
        {
            RadniciGrupe = new List<Radnik>();
        }
    }
}