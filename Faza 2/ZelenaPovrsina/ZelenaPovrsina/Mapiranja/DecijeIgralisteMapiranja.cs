namespace ZelenaPovrsina.Mapiranja
    {
        internal class DecijeIgralisteMapiranja : SubclassMap<DecijeIgraliste>
        {
            public DecijeIgralisteMapiranja()
            {
                Table("DECIJE_IGRALISTE");

                KeyColumn("IDO");

                Map(x => x.BrIgracaka, "BRIGRACAKKA");
                Map(x => x.Pesak, "PESAK");
                Map(x => x.Starost, "STAROST");
            }
    }
}
