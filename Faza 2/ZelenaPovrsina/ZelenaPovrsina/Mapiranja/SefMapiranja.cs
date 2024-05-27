using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

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
