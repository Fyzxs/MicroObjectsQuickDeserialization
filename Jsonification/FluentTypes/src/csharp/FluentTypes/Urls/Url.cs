using FluentTypes.Texts;
using System;

namespace FluentTypes.Urls
{
    public abstract class Url
    {
        public static implicit operator Uri(Url origin) => new Uri(origin.Value());

        protected abstract Text Value();
    }
}
