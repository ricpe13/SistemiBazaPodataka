namespace ZelenaPovrsina.Mapiranja
{
    public class SvetiljkaMapiranja : SubclassMap<Svetiljka>
    {
        public SvetiljkaMapiranja()
        {
            Table("SVETILJKA");
            //Abstract();
            KeyColumn("IDO");
            Map(x => x.BrSijalica, "BRSIJALICA");

        }
    }
}
