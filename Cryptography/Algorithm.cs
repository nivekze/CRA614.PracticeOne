using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptography
{
    public abstract class Algorithm
    {
        protected int Key { get; set; }

        public Algorithm()
        {
            this.Key = (new Random()).Next(1, 100);    
        }

        public abstract int Crypt(int numToCrypt);

        public abstract int Decrypt(int numToDecrypt);
    }
}
