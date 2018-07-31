namespace FluentTypes.Bools
{
    internal sealed class Nor : Bool
    {
        private readonly Bool _boolResult;

        public Nor(Bool boolA, Bool boolB) : this(new Not(new Or(boolA, boolB))) { }
        private Nor(Bool boolResult) => _boolResult = boolResult;

        protected override bool Value() => _boolResult;
    }
}