namespace FluentTypes.Texts
{
    public abstract class Text
    {
        public static readonly Text NullObject = new NullText();

        public static implicit operator string(Text origin) => origin.Value();

        protected abstract string Value();
    }
}