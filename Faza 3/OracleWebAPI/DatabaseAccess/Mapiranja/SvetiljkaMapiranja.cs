namespace DatabaseAccess.Mapiranja
{
    internal class SvetiljkaMapiranja : SubclassMap<Svetiljka>
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
