namespace DatabaseAccess.DTOs
{
    public class ParkPregled : ZelenaPovrsinaPregled
    {
        public string? NazivP;
        public double? PovrsinaP;
        public GrupaRadnikaPregled? GrupaRadnika;

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
