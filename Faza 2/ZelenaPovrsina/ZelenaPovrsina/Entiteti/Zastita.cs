using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.Entiteti
{
    public class Zastita
    {
        public virtual int IdZastite { get; protected set; }
        public virtual string Institucija { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual int NovcanaSredstva { get; set; }
        public virtual string OpisZnacaja { get; set; }

        public virtual IList<ZasticeniObjekat> ZasticeniObjekti { get; set; }
        public virtual IList<Drvo> Drvece { get; set; }

        public Zastita()
        {
            ZasticeniObjekti = new List<ZasticeniObjekat>();
            Drvece = new List<Drvo>();
        }
    }
}