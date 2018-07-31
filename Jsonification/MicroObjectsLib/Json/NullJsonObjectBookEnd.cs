using FluentTypes.Bools;
using FluentTypes.Texts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroObjectsLib.Json
{
    public sealed class NullJsonObjectBookEnd : IJsonObjectBookEnd
    {
        public static readonly IJsonObjectBookEnd Instance = new NullJsonObjectBookEnd();

        private NullJsonObjectBookEnd() { }

        public Task<Text> TextValue(Text key) => Task.FromResult(Text.NullObject);

        public Task<IJsonObjectBookEnd> SubObject(Text key) => Task.FromResult(this as IJsonObjectBookEnd);

        public Task<List<IJsonObjectBookEnd>> SubObjects(Text key) => Task.FromResult(new List<IJsonObjectBookEnd>());

        public Task<Bool> HasValue(Text key) => Task.FromResult(Bool.False);
    }
}