using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class DrvoMapiranja : SubclassMap<Drvo>
    {
        public DrvoMapiranja()
        {
            Table("DRVO");

            Abstract();
            Map(x => x.VisinaKrosnje, "VISINAKROSNJE");
            Map(x => x.Vrsta, "VRSTA");
            Map(x => x.DatumSadnje, "DATUMSADNJE");
            Map(x => x.PovrsinaK, "POVRSINAK");
            Map(x => x.ObimDebla, "OBIMDEBLA");
            

            References(x => x.PodZastitomDrvo).Column("IDZASTITE").LazyLoad();

            
        }
    }
}
