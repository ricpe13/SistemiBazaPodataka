namespace DatabaseAccess.DTOs
{
    public class SvetiljkaPregled : ObjekatPregled
    {
        public int? BrSijalica { get; set; }
        public SvetiljkaPregled()
        {

        }
        internal SvetiljkaPregled(Svetiljka? s) : base(s)
        {
            if (s != null)
            {
                BrSijalica = s.BrSijalica;
            }
        }
    }
}
