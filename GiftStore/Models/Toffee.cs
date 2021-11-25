using GiftStore.Enums;

namespace GiftStore.Models
{
    public class Toffee : Candy
    {
        public Consistency Consistency { get; set; }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + $", consistency - {Consistency}";
    }
}
