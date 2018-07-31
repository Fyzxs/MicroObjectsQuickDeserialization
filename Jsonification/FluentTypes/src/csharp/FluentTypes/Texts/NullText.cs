using FluentTypes.Exceptions;

namespace FluentTypes.Texts
{
    internal sealed class NullText : Text
    {
        private static bool _onlyOnce;

        internal NullText()
        {
            if (_onlyOnce) throw new NullObjectInstantiationException();
            _onlyOnce = true;
        }

        /*
         * The value returned for `NullText` should be updated to whatever
         * is appropriate for the including system. An EmptyString has always
         * been successful so far for me. Feel free to leave it if it works.
         */
        protected override string Value() => string.Empty;
    }
}