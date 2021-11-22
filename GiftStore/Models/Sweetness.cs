namespace GiftStore.Models
{
    public abstract class Sweetness
    {
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public float SugarContent { get; set; }

        public float Weight { get; set; }

        public virtual string GetSweetnessInfo()
        {
            string info = $"{Name}, manufacturer - '{Manufacturer}', sugar content - {SugarContent}, weight - {Weight}";
            return info;
        }
    }
}
