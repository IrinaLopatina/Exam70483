using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Security.Cryptography;


namespace Exam70483_13
{
    public class AuthenticationObject
    {
        public string UserName { get; private set; }
        public string Password { get; private set; } //TODO SEqureString
        public Guid Salt { get; private set; }


        public AuthenticationObject(string userName, string password)
        {
            Salt = Guid.NewGuid();
            UserName = userName;
            Password = GetHashedPassword(password, Salt);
        }

        public AuthenticationObject(string userName, string password, Guid salt)
        {
            Salt = salt;
            UserName = userName;
            Password = password;
        }

        public static string GetHashedPassword(string password, Guid salt)
        {
            //Merge password with random value
            string saltedPassword = password + salt;

            //Password in bytes
            var passwordInBytes = Encoding.UTF8.GetBytes(saltedPassword);

            //Create the SHA512 object
            HashAlgorithm sha512 = SHA512.Create();

            //Generate the hash
            byte[] hashInBytes = sha512.ComputeHash(passwordInBytes);

            string hashedPassword = Convert.ToBase64String(hashInBytes);
            return hashedPassword;
        }
    }
}
