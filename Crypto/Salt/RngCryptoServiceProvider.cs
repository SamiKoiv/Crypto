using System.Security.Cryptography;

namespace Crypto.Salt
{
    public class RngCryptoServiceProvider : ISalt
    {
        public byte[] CreateSalt(int length)
        {
            var buffer = new byte[length];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);
            return buffer;
        }
    }
}
