namespace ZelenaPovrsina.Mapiranja
{
    internal class ZelenaPovrsinaMapiranja : ClassMap<ZelenaPovrsina.Entiteti.ZelenaPovrsina>
    {
        public ZelenaPovrsinaMapiranja()
        {
            Table("ZELENA_POVRSINA");

            Id(x => x.IdZ, "IDZ").GeneratedBy.TriggerIdentity();

            Map(x => x.NazivGradskeOpstine, "NAZIVGRADSKEOPSTINE");
            Map(x => x.ZonaUgrozenosti, "ZONAUGROZENOSTI");
            Map(x => x.TipZ, "TIPZ");


            // HasMany(x => x.RadniciZP).KeyColumn("IDZP"); //najbolje je da se koristi ovo sto nije zakomentarisano
            // HasMany(x => x.RadniciZP).KeyColumn("IDZP").LazyLoad().Cascade.All();
            HasMany(x => x.RadniciZP).KeyColumn("IDZP").LazyLoad().Cascade.All().Inverse();
        }
    }
}
