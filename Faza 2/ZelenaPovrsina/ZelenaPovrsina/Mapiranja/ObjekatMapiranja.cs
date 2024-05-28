﻿namespace ZelenaPovrsina.Mapiranja
{
    public class ObjekatMapiranja : ClassMap<ZelenaPovrsina.Entiteti.Objekat>
    {
        public ObjekatMapiranja()
        {
            CompositeId()
            .KeyReference(x => x.IdParka, "IdZ") //ovde mora ovako Reference, unutar navodnika mislim da je dobro
            .KeyProperty(x => x.RedniBr); //ne znam da li ovde treba da se napise ,"RedniBr" unutar zagrada

            References(x => x.Park).Column("IDPARKA").LazyLoad();
        }
        
    }
}