namespace DatabaseAccess.Entiteti
{
    internal class Drvo : Objekat
    {
        internal protected virtual int? VisinaKrosnje { get; set; }
        internal protected virtual string? Vrsta { get; set; }
        internal protected virtual DateTime? DatumSadnje { get; set; }
        internal protected virtual double? PovrsinaK { get; set; }
        internal protected virtual double? ObimDebla { get; set; }
        

        internal protected virtual Zastita? PodZastitomDrvo { get; set; }
    }
}