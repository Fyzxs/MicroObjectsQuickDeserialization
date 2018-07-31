using FluentTypes.Exceptions;
using FluentTypes.Urls;
using MicroObjectsLib.Network.Auth;
using MicroObjectsLib.Network.MediaTypes;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroObjectsLib.Network
{
    public sealed class HttpClientBookEnd : IHttpClientBookEnd
    {
        public static readonly IHttpClientBookEnd NullObject = new NullHttpClientBookEnd();

        private readonly HttpClient _httpClient;

        public HttpClientBookEnd() : this(new HttpClient()) { }

        private HttpClientBookEnd(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<IHttpClientBookEnd> AuthorizationHeader(IAuthenticationHeader authenticationHeader)
        {
            _httpClient.DefaultRequestHeaders.Authorization = await authenticationHeader.Value();
            return this;
        }

        public Task<IHttpClientBookEnd> AddAcceptHeader(MediaType mediaType)
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(mediaType);
            return Task.FromResult(this as IHttpClientBookEnd);
        }

        public async Task<IHttpResponseMessageBookEnd> Post(Url url, HttpContent content) =>
            new HttpResponseMessageBookEnd(await _httpClient.PostAsync(url, content));

        public async Task<IHttpResponseMessageBookEnd> Get(Url url) => new HttpResponseMessageBookEnd(await _httpClient.GetAsync(url));
    }

    public interface IHttpClientBookEnd
    {
        Task<IHttpClientBookEnd> AuthorizationHeader(IAuthenticationHeader authenticationHeader);
        Task<IHttpClientBookEnd> AddAcceptHeader(MediaType mediaType);
        Task<IHttpResponseMessageBookEnd> Post(Url url, HttpContent content);
        Task<IHttpResponseMessageBookEnd> Get(Url url);
    }

    internal sealed class NullHttpClientBookEnd : IHttpClientBookEnd
    {
        private static bool _onlyOnce;

        internal NullHttpClientBookEnd()
        {
            if (_onlyOnce) throw new NullObjectInstantiationException();
            _onlyOnce = true;
        }

        public Task<IHttpClientBookEnd> AuthorizationHeader(IAuthenticationHeader authenticationHeader) => Task.FromResult(this as IHttpClientBookEnd);

        public Task<IHttpClientBookEnd> AddAcceptHeader(MediaType mediaType) => Task.FromResult(this as IHttpClientBookEnd);

        public Task<IHttpResponseMessageBookEnd> Post(Url url, HttpContent content) => Task.FromResult(HttpResponseMessageBookEnd.NullObject);

        public Task<IHttpResponseMessageBookEnd> Get(Url url) => Task.FromResult(HttpResponseMessageBookEnd.NullObject);
    }
}