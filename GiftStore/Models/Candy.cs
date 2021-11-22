namespace GiftStore.Models
{
    public class Candy : Sweetness
    {
        public string Taste { get; set; }

        public override string GetSweetnessInfo()
        {
            string info = base.GetSweetnessInfo() + $", taste - {Taste}";
            return info;
        }
    }
}
