using System;
using System.Text;

namespace Parafia.Common
{
    public static class Cryptography
    {
        public static string Hash(string text)
        {
            string hashedText = Convert.ToBase64String(
                System.Security.Cryptography.SHA256
                    .Create()
                    .ComputeHash(Encoding.UTF8.GetBytes(text))
            );

            return hashedText;
        }
    }
}