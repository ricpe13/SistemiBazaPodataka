namespace ZelenaPovrsina.Mapiranja
{
    internal class KlupaMapiranja : SubclassMap<Klupa>
    {
        public KlupaMapiranja()
        {
            Table("KLUPA");

            //Abstract();
            Map(x => x.Materijal, "MATERIJAL");


        }
    }
}
