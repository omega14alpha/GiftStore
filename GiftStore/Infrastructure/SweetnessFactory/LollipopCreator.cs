using GiftStore.Models;
using System.Drawing;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class LollipopCreator : Factory
    {
        public override Lollipop CreateSweetness()
        {
            Lollipop[] lollipops = new Lollipop[]
                {
                    new Lollipop() { Name = "GoldenKey", Weight = 23.1f, SugarContent = 12.6f, Taste = "Lemon", Color = Color.GreenYellow },
                    new Lollipop() { Name = "Barberry", Weight = 16.9f, SugarContent = 9.01f, Taste = "Barberry", Color = Color.OrangeRed }
                };

            int index = _random.Next(0, lollipops.Length);
            return lollipops[index];
        }
    }
}
