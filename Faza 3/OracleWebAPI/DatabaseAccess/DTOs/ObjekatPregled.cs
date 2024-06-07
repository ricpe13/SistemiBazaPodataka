using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ObjekatPregled
    {
        public int IdO { get; set; }
        public ParkPregled? PripadaParku { get; set; }
        public int? RedniBr { get; set; }
        public string? Tip { get; set; }

        public ObjekatPregled()
        {

        }

        public ObjekatPregled(Objekat? o)
        {
            if (o != null)
            {
                IdO = o.Id;
                PripadaParku = o.PripadaParku;
                RedniBr = o.RedniBroj;
                Tip = o.Tip;
            }
        }
    }
}
