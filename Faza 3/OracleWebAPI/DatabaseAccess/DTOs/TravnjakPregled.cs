namespace DatabaseAccess.DTOs
{
    public class TravnjakPregled : ZelenaPovrsinaPregled
    {
        public string? AdresaZgrade { get; set; }
        public int? PovrsinaT { get; set; }

        public TravnjakPregled()
        {

        }

        internal TravnjakPregled(Travnjak? t) : base(t)
        {
            if (t != null)
            {
                AdresaZgrade = t.AdresaZgrade;
                PovrsinaT = t.PovrsinaT;
            }
        }
    }
}
