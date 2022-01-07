using System;
using System.Security.Cryptography;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.

                    RSAParameters RSAKeyInfo = new RSAParameters();
                    
                    RSA.ImportParameters(RSAKeyInfo);

                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
               
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
