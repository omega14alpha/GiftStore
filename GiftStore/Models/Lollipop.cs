using System.Drawing;

namespace GiftStore.Models
{
    public class Lollipop : Candy
    {
        public Color Color { get; set; }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + $", Color - {Color.Name}";
    }
}
