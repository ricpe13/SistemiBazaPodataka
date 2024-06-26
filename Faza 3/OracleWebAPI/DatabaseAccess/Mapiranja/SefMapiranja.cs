﻿namespace DatabaseAccess.Mapiranja
{
    internal class SefMapiranja : ClassMap<DatabaseAccess.Entiteti.Sef>
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
