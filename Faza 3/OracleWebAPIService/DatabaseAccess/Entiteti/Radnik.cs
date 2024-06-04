namespace ZelenaPovrsina.Entiteti
{
    public class Radnik
    {
        public virtual int IdR { get; protected set; }
        public  virtual string Ime { get; set; }
        public  virtual string Prezime { get; set; }
        public  virtual string Jmbg { get; set; }
        public  virtual string Adresa { get; set; }
        public virtual int BrRadneKnjizice { get; set; }
        public virtual string? ImeRoditelja { get; set; }
        public virtual string? StrucnaSprema { get; set; }
        public virtual DateTime DatumRodj { get; set; }
        public virtual int ZaZelenilo { get; set; }
        public virtual int ZaHigijenu { get; set; }
        public virtual int ZaObjekat { get; set; }
        

        public virtual GrupaRadnika PripadaGrupi { get; set; }

        public virtual ZelenaPovrsina AngazovanZaZP { get; set; }


        public Radnik() 
        {

        }

    }
}