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

            Console.ReadLine();
        }
    }
}
