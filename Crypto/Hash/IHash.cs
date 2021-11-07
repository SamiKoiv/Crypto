namespace Crypto.Hash
{
    public interface IHash
    {
        public byte[] ComputeHash(byte[] input);
    }
}
