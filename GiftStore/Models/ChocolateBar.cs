namespace GiftStore.Models
{
    public abstract class ChocolateBar : Sweetness
    {
        public int PercentageCocoaContent { get; set; }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + $", cocoa content - {PercentageCocoaContent}";        
    }
}
