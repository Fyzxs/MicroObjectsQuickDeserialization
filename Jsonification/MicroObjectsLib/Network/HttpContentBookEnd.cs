using FluentTypes.Exceptions;
using FluentTypes.Texts;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroObjectsLib.Network
{
    public sealed class HttpContentBookEnd : IHttpContentBookEnd
    {
        public static readonly IHttpContentBookEnd NullObject = new NullHttpContentBookEnd();

        private readonly HttpContent _httpContent;

        public HttpContentBookEnd(HttpContent httpContent) => _httpContent = httpContent;

        public async Task<Text> AsText() => new TextOf(await _httpContent.ReadAsStringAsync());
    }

    public interface IHttpContentBookEnd
    {
        Task<Text> AsText();
    }

    internal sealed class NullHttpContentBookEnd : IHttpContentBookEnd
    {
        private static bool _onlyOnce;

        internal NullHttpContentBookEnd()
        {
            if (_onlyOnce) throw new NullObjectInstantiationException();
            _onlyOnce = true;
        }
        public Task<Text> AsText() => Task.FromResult(Text.NullObject);
    }
}