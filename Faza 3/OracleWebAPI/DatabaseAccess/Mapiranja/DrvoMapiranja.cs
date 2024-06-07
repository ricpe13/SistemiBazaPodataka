namespace ZelenaPovrsina.Mapiranja
{
    internal class DrvoMapiranja : SubclassMap<Drvo>
    {
        public DrvoMapiranja()
        {
            Table("DRVO");
            Abstract();
            //KeyColumn("IDO");

            Map(x => x.VisinaKrosnje, "VISINAKROSNJE");
            Map(x => x.Vrsta, "VRSTA");
            Map(x => x.DatumSadnje, "DATUMSADNJE");
            Map(x => x.PovrsinaK, "POVRSINAK");
            Map(x => x.ObimDebla, "OBIMDEBLA");
            

            References(x => x.PodZastitomDrvo).Column("IDZASTITE").LazyLoad();

            
        }
    }
}
