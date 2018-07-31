using FluentTypes.ByteArrays;
using System.Text;

namespace FluentTypes.Texts
{
    internal sealed class ByteArrayToLowercaseHexText : Text
    {
        private static readonly Text LowercaseHexFormat = new TextOf("x2");
        private readonly ByteArray _bytes;

        public ByteArrayToLowercaseHexText(ByteArray bytes) => _bytes = bytes;

        protected override string Value()
        {
            StringBuilder hashString = new StringBuilder();

            foreach (byte item in (byte[])_bytes)
            {
                hashString.Append(item.ToString(LowercaseHexFormat));
            }

            return hashString.ToString();
        }
    }
}