namespace FluentTypes.Texts
{
    public sealed class TextOf : Text
    {
        private readonly string _value;

        public TextOf(string value) => _value = value;

        protected override string Value() => _value;
    }
}