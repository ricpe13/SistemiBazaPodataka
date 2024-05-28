namespace ZelenaPovrsina.Mapiranja
{
    internal class KlupaMapiranja : SubclassMap<Klupa>
    {
        public KlupaMapiranja()
        {
            Table("KLUPA");

            KeyColumn("IDO");
            Map(x => x.Materijal, "MATERIJAL");


        }
    }
}
