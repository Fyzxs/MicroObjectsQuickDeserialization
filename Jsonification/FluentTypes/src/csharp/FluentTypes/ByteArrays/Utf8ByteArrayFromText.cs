using FluentTypes.Texts;
using System.Text;

namespace FluentTypes.ByteArrays
{
    internal sealed class Utf8ByteArrayFromText : ByteArray
    {
        private readonly Text _source;

        public Utf8ByteArrayFromText(Text source) => _source = source;

        protected override byte[] Value() => Encoding.UTF8.GetBytes(_source);
    }
}