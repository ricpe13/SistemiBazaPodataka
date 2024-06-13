namespace DatabaseAccess.Mapiranja
{
    internal class ParkMapiranja : SubclassMap<Park>
    {
        public ParkMapiranja()
        {
            Table("PARK");

            KeyColumn("IDZ");

            Map(x => x.NazivP, "NAZIVP");
            Map(x => x.PovrsinaP, "POVRSINAP");

            HasOne(x => x.GrupaRadnika).PropertyRef(x => x.Park).Cascade.All();
            HasMany(x => x.Objekti).KeyColumn("IDPARKA").LazyLoad().Cascade.All().Inverse();


           
        }
    }
}
