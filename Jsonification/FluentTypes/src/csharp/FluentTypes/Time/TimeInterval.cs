using System;

namespace FluentTypes.Time
{
    public abstract class TimeInterval
    {
        public static implicit operator TimeSpan(TimeInterval origin) => origin.Value();

        protected abstract TimeSpan Value();
    }
}