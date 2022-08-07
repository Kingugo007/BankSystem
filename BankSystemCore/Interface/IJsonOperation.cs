namespace BankSystemCore.Interface
{
    public interface IJsonOperation
    {
        string _data { get; set; }
        Task<List<T>> ReadJson<T>(string jsonFile);
        Task<bool> WriteJson<T>(T model, string jsonFile);
    }
}