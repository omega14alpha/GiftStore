using GiftStore.Enums;

namespace GiftStore.Models
{
    public class Nougat : Candy
    {
        public Nuts Nuts { get; set; }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + $", nuts - {Nuts}";
    }
}
