namespace DatabaseAccess.Mapiranja
{
    internal class SkulpturaMapiranja : SubclassMap<Skulptura>
    {
        public SkulpturaMapiranja()
        {
            Table("SKULPTURA");
            Abstract();
            //KeyColumn("IDO");
            Map(x => x.Autor, "AUTOR");
            References(x => x.Zastita).Column("IDZASTITE").LazyLoad();


        }
    }
}
