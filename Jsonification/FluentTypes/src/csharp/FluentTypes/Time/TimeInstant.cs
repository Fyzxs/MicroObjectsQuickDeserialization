using System;

namespace FluentTypes.Time
{
    public abstract class TimeInstant
    {
        public static implicit operator DateTime(TimeInstant origin) => origin.Value();
        
        protected abstract DateTime Value();
    }
}