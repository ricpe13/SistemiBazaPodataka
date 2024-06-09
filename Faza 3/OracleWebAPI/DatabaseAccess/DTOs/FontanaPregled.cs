namespace DatabaseAccess.DTOs
{
    public class FontanaPregled : ObjekatPregled
    {
        public int? BrPrskalica { get; set; }
        public int? PovrsinaF { get; set; }

        public FontanaPregled()
        {

        }
        internal FontanaPregled(Fontana? f) : base(f)
        {
            if (f != null)
            {
                BrPrskalica = f.BrPrskalica;
                PovrsinaF = f.PovrsinaF;
            }
        }
    }
}
