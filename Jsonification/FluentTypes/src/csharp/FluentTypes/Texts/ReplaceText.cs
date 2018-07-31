namespace FluentTypes.Texts
{
    internal sealed class ReplaceText : Text
    {
        private readonly Text _origin;
        private readonly Text _token;
        private readonly Text _value;

        public ReplaceText(Text origin, Text token, Text value)
        {
            _origin = origin;
            _token = token;
            _value = value;
        }
        protected override string Value() => ((string)_origin).Replace(_token, _value);
    }
}