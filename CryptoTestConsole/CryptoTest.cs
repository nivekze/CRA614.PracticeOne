using System;
using System.Collections.Generic;
using Cryptography;

namespace CryptoTestConsole
{
    class CryptoTest
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int key = random.Next(1, 100);
            int numToEncrypt = 33;
            int cryptNum, decryptNum;

            var algorithms = new List<Algorithm>();
            algorithms.Add(new SubtractionAlgorithm(key));
            algorithms.Add(new MultiplicationAlgorithm(key));
            algorithms.Add(new XORAlgorithm(key));

            foreach (var a in algorithms) {
                
                Console.WriteLine($"Algoritm: {a.GetType().Name}");
                cryptNum = a.Crypt(numToEncrypt);
                decryptNum = a.Decrypt(cryptNum);
                Console.WriteLine($"Crypt Result: {cryptNum}");
                Console.WriteLine($"Decrypt Result: {decryptNum}");
                ;
            }
            Console.ReadLine();
        }
    }
}
