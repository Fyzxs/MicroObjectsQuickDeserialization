using System.Net.Http.Headers;

namespace MicroObjectsLib.Network.MediaTypes
{
    public abstract class MediaType
    {
        public static implicit operator MediaTypeWithQualityHeaderValue(MediaType origin) => origin.QualityValue();

        public static implicit operator MediaTypeHeaderValue(MediaType origin) => origin.Value();

        protected abstract MediaTypeWithQualityHeaderValue QualityValue();

        protected abstract MediaTypeHeaderValue Value();
    }
}