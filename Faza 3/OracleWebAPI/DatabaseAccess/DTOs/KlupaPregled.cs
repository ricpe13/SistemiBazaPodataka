namespace DatabaseAccess.DTOs
{
    public class KlupaPregled : ObjekatPregled
    {
        public string? Materijal { get; set; }

        public KlupaPregled()
        {

        }
        internal KlupaPregled(Klupa? k) : base(k)
        {
            if (k != null)
            {
                Materijal = k.Materijal;
            }
        }
    }
}
