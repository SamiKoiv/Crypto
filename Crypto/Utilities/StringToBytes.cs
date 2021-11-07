using System.Text;

namespace Crypto.Utilities
{
    public class StringToBytes : IStringToBytes
    {
        public byte[] GetBytes(string input) => Encoding.UTF8.GetBytes(input);
    }
}
