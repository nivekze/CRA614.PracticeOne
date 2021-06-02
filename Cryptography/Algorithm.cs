using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptography
{
    public abstract class Algorithm
    {
        /// <summary>
        /// Key that will be use by the algorithm to crypt/decrypt
        /// </summary>
        protected int Key;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Algorithm()
        {
            this.Key = (new Random()).Next(1, 100);    
        }

        /// <summary>
        /// Constructor that gets key
        /// </summary>
        /// <param name="key">Key of algorithm</param>
        public Algorithm(int key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Get key value method
        /// </summary>
        /// <returns>Integer</returns>
        public int GetKey()
        {
            return Key;
        }

        /// <summary>
        /// Set key value method
        /// </summary>
        /// <param name="key">Integer</param>
        public void SetKey(int key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Implementation of Crypt method
        /// </summary>
        /// <param name="numToCrypt">Number to be crypted</param>
        /// <returns>Integer of Crypted number</returns>
        public abstract int Crypt(int numToCrypt);

        /// <summary>
        /// Implementation of Decrypt method
        /// </summary>
        /// <param name="numToDecrypt">Number to be decrypted</param>
        /// <returns>Integer of Decrypted number</returns>
        public abstract int Decrypt(int numToDecrypt);
        
    }
}
