using GiftStore.Enums;

namespace GiftStore.Models
{
    public abstract class JellyCandy : Sweetness
    {
        public ThickeningAgent ThickeningAgent { get; protected set; }

        public override string GetSweetnessInfo() =>
            base.GetSweetnessInfo() + $", thickening agent - {ThickeningAgent}";
    }
}
