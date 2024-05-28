namespace ZelenaPovrsina.Mapiranja
{
    internal class FontanaMapiranja : SubclassMap<Fontana>
    {
        public FontanaMapiranja()
        {
            Table("FONTANA");

            //Abstract();
            Map(x => x.BrPrskalica, "BRPRSKALICA");
            Map(x => x.PovrsinaF, "POVRSINAF");

        }
    }
}
