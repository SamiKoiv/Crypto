namespace Crypto.Salt
{
    public interface ISalt
    {
        byte[] CreateSalt(int length);
    }
}
