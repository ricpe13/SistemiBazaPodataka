namespace ZelenaPovrsina.Mapiranja
{
    internal class KlupaMapiranja : SubclassMap<Klupa>
    {
        public KlupaMapiranja()
        {
            Table("KLUPA");
            Abstract();
            //KeyColumn("IDO");
            Map(x => x.Materijal, "MATERIJAL");


        }
    }
}
