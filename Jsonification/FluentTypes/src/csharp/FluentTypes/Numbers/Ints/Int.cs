using FluentTypes.Numbers.Dbls;

namespace FluentTypes.Numbers.Ints
{
    public abstract class Int : Number
    {
        public static implicit operator int(Int origin) => origin.Value();

        protected abstract int Value();

        public sealed override Int AsInt() => this;

        public sealed override Dbl AsDbl()
        {
            throw new System.NotImplementedException();
        }
    }
}