namespace Crypto.HMAC
{
    public interface IHMAC
    {
        string Encrypt(string input, string key);
        string Decrypt(string input, string key);
    }
}
