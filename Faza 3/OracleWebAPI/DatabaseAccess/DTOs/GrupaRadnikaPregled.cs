namespace DatabaseAccess.DTOs
{
    public class GrupaRadnikaPregled
    {
        public int IdG { get; set; }
        public string? NazivG { get; set; }
        public ParkPregled? Park { get; set; }
        public SefPregled? Sef { get; set; }
        private Park? park { get; set; }
        private Sef? sef { get; set; }

        public virtual IList<RadnikPregled>? RadniciGrupe { get; set; }

        public GrupaRadnikaPregled()
        {
            RadniciGrupe = new List<RadnikPregled>();
        }

        public GrupaRadnikaPregled(GrupaRadnika? gr)
        {
            if (gr != null)
            {
                IdG = gr.NazivG;
                NazivG = gr.NazivG;
            }
        }
    }
}
