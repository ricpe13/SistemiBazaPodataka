namespace ZelenaPovrsina.Mapiranja
{
    public class SvetiljkaMapiranja : SubclassMap<Svetiljka>
    {
        public SvetiljkaMapiranja()
        {
            Table("SVETILJKKA");
            Abstract();
            //KeyColumn("IDO");
            Map(x => x.BrSijalica, "BRSIJALICA");

        }
    }
}
