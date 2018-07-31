using FluentTypes.Bools;
using FluentTypes.Texts;
using MicroObjectsLib.Cache;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroObjectsLib.Json
{
    public sealed class JsonObjectBookEnd : IJsonObjectBookEnd
    {
        private readonly Text _text;
        private readonly ICache<JObject> _cache;

        public JsonObjectBookEnd(Text text) : this(text, new ClassCache<JObject>()) { }

        public JsonObjectBookEnd(Text text, ICache<JObject> classCache)
        {
            _text = text;
            _cache = classCache;
        }

        public async Task<Text> TextValue(Text key) => await HasValue(key)
            ? new TextOf((await Cached()).Value<string>((string)key))
            : Text.NullObject;

        public async Task<IJsonObjectBookEnd> SubObject(Text key)
        {
            return await HasValue(key)
                ? new JsonObjectBookEnd(JTokenToText((await Cached())[key]))
                : NullJsonObjectBookEnd.Instance;
        }

        public async Task<List<IJsonObjectBookEnd>> SubObjects(Text key) =>
            ((await Cached())[key] as JArray)?.Children().Select(ToJsonObject).ToList() ?? new List<IJsonObjectBookEnd>();

        public async Task<Bool> HasValue(Text key)
        {
            JToken jToken = (await Cached())[key];
            return new BoolOf(jToken != null && JTokenType.Null != jToken.Type);
        }

        private static IJsonObjectBookEnd ToJsonObject(JToken jsonObject) => new JsonObjectBookEnd(JTokenToText(jsonObject));

        private static Text JTokenToText(JToken token) => new TextOf(token.ToString(Formatting.None));

        private Task<JObject> Cached()
        {
            return _cache.Retrieve(() =>
            {
                try
                {
                    return Task.FromResult(JObject.Parse(_text));

                }
                catch
                {
                    return Task.FromResult(new JObject());
                }
            });
        }
    }

    public interface IJsonObjectBookEnd
    {
        Task<Text> TextValue(Text key);
        Task<IJsonObjectBookEnd> SubObject(Text key);
        Task<List<IJsonObjectBookEnd>> SubObjects(Text key);
        Task<Bool> HasValue(Text key);
    }
}