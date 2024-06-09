namespace DatabaseAccess.Mapiranja
{
    internal class SpomenikMapiranja : SubclassMap<Spomenik>
    {
        public SpomenikMapiranja()
        {
            Table("SPOMENIK");
            Abstract();
            //KeyColumn("IDO");
            Map(x => x.NazivS, "NAZIVS");
            References(x => x.Zastita).Column("IDZASTITE").LazyLoad();



        }
    }
}
