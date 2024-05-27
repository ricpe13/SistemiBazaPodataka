using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.Entiteti
{
    public class Fontana : Objekat
    {
        public virtual string BrPrskalica { get; set; }
        public virtual string PovrsinaF { get; set; }
    }
}