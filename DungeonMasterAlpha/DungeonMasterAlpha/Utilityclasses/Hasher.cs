using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DungeonMasterAlpha.Utilityclasses
{
    public static class Hasher
    {
        private static RNGCryptoServiceProvider trueRandom;
        private const int SALTSize = 24;

        static Hasher()
        {
            trueRandom = new RNGCryptoServiceProvider();
        }

        /// <summary>
        /// Generates and returns a SALT.
        /// </summary>
        /// <returns>A SALT in the form of a string</returns>
        public static string GetSalt()
        {
            byte[] salt = new byte[SALTSize];

            trueRandom.GetNonZeroBytes(salt);

            return Convert.ToBase64String(salt);
        }

        /// <summary>
        /// Takes a string, adds a SALT and hashes the result.
        /// </summary>
        /// <param name="password">A string representing a password.</param>
        /// <returns>A hashed password + SALT</returns>
        public static string HashPassword(string saltedPassword)
        {
            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] passAndSalt = Encoding.ASCII.GetBytes(saltedPassword);
            byte[] hashedPass = sha.ComputeHash(passAndSalt);

            return Convert.ToBase64String(hashedPass);
        }
    }
}