namespace DatabaseAccess.DTOs
{
    public class ZastitaPregled
    {
        public int IdZastite { get; set; }
        public string? Institucija { get; set; }
        public DateTime? DatumOd { get; set; }
        public int? NovcanaSredstva { get; set; }
        public string? OpisZnacaja { get; set; }

        public virtual IList<Skulptura>? Skulpture { get; set; } = [];
        public virtual IList<Spomenik>? Spomenici { get; set; } = [];
        public virtual IList<Drvo>? Drvece { get; set; } = [];

        public ZastitaPregled() { }
        public ZastitaPregled(Zastita? z)
        {
            if (z != null)
            {
                IdZastite = z.IdZastite;
                Institucija = z.Institucija;
                DatumOd = z.DatumOd;
                NovcanaSredstva = z.NovcanaSredstva;
                OpisZnacaja = z.OpisZnacaja;
            }
        }
    }
}
