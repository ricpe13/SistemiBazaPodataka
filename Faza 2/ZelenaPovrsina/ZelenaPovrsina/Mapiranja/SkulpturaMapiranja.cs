using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.Mapiranja
{
    internal class SkulpturaMapiranja : SubclassMap<Skulptura>
    {
        public SkulpturaMapiranja()
        {
            Table("SKULPTURA");

            KeyColumn("IDO");
            Map(x => x.Autor, "AUTOR");
            References(x => x.Zastita).Column("IDZASTITE").LazyLoad();


        }
    }
}
