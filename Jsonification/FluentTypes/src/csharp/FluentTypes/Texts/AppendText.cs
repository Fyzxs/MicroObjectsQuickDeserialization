namespace FluentTypes.Texts
{
    internal sealed class AppendText : Text
    {
        private readonly Text _origin;
        private readonly Text _suffix;

        public AppendText(Text origin, Text suffix)
        {
            _origin = origin;
            _suffix = suffix;
        }

        protected override string Value() => _origin + _suffix;
    }
}