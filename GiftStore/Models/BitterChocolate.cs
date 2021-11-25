namespace GiftStore.Models
{
    public class BitterChocolate : ChocolateBar
    {
        public bool WithStuffing { get; set; }

        public BitterChocolate()
        {
            WithStuffing = false;
        }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + (WithStuffing ? ", with stuffing" : "");
    }
}
