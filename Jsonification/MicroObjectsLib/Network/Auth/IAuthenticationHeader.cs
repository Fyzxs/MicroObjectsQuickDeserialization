using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MicroObjectsLib.Network.Auth
{
    public interface IAuthenticationHeader
    {
        Task<AuthenticationHeaderValue> Value();
    }
}