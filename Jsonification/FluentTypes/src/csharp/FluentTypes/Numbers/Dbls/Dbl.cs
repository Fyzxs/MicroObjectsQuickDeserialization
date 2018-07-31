using FluentTypes.Numbers.Ints;

namespace FluentTypes.Numbers.Dbls
{
    public abstract class Dbl : Number
    {
        public static implicit operator double(Dbl origin) => origin.Value();

        protected abstract double Value();

        public sealed override Int AsInt() => new DblToInt(this);

        public sealed override Dbl AsDbl() => this;
    }
}