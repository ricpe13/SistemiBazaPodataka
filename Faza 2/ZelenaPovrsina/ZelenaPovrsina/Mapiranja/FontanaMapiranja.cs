namespace ZelenaPovrsina.Mapiranja
{
    public class FontanaMapiranja : SubclassMap<Fontana>
    {
        public FontanaMapiranja()
        {
            Table("FONTANA");

            //Abstract();
            KeyColumn("IDO");
            Map(x => x.BrPrskalica, "BRPRSKALICA");
            Map(x => x.PovrsinaF, "POVRSINAF");

        }
    }
}
