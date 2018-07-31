using FluentTypes.Texts;

namespace FluentTypes.Urls
{
    public sealed class UrlOf : Url
    {
        private readonly Text _origin;

        public UrlOf(string origin) : this(new TextOf(origin)) { }

        public UrlOf(Text origin) => _origin = origin;

        protected override Text Value() => _origin;
    }
}