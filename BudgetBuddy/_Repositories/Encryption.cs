using System;
using System.Text;
using System.Security.Cryptography;

namespace BudgetBuddy._Repositories
{
    public static class Encryption
    {
        public static string Salt()
        {

            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[12];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public static string Hash(string input, string salt)
        {


            var sha256 = SHA256.Create();

            //Prepend the salt to the password 
            byte[] bytes = Encoding.UTF8.GetBytes(salt + input);
            //and hash it
            byte[] hashed = sha256.ComputeHash(bytes);

            return Convert.ToBase64String(hashed);
        }


    }
}
    