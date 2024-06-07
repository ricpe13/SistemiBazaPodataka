namespace DatabaseAccess.Entiteti
{
    internal abstract class Objekat
    {
        internal protected virtual int Id { get; set; }
        internal protected virtual Park? PripadaParku { get; set; }
        internal protected virtual int? RedniBroj { get; set; }
        internal protected virtual string? Tip { get; set; }

    }
}
