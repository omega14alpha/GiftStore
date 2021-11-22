namespace GiftStore.Infrastructure
{
    public interface IGift
    {
        string Message { get; set; }

        float GetGiftWeight();
    }
}
