using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.Entiteti
{
    public class ZasticeniObjekat
    {
        public virtual int IdZO { get; protected set; }
        //public virtual int IdZastite { get; set; }

        public virtual Zastita PodZastitomZO { get; set; }
        public virtual Objekat Objekat { get; set; }
    }
}