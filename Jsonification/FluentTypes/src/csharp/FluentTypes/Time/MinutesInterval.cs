using System;

namespace FluentTypes.Time
{
    public sealed class MinutesInterval : TimeInterval
    {
        private readonly double _minutes;

        public MinutesInterval(double minutes) => _minutes = minutes;

        protected override TimeSpan Value() => TimeSpan.FromMinutes(_minutes);
    }
}