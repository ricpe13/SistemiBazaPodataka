using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class SvetiljkaMapiranja : SubclassMap<Svetiljka>
    {
        public SvetiljkaMapiranja()
        {
            Table("SVETILJKKA");

            //Abstract();
            Map(x => x.BrSijalica, "BRSIJALICA");

        }
    }
}
