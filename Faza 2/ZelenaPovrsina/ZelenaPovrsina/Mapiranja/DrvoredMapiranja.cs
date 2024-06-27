namespace ZelenaPovrsina.Mapiranja
{
    public class DrvoredMapiranja : SubclassMap<Drvored>
    {
        public DrvoredMapiranja()
        {
            Table("DRVORED");

            KeyColumn("IDZ");

            Map(x => x.Ulica, "ULICA");
            Map(x => x.Duzina, "DUZINA");
            Map(x => x.VrstaDrveta, "VRSTADRVETA");
            Map(x => x.BrojStabala, "BROJSTABALA");
        }
    }
}
