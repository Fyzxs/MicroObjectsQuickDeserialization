using FluentTypes.Bools;

namespace FluentTypes.Texts
{
    internal sealed class AreEqualText : Bool
    {
        private readonly Text _origin;
        private readonly Text _target;

        public AreEqualText(Text origin, Text target)
        {
            _origin = origin;
            _target = target;
        }

        protected override bool Value() => string.Equals(_origin, _target);
    }
}