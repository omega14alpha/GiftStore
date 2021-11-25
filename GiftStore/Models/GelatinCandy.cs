using GiftStore.Enums;

namespace GiftStore.Models
{
    public class GelatinCandy : JellyCandy
    {
        public GelatinCandy()
        {
            ThickeningAgent = ThickeningAgent.Gelatin;
        }       
    }
}
