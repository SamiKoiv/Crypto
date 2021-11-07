namespace Crypto.Hash
{
    public class SHA256 : IHash
    {
        public byte[] ComputeHash(byte[] input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hash = sha256.ComputeHash(input);
                return hash;
            }
        }
    }
}
