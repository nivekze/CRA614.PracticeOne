using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptography
{
    public class SubtractionAlgorithm : Algorithm
    {
        public SubtractionAlgorithm() : base() { }

        public SubtractionAlgorithm(int key) : base(key) { }

        public override int Crypt(int numToCrypt)
        {
            return numToCrypt - Key;
        }

        public override int Decrypt(int numToDecrypt)
        {
            return numToDecrypt + Key;
        }
    }
}
