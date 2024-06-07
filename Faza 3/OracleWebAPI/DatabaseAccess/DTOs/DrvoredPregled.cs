namespace DatabaseAccess.DTOs
{
    public class DrvoredPregled : ZelenaPovrsinaPregled
    {
        public string? Ulica { get; set; }
        public double? Duzina { get; set; }
        public string? VrstaDrveta { get; set; }
        public int? BrojStabala { get; set; }

        public DrvoredPregled()
        {

        }

        internal DrvoredPregled(Drvored? d) : base(d)
        {
            if (d != null)
            {
                Ulica = d.Ulica;
                Duzina = d.Duzina;
                VrstaDrveta = d.VrstaDrveta;
                BrojStabala = d.BrojStabala;
            }
        }
    }
}
