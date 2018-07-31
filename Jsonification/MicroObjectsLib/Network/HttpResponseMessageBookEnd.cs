using FluentTypes.Exceptions;
using System.Net.Http;

namespace MicroObjectsLib.Network
{
    public sealed class HttpResponseMessageBookEnd : IHttpResponseMessageBookEnd
    {
        public static readonly IHttpResponseMessageBookEnd NullObject = new NullHttpResponseMessageBookEnd();

        private readonly HttpResponseMessage _httpResponseMessage;

        public HttpResponseMessageBookEnd(HttpResponseMessage httpResponseMessage) => _httpResponseMessage = httpResponseMessage;

        public IHttpContentBookEnd Content() => new HttpContentBookEnd(_httpResponseMessage.Content);
    }

    public interface IHttpResponseMessageBookEnd
    {
        IHttpContentBookEnd Content();
    }

    internal sealed class NullHttpResponseMessageBookEnd : IHttpResponseMessageBookEnd
    {
        private static bool _onlyOnce;

        internal NullHttpResponseMessageBookEnd()
        {
            if (_onlyOnce) throw new NullObjectInstantiationException();
            _onlyOnce = true;
        }

        public IHttpContentBookEnd Content() => HttpContentBookEnd.NullObject;
    }
}