using System.Net.Http.Headers;

namespace MicroObjectsLib.Network.MediaTypes
{
    public sealed class ApplicationJsonMediaType : MediaType
    {
        private const string JsonType = "application/json";

        protected override MediaTypeWithQualityHeaderValue QualityValue() => new MediaTypeWithQualityHeaderValue(JsonType);

        protected override MediaTypeHeaderValue Value() => new MediaTypeHeaderValue(JsonType);
    }
}