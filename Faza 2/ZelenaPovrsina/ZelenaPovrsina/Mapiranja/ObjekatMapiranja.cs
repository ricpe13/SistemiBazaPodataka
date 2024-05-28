namespace ZelenaPovrsina.Mapiranja
{
    public class ObjekatMapiranja : ClassMap<Objekat>
    {
        public ObjekatMapiranja()
        {
            Table("OBJEKAT");
            CompositeId(x => x.Id)
                .KeyReference(x => x.Park, "IDPARKA")
                .KeyProperty(x => x.RedniBr, "REDNIBR");
        }
        
    }
}
