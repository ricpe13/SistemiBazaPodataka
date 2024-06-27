namespace ZelenaPovrsina.Mapiranja
{
    public class TravnjakMapiranja : SubclassMap<Travnjak>
    {
        public TravnjakMapiranja()
        {
            Table("TRAVNJAK");

            KeyColumn("IDZ");

            Map(x => x.AdresaZgrade, "ADRESAZGRADE");
            Map(x => x.PovrsinaT, "POVRSINAT");
        }
    }
}
