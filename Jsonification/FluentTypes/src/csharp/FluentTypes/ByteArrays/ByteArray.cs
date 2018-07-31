namespace FluentTypes.ByteArrays
{
    public abstract class ByteArray
    {
        public static implicit operator byte[] (ByteArray origin) => origin.Value();

        protected abstract byte[] Value();
    }
}