namespace ZelenaPovrsina.Entiteti
{
    public class Objekat
    {
        public virtual required ObjekatId Id { get; set; }

        public virtual string TipZO { get; set; }
        public virtual int IdZastite { get; set; }
        public virtual string NazivSpom { get; set; }
        public virtual string AutorSkul { get; set; }
        public virtual int IdParka { get; set; }  //ne znam da li treba ovo
        public virtual int RedniBr { get; set; } //ne znam da li treba ovo

        public virtual Park Park { get; set; }

        
    }
}
