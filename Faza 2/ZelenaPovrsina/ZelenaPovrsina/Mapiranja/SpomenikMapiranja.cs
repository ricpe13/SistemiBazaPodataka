using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.Mapiranja
{
    public class SpomenikMapiranja : SubclassMap<Spomenik>
    {
        public SpomenikMapiranja()
        {
            Table("SPOMENIK");
            Abstract();
            //KeyColumn("IDO");
            Map(x => x.NazivS, "NAZIVS");
            References(x => x.Zastita).Column("IDZASTITE").LazyLoad();



        }
    }
}
