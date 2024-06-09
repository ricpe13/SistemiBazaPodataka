namespace DatabaseAccess.DTOs
{
    public class RadnikPregled
    {
        public int IdR { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Jmbg { get; set; }
        public string? Adresa { get; set; }
        public int? BrRadneKnjizice { get; set; }
        public string? ImeRoditelja { get; set; }
        public int? ZaZelenilo { get; set; }
        public int? ZaHigijenu { get; set; }
        public int? ZaObjekat { get; set; }
        public string? StrucnaSprema { get; set; }
        public DateTime? DatumRodj { get; set; }
        public ZelenaPovrsinaPregled? AngazovanZaZP { get; set; }
        public GrupaRadnikaPregled? PripadaGrupi { get; set; }

        public RadnikPregled()
        {

        }

        internal RadnikPregled(Radnik? r)
        {
            if (r != null) {
                IdR = r.IdR;
                Ime = r.Ime;
                Prezime = r.Prezime;
                Jmbg = r.Jmbg;
                Adresa = r.Adresa;
                BrRadneKnjizice = r.BrRadneKnjizice;
                ImeRoditelja = r.ImeRoditelja;
                ZaZelenilo = r.ZaZelenilo;
                ZaHigijenu = r.ZaHigijenu;
                ZaObjekat = r.ZaObjekat;
                StrucnaSprema = r.StrucnaSprema;
                DatumRodj = r.DatumRodj;
                AngazovanZaZP = new ZelenaPovrsinaPregled(r.AngazovanZaZP);
                PripadaGrupi = new GrupaRadnikaPregled(r.PripadaGrupi);
            }
        }
    }
}
