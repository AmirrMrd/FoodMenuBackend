using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace FoodMenuTest.Helper
{
    public class HashFile
    {
        private readonly string _password;

        private readonly string _PassHash; 

        public HashFile(string password)

        {
            _password = password;
        }

        public static byte[] GetHash(string _password)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(_password));
            
        }

        public Task<string>  CreateHash (string _password) 
        {

            return Task.FromResult(_password);
        }

        internal static Task<ActionResult<HashFile>> GetHash(HashFile hassPass)
        {
            throw new NotImplementedException();
        }
    }
}
