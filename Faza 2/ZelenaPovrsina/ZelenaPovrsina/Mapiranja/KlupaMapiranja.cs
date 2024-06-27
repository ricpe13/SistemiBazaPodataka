namespace ZelenaPovrsina.Mapiranja
{
    public class KlupaMapiranja : SubclassMap<Klupa>
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
