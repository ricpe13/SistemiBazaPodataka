namespace ZelenaPovrsina.Entiteti
{
    public class Drvored : ZelenaPovrsina
    {
        public virtual string Ulica { get; set; }
        public virtual double Duzina { get; set; }
        public virtual string VrstaDrveta { get; set; }
        public virtual int BrojStabala { get; set; }
    }
}