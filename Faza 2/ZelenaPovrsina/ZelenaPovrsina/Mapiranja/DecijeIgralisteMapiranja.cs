using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
    {
        internal class DecijeIgralisteMapiranja : SubclassMap<DecijeIgraliste>
    {
        public DecijeIgralisteMapiranja()
        {
            Table("DECIJE_IGRALISTE");

            Abstract();

            Map(x => x.BrIgracaka, "BRIGRACAKKA");
            Map(x => x.Pesak, "PESAK");
            Map(x => x.Starost, "STAROST");
        }
    }
}
