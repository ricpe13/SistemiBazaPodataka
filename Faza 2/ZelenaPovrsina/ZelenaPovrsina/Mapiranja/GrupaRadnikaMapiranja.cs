using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class GrupaRadnikaMapiranja : ClassMap<ZelenaPovrsina.Entiteti.GrupaRadnika>
    {
        public GrupaRadnikaMapiranja()
        {
            Table("GRUPA_RADNIKA");

            Id(x => x.IdG, "IDG").GeneratedBy.TriggerIdentity();

            Map(x => x.NazivG, "NAZIVG");
            //Map(x => x.IdParka, "IDPARKA");


            // HasMany(x => x.RadniciGrupe).KeyColumn("IDGRUPE"); //najbolje je da se koristi ovo sto nije zakomentarisano
            // HasMany(x => x.RadniciGrupe).KeyColumn("IDGRUPE").LazyLoad().Cascade.All();
            HasMany(x => x.RadniciGrupe).KeyColumn("IDGRUPE").LazyLoad().Cascade.All().Inverse();
            References(x => x.Park, "IDPARKA").Unique(); //trebalo bi da je ovako za one to one
            HasOne(x => x.Sef).PropertyRef(x => x.GrupaRadnika);
        }
    }
}
