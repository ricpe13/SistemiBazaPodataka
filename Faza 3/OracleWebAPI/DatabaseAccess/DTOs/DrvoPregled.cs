namespace DatabaseAccess.DTOs
{
    public class DrvoPregled : ObjekatPregled
    {
        public int? VisinaKrosnje { get; set; }
        public string? Vrsta { get; set; }
        public DateTime? DatumSadnje { get; set; }
        public double? PovrsinaK { get; set; }
        public double? ObimDebla { get; set; }
        public int? IdZ { get; set; } //za ovo uopste nisam siguran
        public ZastitaPregled? Zastita; //za ovo uopste nisam siguran

        public DrvoPregled()
        {

        }
        internal DrvoPregled(Drvo? d) : base(d)
        {
            if (d != null)
            {
                VisinaKrosnje = d.VisinaKrosnje;
                Vrsta = d.Vrsta;
                DatumSadnje = d.DatumSadnje;
                PovrsinaK = d.PovrsinaK;
                ObimDebla = d.ObimDebla;
                IdZ = d.PodZastitomDrvo.IdZastite; //za ovo uopste nisam siguran
            }
        }
    }
}
