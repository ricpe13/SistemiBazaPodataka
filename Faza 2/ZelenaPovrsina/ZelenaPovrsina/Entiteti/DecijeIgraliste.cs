using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.Entiteti
{
    public class DecijeIgraliste : Objekat
    {
        public virtual int BrIgracaka { get; set; }
        public virtual int Pesak { get; set; }
        public virtual int Starost { get; set; }
        
    }
}