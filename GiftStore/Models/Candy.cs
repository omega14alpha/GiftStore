namespace GiftStore.Models
{
    public abstract class Candy : Sweetness
    {
        public string Taste { get; set; }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + $", taste - {Taste}";
    }
}
