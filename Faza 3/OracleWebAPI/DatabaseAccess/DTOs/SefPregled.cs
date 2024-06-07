namespace DatabaseAccess.DTOs
{
    public class SefPregled
    {
        public int IdRad { get; set; }
        public string? Matbr { get; set; }
        public GrupaRadnikaPregled? GrupaRadnika { get; set; }

        public SefPregled() { }
        public SefPregled(Sef? s)
        {
            if (s != null)
            {
                IdRad = s.IdRad;
                Matbr = s.Matbr;
                GrupaRadnika = s.GrupaRadnika;
            }
        }
    }
}
