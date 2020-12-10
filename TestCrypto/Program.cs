using System;

namespace TestCrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crypto Test!");

            var kg = new SPC.Crypto.Symmetric.AES();

            Console.WriteLine(kg.GenerateKey());

            Console.WriteLine("Encrypted Text:");

            var EncryptedText = kg.EncryptText("Crypto Test!", "SPC");
                        
            Console.WriteLine(EncryptedText);

            Console.WriteLine("Decrypted Text:");
            Console.WriteLine(kg.DecryptText(EncryptedText,"SPC")) ;


            Console.ReadLine();
        }
    }
}
