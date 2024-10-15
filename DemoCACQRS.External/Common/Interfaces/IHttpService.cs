namespace DemoCACQRS.External.Common.Interfaces
{
    public interface IHttpService
    {
        Task<T> SendHttpRequest<T>(string url, HttpMethod httpMethod, object body = null, string bearer = null);
    }
}
