using System;
using System.Collections.Generic;
using System.Linq;
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
            
        }
    }
}
