namespace ZelenaPovrsina.Mapiranja
    {
        public class DecijeIgralisteMapiranja : SubclassMap<DecijeIgraliste>
        {
            public DecijeIgralisteMapiranja()
            {
                Table("DECIJE_IGRALISTE");

                KeyColumn("IDO");

                Map(x => x.BrIgracaka, "BRIGRACAKA");
                Map(x => x.Pesak, "PESAK");
                Map(x => x.Starost, "STAROST");
            }
    }
}
