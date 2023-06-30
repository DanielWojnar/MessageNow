namespace MessageNow.Services
{
    public interface IHttpClientService
    {
        public Task<T> Get<T>(string uri) where T : class;
        public Task<bool> Post<T>(T body, string uri) where T : class;
        public Task<T2?> PostWithReturn<T1, T2>(T1 body, string uri) where T1 : class where T2 : class;
    }
}
