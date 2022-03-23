namespace LA.Economy.Interfaces.Helpers
{
    public interface IDataRecorder
    {
        Task RecordSellAsync(string type, string value, string date);
    }
}