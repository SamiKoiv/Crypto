using Crypto.Salt;
using Konscious.Security.Cryptography;

namespace Crypto.Hash
{
    public class Argon2 : IHash
    {
        private ISalt _salt;

        public Argon2(ISalt salt)
        {
            _salt = salt;
        }

        public byte[] ComputeHash(byte[] input)
        {
            var argon2 = new Argon2id(input);
            argon2.Salt = _salt.CreateSalt(16);
            argon2.DegreeOfParallelism = 4;
            argon2.Iterations = 4;
            argon2.MemorySize = 1024 * 1024;

            var hash = argon2.GetBytes(16);

            return hash;
        }
    }
}
