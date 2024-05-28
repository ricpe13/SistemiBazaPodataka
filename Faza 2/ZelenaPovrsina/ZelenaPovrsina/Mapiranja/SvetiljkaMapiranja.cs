namespace ZelenaPovrsina.Mapiranja
{
    internal class SvetiljkaMapiranja : SubclassMap<Svetiljka>
    {
        public SvetiljkaMapiranja()
        {
            Table("SVETILJKKA");

            //Abstract();
            Map(x => x.BrSijalica, "BRSIJALICA");

        }
    }
}
