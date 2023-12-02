using System;
using System.Text;
using System.Security.Cryptography;
using System.Data.SqlTypes;
using System.Security.Policy;
using System.Linq;

namespace BudgetBuddy._Repositories
{
    public static class Encryption
    {
        public class HashSalt
        {
            public string Hash { get; set; }
            public string Salt { get; set; }
        }

        public static HashSalt GenerateSaltedHash(string password)
        {

            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] saltByte = new byte[12];
            rng.GetNonZeroBytes(saltByte);
            // Salt
            var salt = Convert.ToBase64String(saltByte);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltByte, 10000);
            var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32));


            HashSalt hashSalt = new HashSalt { Hash = hashPassword, Salt = salt };

            return hashSalt;
        }


        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {

            var saltBytes = Convert.FromBase64String(storedSalt);
            var passBytes = Convert.FromBase64String(storedHash);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
            var bytes = rfc2898DeriveBytes.GetBytes(32);
            var result = bytes.SequenceEqual(passBytes);

            return result;
        }
    }
}
    