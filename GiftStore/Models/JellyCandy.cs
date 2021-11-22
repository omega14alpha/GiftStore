using GiftStore.Enums;

namespace GiftStore.Models
{
    public class JellyCandy : Sweetness
    {
        public ThickeningAgent ThickeningAgent { get; set; }

        public override string GetSweetnessInfo()
        {
            string info = base.GetSweetnessInfo() + $", thickening agent - {ThickeningAgent}";
            return info;
        }
    }
}
