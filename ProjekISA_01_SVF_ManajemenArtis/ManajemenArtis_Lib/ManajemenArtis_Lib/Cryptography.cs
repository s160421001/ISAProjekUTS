using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ManajemenArtis_Lib
{
    public class Cryptography
    {
        #region methods
        public static string EncryptTripleDES(string plaintext)
        {
            string key = "kasjldkjeiwjqwpoqwpeolsd";

            int keyLength = 24;
            if (key.Length < keyLength)
            {
                key = key.PadRight(keyLength, ' ');
            }
            else if (key.Length > keyLength)
            {
                key = key.Substring(0, keyLength);
            }

            byte[] keyBytes = Encoding.ASCII.GetBytes(key);
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);

            using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
            {
                des.Key = keyBytes;
                des.Mode = CipherMode.ECB; // Electronic Codebook (ECB) mode
                des.Padding = PaddingMode.PKCS7; // Padding scheme

                ICryptoTransform encryptor = des.CreateEncryptor();

                byte[] ciphertextBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);

                return Convert.ToBase64String(ciphertextBytes);
            }
        }

        public static string DecryptTripleDES(string ciphertext)
        {
            string key = "kasjldkjeiwjqwpoqwpeolsd";

            int keyLength = 24;
            if (key.Length < keyLength)
            {
                key = key.PadRight(keyLength, ' ');
            }
            else if (key.Length > keyLength)
            {
                key = key.Substring(0, keyLength);
            }

            byte[] keyBytes = Encoding.ASCII.GetBytes(key);
            byte[] ciphertextBytes = Convert.FromBase64String(ciphertext);

            using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
            {
                des.Key = keyBytes;
                des.Mode = CipherMode.ECB; // Electronic Codebook (ECB) mode
                des.Padding = PaddingMode.PKCS7; // Padding scheme

                ICryptoTransform decryptor = des.CreateDecryptor();

                byte[] plaintextBytes = decryptor.TransformFinalBlock(ciphertextBytes, 0, ciphertextBytes.Length);

                return Encoding.UTF8.GetString(plaintextBytes);
            }
        }
        #endregion
    }
}
