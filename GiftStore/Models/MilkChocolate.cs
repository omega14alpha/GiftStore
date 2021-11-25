namespace GiftStore.Models
{
    public class MilkChocolate : ChocolateBar
    {
        public float MilkFatContent { get; set; }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + $", milk fat content - {MilkFatContent}";
    }
}
