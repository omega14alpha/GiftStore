namespace GiftStore.Models
{
    public class WhiteChocolate : ChocolateBar 
    {
        public bool IsPorous { get; set; }

        public WhiteChocolate()
        {
            IsPorous = false;
        }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + (IsPorous ? ", porous" : "");
    }
}
