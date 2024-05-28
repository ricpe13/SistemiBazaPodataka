
namespace ZelenaPovrsina.Entiteti
{
    public class ObjekatId
    {
        public virtual Park? Park { get; set; }
        public virtual int RedniBr { get; set; }

        #region Overrides   
        public override bool Equals(object? obj)
        {
            if(obj == null) 
                return false;
            if(ReferenceEquals(this,obj))  
                return true;
            ObjekatId compare = (obj as ObjekatId)!;
            return Park!.IdZ == compare!.Park!.IdZ && RedniBr == compare.RedniBr;
        }

        public override int GetHashCode()
        {
            return Park!.IdZ.GetHashCode();
        }

        #endregion
    }
}
