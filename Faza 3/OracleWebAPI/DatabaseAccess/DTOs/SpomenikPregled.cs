using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SpomenikPregled : ObjekatPregled
    {
        public string? NazivS { get; set; }
        public ZastitaPregled? Zastita { get; set; }
        public SpomenikPregled()
        {

        }
        internal SpomenikPregled(Spomenik? s) : base(s)
        {
            if (s != null)
            {
                NazivS = s.NazivS;
                Zastita = s.Zastita;
            }
        }
    }
}
