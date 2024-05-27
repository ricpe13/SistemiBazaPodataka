using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class KlupaMapiranja : SubclassMap<Klupa>
    {
        public KlupaMapiranja()
        {
            Table("KLUPA");

            //Abstract();
            Map(x => x.Materijal, "MATERIJAL");


        }
    }
}
