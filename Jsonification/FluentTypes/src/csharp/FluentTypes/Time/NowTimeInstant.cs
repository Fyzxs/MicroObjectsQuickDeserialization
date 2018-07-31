using System;

namespace FluentTypes.Time
{
    public sealed class NowTimeInstant : TimeInstant
    {
        private readonly DateTime _origin;

        public NowTimeInstant() : this(DateTime.Now) { }

        private NowTimeInstant(DateTime origin) => _origin = origin;

        protected override DateTime Value() => _origin;
    }
}