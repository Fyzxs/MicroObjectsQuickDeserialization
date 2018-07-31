namespace FluentTypes.Numbers.Ints
{
    public sealed class IntOf : Int
    {
        private readonly int _origin;

        public IntOf(int origin) => _origin = origin;

        protected override int Value() => _origin;
    }
}