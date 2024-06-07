namespace DatabaseAccess.Entiteti
{
    internal class ZelenaPovrsina
    {
        internal protected virtual int IdZ { get; protected set; }
        internal protected virtual string? NazivGradskeOpstine { get; set; }
        internal protected virtual string? ZonaUgrozenosti { get; set; }
        internal protected virtual string? TipZ { get; set; }


        internal protected virtual IList<Radnik>? RadniciZP { get; set; }

        internal ZelenaPovrsina()
        {
            RadniciZP = new List<Radnik>();
        }

    }
}