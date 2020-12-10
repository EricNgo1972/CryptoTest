using System;
using System.ComponentModel;
using System.Security.Cryptography;

/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/standard/security/generating-keys-for-encryption-and-decryption
/// </summary>
namespace SPC.Crypto
{
    public class SymmetricKey
    {

        public string AlgorithmName { get; set; }

        public string GenerateKey()
        {
            Aes aes = Aes.Create(AlgorithmName);
            aes.GenerateIV();
            aes.GenerateKey();

            return Convert.ToBase64String(aes.Key);

        }


    }
}
