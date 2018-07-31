using FluentTypes.Numbers.Dbls;
using FluentTypes.Numbers.Ints;

namespace FluentTypes.Numbers
{
    /*
     * Numbers haven't been used extensively yet.
     * A good implementation of the variance between int, double, float, etc
     * is yet to be known.
     * This is a temporary solution until better ways show themselves.
     */
    public abstract class Number
    {
        public abstract Int AsInt();
        public abstract Dbl AsDbl();
    }
}
