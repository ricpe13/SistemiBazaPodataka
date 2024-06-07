namespace DatabaseAccess.Entiteti
{
    internal class Zastita
    {
        internal protected virtual int IdZastite { get; protected set; }
        internal protected virtual string? Institucija { get; set; }
        internal protected virtual DateTime? DatumOd { get; set; }
        internal protected virtual int? NovcanaSredstva { get; set; }
        internal protected virtual string? OpisZnacaja { get; set; }
        internal protected virtual IList<Skulptura>? Skulpture { get; set; }
        internal protected virtual IList<Spomenik>? Spomenici { get; set; }
        internal protected virtual IList<Drvo>? Drvece { get; set; }

        internal Zastita()
        {
            Skulpture = new List<Skulptura>();
            Spomenici= new List<Spomenik>();
            Drvece = new List<Drvo>();
        }

        
    }
}