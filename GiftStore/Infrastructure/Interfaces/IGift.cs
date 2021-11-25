namespace GiftStore.Infrastructure.Interfaces
{
    public interface IGift
    {
        string Message { get; set; }

        float GetGiftWeight();
    }
}
