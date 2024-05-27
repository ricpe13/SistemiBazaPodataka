using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class ZasticeniObjekatMapiranja : ClassMap<ZelenaPovrsina.Entiteti.ZasticeniObjekat>
    {
        public ZasticeniObjekatMapiranja()
        {
            Table("ZASTICENI_OBJEKAT");

            Id(x => x.IdZO, "IDZO").GeneratedBy.TriggerIdentity();

            //Map(x => x.IdZastite, "IDZASTITE");

            References(x => x.PodZastitomZO).Column("IDZASTITE").LazyLoad();
            References(x => x.Objekat).Columns("IdParka", "RedniBr");
        }
    }
}
