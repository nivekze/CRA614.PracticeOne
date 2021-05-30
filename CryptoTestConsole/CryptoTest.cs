using System;
using System.Linq;
using System.Collections.Generic;
using Cryptography;

namespace CryptoTestConsole
{
    class CryptoTest
    {
        static void Main(string[] args)
        {
            int Key, ToEncryptNum, CryptNum, DecryptNum, AlgorithmToUse;
            var algorithms = new List<Algorithm>();

            Console.WriteLine("\r\n**********************************************************\r\n");
            Console.WriteLine("\tUniversidad Don Bosco");
            Console.WriteLine("\tCriptografía Aplicada -  CRA614");
            Console.WriteLine("\t\t>> Kevin Omar Alvarez Hernandez");
            Console.WriteLine("\r\n**********************************************************\r\n");

            bool askForKey = AskForBoolean("\r\nEl sistema creará una llave de forma aleatoria o pudes ingresar una personalizada\r\nDeseas ingresar una llave personalizada(Si/No)?");
            if (askForKey)
            {
                Key = AskForInteger("\r\nIngresa la llave privada (Debe ser un numero entero):", null);
            }
            else {
                var random = new Random();
                Key = random.Next(1, 100);
                Console.WriteLine($"Llave aleatoria generada: {Key}");
            }

            ToEncryptNum = AskForInteger("\r\nIngresa el número entero que será encriptado:", null);

            AlgorithmToUse = AskForInteger("\r\nSeleccione el algoritmo que utilizará:\r\n", "1 - Resta\r\n2 - Multiplicacion\r\n3 - XOR\r\n4 - Todos (Resta, Multiplicacion, XOR)");

            switch (AlgorithmToUse) {
                case 1:
                    algorithms.Add(new SubtractionAlgorithm(Key));
                    break;
                case 2:
                    algorithms.Add(new MultiplicationAlgorithm(Key));
                    break;
                case 3:
                    algorithms.Add(new XORAlgorithm(Key));
                    break;
                default:
                    algorithms.Add(new SubtractionAlgorithm(Key));
                    algorithms.Add(new MultiplicationAlgorithm(Key));
                    algorithms.Add(new XORAlgorithm(Key));
                    break;
            }
            Console.WriteLine("\r\n**********************************************************\r\n");

            foreach (var a in algorithms) {
                
                Console.WriteLine($"\tAlgoritmo Usado: {a.GetType().Name}\r\n");
                CryptNum = a.Crypt(ToEncryptNum);
                DecryptNum = a.Decrypt(CryptNum);
                Console.WriteLine($"\t\tNumero Original: {ToEncryptNum}");
                Console.WriteLine($"\t\tLlave: {a.GetKey()}");
                Console.WriteLine($"\t\tNumero Encriptado: {CryptNum}");
                Console.WriteLine($"\t\tNumero Desencriptado: {DecryptNum}");
                Console.WriteLine("\r\n**********************************************************\r\n");
            }
            Console.ReadLine();
        }

        private static int AskForInteger(string question, string options) {
            int anwser;
            string tmpAnswer;
            do {
                Console.Write(question);
                if (!string.IsNullOrWhiteSpace(options)) Console.WriteLine(options);
                tmpAnswer = Console.ReadLine();
            } while (!int.TryParse(tmpAnswer, out anwser));
            return anwser;
        }

        private static bool AskForBoolean(string question) {
            string[] yesAnswer = new string[] { "y", "yes", "s", "si" };
            string tmpAnswer;
            
            Console.Write(question);
            tmpAnswer = Console.ReadLine();
            return yesAnswer.Any(y => tmpAnswer.ToLower().Equals(y));
            
        }
    }
}
