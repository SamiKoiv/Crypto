using System.Text;

namespace Crypto.Utilities
{
    public class BytesToString : IBytesToString
    {
        public string GetString(byte[] hash)
        {
            var output = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                var character = hash[i];
                output.Append(character.ToString());
            }

            return output.ToString();
        }
    }
}
