using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZelenaPovrsina.Entiteti;

namespace ZelenaPovrsina.Mapiranja
{
    internal class DrvoredMapiranja : SubclassMap<Drvored>
    {
        public DrvoredMapiranja()
        {
            Table("DRVORED");

            KeyColumn("IDZ");

            Map(x => x.Ulica, "ULICA");
            Map(x => x.Duzina, "DUZINA");
            Map(x => x.VrstaDrveta, "VRSTADRVETA");
            Map(x => x.BrojStabala, "BROJSTABALA");
        }
    }
}
