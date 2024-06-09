namespace DatabaseAccess.DTOs
{
    public class GrupaRadnikaPregled
    {
        public int IdG { get; set; }
        public string? NazivG { get; set; }
        public ParkPregled? Park { get; set; }
        public SefPregled? Sef { get; set; }

        public virtual IList<RadnikPregled>? RadniciGrupe { get; set; }

        public GrupaRadnikaPregled()
        {
            RadniciGrupe = new List<RadnikPregled>();
        }

        internal GrupaRadnikaPregled(GrupaRadnika? gr)
        {
            if (gr != null)
            {
                IdG = gr.IdG;
                NazivG = gr.NazivG;
            }
        }
    }
}
