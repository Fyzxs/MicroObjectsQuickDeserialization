namespace FluentTypes.ByteArrays
{
    internal sealed class ByteArrayOf : ByteArray
    {
        private readonly byte[] _source;

        public ByteArrayOf(byte[] source) => _source = source;

        protected override byte[] Value() => _source;
    }
}