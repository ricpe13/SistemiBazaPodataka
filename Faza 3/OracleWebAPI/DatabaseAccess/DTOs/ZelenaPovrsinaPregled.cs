﻿namespace DatabaseAccess.DTOs
{
    public class ZelenaPovrsinaPregled
    {
        public int Id { get; set; }
        public string? NazivGradskeOpstine { get; set; }
        public string? ZonaUgrozenosti { get; set; }
        public string? TipZ { get; set; }
        public virtual IList<RadnikPregled>? RadniciZP { get; set; }
        public ZelenaPovrsinaPregled()
        {
            RadniciZP = new List<RadnikPregled>();
        }
        internal ZelenaPovrsinaPregled(ZelenaPovrsina? zp) : base(zp)
        {
            if (zp != null)
            {
                Id = zp.Id;
                NazivGradskeOpstine = zp.NazivGradskeOpstine;
                ZonaUgrozenosti = zp.ZonaUgrozenosti;
                TipZ = zp.TipZ;
            }
        }
    }
}
