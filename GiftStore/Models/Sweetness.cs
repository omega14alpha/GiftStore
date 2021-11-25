namespace GiftStore.Models
{
    public abstract class Sweetness
    {
        public string Name { get; set; }

        public float SugarContent { get; set; }

        public float Weight { get; set; }

        public virtual string GetSweetnessInfo() =>
            $"{Name}, sugar content - {SugarContent}, weight - {Weight}";        
    }
}
