using Konscious.Security.Cryptography;
using System;
using System.Security.Cryptography;
using System.Text;

namespace user_gateway.BLL.Application.Helpers
{
    public static class PasswordService
    {
        public static string HashPassword(string password, string salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltBytes = Convert.FromBase64String(salt);

            using (var argon2 = new Argon2id(passwordBytes))
            {
                argon2.Salt = saltBytes;
                argon2.DegreeOfParallelism = 4;
                argon2.MemorySize = 8192;
                argon2.Iterations = 4;
                byte[] hashBytes = argon2.GetBytes(32);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public static bool VerifyPassword(string password, string salt, string hashedPassword)
        {
            string computedHash = HashPassword(password, salt);
            byte[] computedHashBytes = Convert.FromBase64String(computedHash);
            byte[] storedHashBytes = Convert.FromBase64String(hashedPassword);

            using (var hmac = new HMACSHA256())
            {
                byte[] computedMac = hmac.ComputeHash(computedHashBytes);
                byte[] storedMac = hmac.ComputeHash(storedHashBytes);

                return computedMac.SequenceEqual(storedMac);
            }
        }


    }
}
