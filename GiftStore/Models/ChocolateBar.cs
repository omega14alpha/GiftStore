namespace GiftStore.Models
{
    public class ChocolateBar : Sweetness
    {
        public int PercentageCocoaContent { get; set; }

        public bool WithNuts { get; set; }

        public override string GetSweetnessInfo()
        {
            string nuts = WithNuts ? ", with nuts" : string.Empty;
            string info = base.GetSweetnessInfo() + $", cocoa content - {PercentageCocoaContent} %{nuts}";
            return info;
        }
    }
}
