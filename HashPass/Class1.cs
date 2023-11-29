using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace HashPass
{
    public static class HashController
    {
        const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        public static string GenerateHash(string input)
        {

            MD5 hasher = MD5.Create();

            byte[] hashData = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < hashData.Length; i++)
            {
                sb.Append(hashData[i].ToString("x2"));
            }

            string hash = sb.ToString();

            return hash;
        }

        public static string GenerateSalt(int size)
        {
            Random random = new Random();
            StringBuilder sb =  new StringBuilder("");

            for(int i = 0; i < size; i++)
            {
                sb.Append(validChars[(int)(random.NextDouble() * validChars.Length)]);
            }

            string salt = sb.ToString();

            return salt;
        }

        public static string HashPass(string salt, string pass)
        {
            return GenerateHash(salt + pass);
        }
    }
}