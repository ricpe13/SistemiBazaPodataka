namespace ZelenaPovrsina.Mapiranja
{
    public class ObjekatMapiranja : ClassMap<Objekat>
    {
        public ObjekatMapiranja()
        {
            Table("OBJEKAT");
            Id(x => x.Id, "IDO").GeneratedBy.TriggerIdentity();
            //Id(x => x.Id, "REDNIBR").GeneratedBy.SequenceIdentity();
            Map(x => x.RedniBroj, "REDNIBR");
            Map(x => x.Tip, "TIP");
            References(x => x.PripadaParku).Column("IdParka").LazyLoad();
        }
        
    }
}
