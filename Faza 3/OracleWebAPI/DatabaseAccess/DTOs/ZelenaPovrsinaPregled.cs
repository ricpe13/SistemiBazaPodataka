namespace DatabaseAccess.DTOs
{
    public class ZelenaPovrsinaPregled
    {
        public int IdZ { get; set; }
        public string? NazivGradskeOpstine { get; set; }
        public string? ZonaUgrozenosti { get; set; }
        public string? TipZ { get; set; }
        public virtual IList<RadnikPregled>? RadniciZP { get; set; }
        public ZelenaPovrsinaPregled()
        {
            RadniciZP = new List<RadnikPregled>();
        }
        internal ZelenaPovrsinaPregled(ZelenaPovrsina? zp)
        {
            if (zp != null)
            {
                IdZ = zp.IdZ;
                NazivGradskeOpstine = zp.NazivGradskeOpstine;
                ZonaUgrozenosti = zp.ZonaUgrozenosti;
                TipZ = zp.TipZ;
            }
        }
    }
}
