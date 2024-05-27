using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class TravnjakMapiranja : SubclassMap<Travnjak>
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
