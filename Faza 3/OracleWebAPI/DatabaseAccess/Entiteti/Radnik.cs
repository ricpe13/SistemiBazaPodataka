namespace DatabaseAccess.Entiteti
{
    internal class Radnik
    {
        internal protected virtual int IdR { get; protected set; }
        internal protected virtual string? Ime { get; set; }
        internal protected virtual string? Prezime { get; set; }
        internal protected  virtual string? Jmbg { get; set; }
        internal protected  virtual string? Adresa { get; set; }
        internal protected virtual int? BrRadneKnjizice { get; set; }
        internal protected virtual string? ImeRoditelja { get; set; }
        internal protected virtual string? StrucnaSprema { get; set; }
        internal protected virtual DateTime? DatumRodj { get; set; }
        internal protected virtual int? ZaZelenilo { get; set; }
        internal protected virtual int? ZaHigijenu { get; set; }
        internal protected virtual int? ZaObjekat { get; set; }


        internal protected virtual GrupaRadnika? PripadaGrupi { get; set; }

        internal protected virtual ZelenaPovrsina? AngazovanZaZP { get; set; }


        internal Radnik() 
        {

        }

    }
}