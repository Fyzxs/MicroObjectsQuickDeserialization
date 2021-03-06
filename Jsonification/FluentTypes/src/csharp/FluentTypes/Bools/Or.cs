﻿namespace FluentTypes.Bools
{
    internal sealed class Or : Bool
    {
        private readonly Bool _boolA;
        private readonly Bool _boolB;

        public Or(Bool boolA, Bool boolB)
        {
            _boolA = boolA;
            _boolB = boolB;
        }

        protected override bool Value() => _boolA || _boolB;
    }
}