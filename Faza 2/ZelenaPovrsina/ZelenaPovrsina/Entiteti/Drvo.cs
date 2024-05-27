using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.Entiteti
{
    public class Drvo : Objekat
    {
        public virtual int VisinaKrosnje { get; set; }
        public virtual string Vrsta { get; set; }
        public virtual DateTime DatumSadnje { get; set; }
        public virtual double PovrsinaK { get; set; }
        public virtual double ObimDebla { get; set; }
        

        public virtual Zastita PodZastitomDrvo { get; set; }
    }
}