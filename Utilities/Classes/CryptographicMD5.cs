using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    /// <summary>
    /// CryptographicMD5:
    /// The MD5 message-digest algorithm is a widely used cryptographic hash function producing a 128-bit (16-byte) hash value,
    /// typically expressed in text format as a 32 digit hexadecimal number. 
    /// MD5 was designed by Ronald Rivest in 1991 to replace an earlier hash function, MD4.
    /// </summary>
    public class CryptographicMD5
    {
        public static string GetMD5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }               
        /// <summary>
        /// VerifyMD5Hash:
        /// Verify a hash against a string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static bool VerifyMD5Hash(string input, string hash)
        {
            MD5 md5Hash = MD5.Create();
            // Hash the input. 
            string hashOfInput = GetMD5Hash(input);
            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

