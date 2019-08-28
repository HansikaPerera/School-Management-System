using System;
using System.Security.Cryptography;
using System.Text;

namespace SchoolManagementSystem
{
    class PasswordUtil
    {
      

        public static String getSalt(int length)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[length];
            rng.GetBytes(buff);

            // Return a Base64 string representation of the random number.
            return Convert.ToBase64String(buff);
        }

        private static byte[] hash(byte[] password, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[password.Length + salt.Length];

            for (int i = 0; i < password.Length; i++)
            {
                plainTextWithSaltBytes[i] = password[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[password.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }
        

        public static String generateSecurePassword(String password, String salt)
        {
            String returnValue = null;
            byte[] securePassword = PasswordUtil.hash(Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(salt));
            returnValue = System.Convert.ToBase64String(securePassword);
            return returnValue;
        }

        public static bool verifyUserPassword(String providedPassword, String securedPassword, String salt)
        {
            bool returnValue = false;
            //  Generate New secure password with the same salt
            String newSecurePassword = PasswordUtil.generateSecurePassword(providedPassword, salt);
            //  Check if two passwords are equal
            returnValue = newSecurePassword.Equals(securedPassword);
            return returnValue;
        }

        //[STAThread]
        //static void Main()
        //{
        //    String salt = PasswordUtil.getSalt(30);
        //    String pw = PasswordUtil.generateSecurePassword("ddd", salt);
        //    Console.WriteLine("{0} ", pw);
        //    Console.WriteLine("{0} ", salt);

        //}

    }


}
