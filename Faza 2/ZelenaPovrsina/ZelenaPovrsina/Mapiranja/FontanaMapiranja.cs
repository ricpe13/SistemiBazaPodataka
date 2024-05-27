using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class FontanaMapiranja : SubclassMap<Fontana>
    {
        public FontanaMapiranja()
        {
            Table("FONTANA");

            //Abstract();
            Map(x => x.BrPrskalica, "BRPRSKALICA");
            Map(x => x.PovrsinaF, "POVRSINAF");

        }
    }
}
