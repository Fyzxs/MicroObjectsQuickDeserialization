using FluentTypes.Texts;

namespace FluentTypes.Numbers.Ints
{
    internal sealed class IntToText : Text
    {
        private readonly Int _origin;

        public IntToText(Int origin) => _origin = origin;

        protected override string Value() => ((int)_origin).ToString();
    }
}