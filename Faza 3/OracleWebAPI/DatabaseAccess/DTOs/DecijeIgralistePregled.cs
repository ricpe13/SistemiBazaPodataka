namespace DatabaseAccess.DTOs
{
    public class DecijeIgralistePregled : ObjekatPregled
    {
        public int? BrIgracaka { get; set; }
        public int? Pesak { get; set; }
        public int? Starost { get; set; }
        public DecijeIgralistePregled()
        {

        }
        internal DecijeIgralistePregled(DecijeIgraliste? di) : base(di)
        {
            if (di != null)
            {
                BrIgracaka = di.BrIgracaka;
                Pesak = di.Pesak;
                Starost = di.Starost;
            }
        }
    }
}
