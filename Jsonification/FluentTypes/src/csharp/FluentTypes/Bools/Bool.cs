using System.Diagnostics;

namespace FluentTypes.Bools
{

    [DebuggerDisplay("{Value()}")]
    public abstract class Bool
    {
        public static readonly Bool True = new BoolOf(true);
        public static readonly Bool False = new BoolOf(false);

        public static implicit operator bool(Bool origin) => origin.Value();

        protected abstract bool Value();
    }
}