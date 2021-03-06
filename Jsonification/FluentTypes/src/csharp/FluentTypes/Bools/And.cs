﻿namespace FluentTypes.Bools
{
    internal sealed class And : Bool
    {
        private readonly Bool _boolA;
        private readonly Bool _boolB;

        public And(Bool boolA, Bool boolB)
        {
            _boolA = boolA;
            _boolB = boolB;
        }

        protected override bool Value() => _boolA && _boolB;
    }
}