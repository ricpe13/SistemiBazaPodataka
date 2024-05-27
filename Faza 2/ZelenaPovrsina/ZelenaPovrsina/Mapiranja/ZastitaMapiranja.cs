using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class ZastitaMapiranja : ClassMap<ZelenaPovrsina.Entiteti.Zastita>
    {
        public ZastitaMapiranja()
        {
            Table("ZASTITA");

            Id(x => x.IdZastite, "IDZASTITE").GeneratedBy.TriggerIdentity();

            Map(x => x.Institucija, "INSTITUCIJA");
            Map(x => x.DatumOd, "DATUMOD");
            Map(x => x.NovcanaSredstva, "NOVCANASREDSTVA");
            Map(x => x.OpisZnacaja, "OPISZNACAJA");

            // HasMany(x => x.ZasticeniObjekti).KeyColumn("IDZASTITE"); //najbolje je da se koristi ovo sto nije zakomentarisano
            // HasMany(x => x.ZasticeniObjekti).KeyColumn("IDZASTITE").LazyLoad().Cascade.All();
            HasMany(x => x.ZasticeniObjekti).KeyColumn("IDZASTITE").LazyLoad().Cascade.All().Inverse();

            // HasMany(x => x.Drvece).KeyColumn("IDZASTITE"); //najbolje je da se koristi ovo sto nije zakomentarisano
            // HasMany(x => x.Drvece).KeyColumn("IDZASTITE").LazyLoad().Cascade.All();
            HasMany(x => x.Drvece).KeyColumn("IDZASTITE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
