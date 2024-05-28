namespace ZelenaPovrsina.Mapiranja
{
    internal class SvetiljkaMapiranja : SubclassMap<Svetiljka>
    {
        public SvetiljkaMapiranja()
        {
            Table("SVETILJKKA");

            KeyColumn("IDO");
            Map(x => x.BrSijalica, "BRSIJALICA");

        }
    }
}
