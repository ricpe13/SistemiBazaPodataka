namespace DatabaseAccess.DTOs
{
    public class ParkPregled : ZelenaPovrsinaPregled
    {
        public string? NazivP { get; set; }
        public double? PovrsinaP { get; set; }
        public GrupaRadnikaPregled? GrupaRadnika { get; set; }

        public ParkPregled()
        {

        }

        internal ParkPregled(Park? p) : base(p)
        {
            if (p != null)
            {
                NazivP = p.NazivP;
                PovrsinaP = p.PovrsinaP;
            }
            
        }
    }
}
