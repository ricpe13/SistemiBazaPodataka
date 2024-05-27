using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.Entiteti
{
    public class Travnjak : ZelenaPovrsina
    {
        public virtual string AdresaZgrade { get; set; }
        public virtual int PovrsinaT { get; set; }
    }
}