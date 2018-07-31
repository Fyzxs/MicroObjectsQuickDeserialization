using FluentTypes.Numbers.Ints;

namespace FluentTypes.Numbers.Dbls
{
    public sealed class DblToInt : Int
    {
        private readonly Dbl _origin;

        public DblToInt(Dbl origin)
        {
            _origin = origin;
        }

        protected override int Value() => (int)(double)_origin;
    }
}