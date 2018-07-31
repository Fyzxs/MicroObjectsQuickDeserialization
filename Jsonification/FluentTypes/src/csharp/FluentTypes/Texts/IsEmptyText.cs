using FluentTypes.Bools;

namespace FluentTypes.Texts
{
    internal sealed class IsEmptyText : Bool
    {
        private readonly Text _origin;

        public IsEmptyText(Text origin) => _origin = origin;

        protected override bool Value() => string.IsNullOrWhiteSpace(_origin);
    }
}