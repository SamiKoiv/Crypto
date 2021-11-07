using System.Security.Cryptography;

namespace Crypto.Hash
{
    public class MD5 : IHash
    {
        public byte[] ComputeHash(byte[] input)
        {
            using (var hashProvider = new MD5CryptoServiceProvider())
            {
                var encrypted = hashProvider.ComputeHash(input);
                return encrypted;
            }
        }
    }
}
