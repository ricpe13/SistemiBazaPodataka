using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SkulpturaPregled : ObjekatPregled
    {
        public string? Autor { get; set; }
        public ZastitaPregled? Zastita { get; set; }

        public SkulpturaPregled()
        {

        }
        internal SkulpturaPregled(Skulptura? s) : base(s)
        {
            if (s != null)
            {
                Autor = s.Autor;
                Zastita = s.Zastita;
            }
        }
    }
}
