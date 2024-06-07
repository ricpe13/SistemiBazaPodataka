namespace ZelenaPovrsina.Mapiranja
{
    internal class SefMapiranja : ClassMap<ZelenaPovrsina.Entiteti.Sef>
    {
        public SefMapiranja()
        {
            Table("SEF");

            Id(x => x.IdRad, "IDRAD").GeneratedBy.TriggerIdentity();

            Map(x => x.Matbr, "MATBR");

            References(x => x.GrupaRadnika, "IDGRUPE").Unique();
        }
    }
}
