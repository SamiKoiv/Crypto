using Crypto.Hash;
using Crypto.Salt;
using Crypto.Utilities;
using System;

/// <summary>
/// 
/// Studies on cryptography concepts presented on:
/// https://www.youtube.com/watch?v=NuyzuNBFWxQ&list=WL&index=117
/// 
/// Concepts to consider:
/// - Time Attacks (Does hash comparison algorithm reveal the hash length by shortcutting if lengths don't match.)
/// 
/// </summary>

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a message: ");
            var input = Console.ReadLine();

            TestHash(input);
        }

        static void TestHash(string input)
        {
            var stringToBytes = new StringToBytes();
            var bytesToString = new BytesToString();

            IHash hasher = new Argon2(new RngCryptoServiceProvider());

            var bytes = stringToBytes.GetBytes(input);
            var hashed = hasher.ComputeHash(bytes);
            var hashString = bytesToString.GetString(hashed);

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Hash:");
            Console.WriteLine(hashString);
        }

        static void TestEncryption(string input)
        {
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Decrypted:");
            //Console.WriteLine(decrypted);

            //Console.WriteLine("");

            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Encryption and Decryption match:");
            //Console.WriteLine(encrypted.Equals(decrypted) ? "YES" : "NO");
        }

    }
}
