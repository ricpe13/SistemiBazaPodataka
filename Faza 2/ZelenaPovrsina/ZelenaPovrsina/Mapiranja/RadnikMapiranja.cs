namespace ZelenaPovrsina.Mapiranja
{
    internal class RadnikMapiranja : ClassMap<ZelenaPovrsina.Entiteti.Radnik>
    {
        public RadnikMapiranja()
        {
            //Mapiranje tabele
            Table("RADNIK");

            //mapiranje primarnog kljuca
            Id(x => x.IdR, "IDR").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Jmbg, "JMBG");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrRadneKnjizice, "BRRADNEKNJIZICE");
            Map(x => x.ImeRoditelja, "IMERODITELJA");
            Map(x => x.StrucnaSprema, "STRUCNASPREMA");
            Map(x => x.DatumRodj, "DATUMRODJ");
            Map(x => x.ZaZelenilo, "ZAZELENILO");
            Map(x => x.ZaHigijenu, "ZAHIGIJENU");
            Map(x => x.ZaObjekat, "ZAOBJEKAT");
            //Map(x => x.IdZP, "IDZP");
            //Map(x => x.IdGrupe, "IDGRUPE");

            References(x => x.PripadaGrupi).Column("IDGRUPE").LazyLoad();

            References(x => x.AngazovanZaZP).Column("IDZP").LazyLoad();
        }
    }
}
