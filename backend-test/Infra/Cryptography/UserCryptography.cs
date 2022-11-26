using System.Security.Cryptography;
using System.Text;

namespace Infra
{
    public static class UserCryptography
    {
        public static string GerarHash(this string pwd)
        {
            var hash =  SHA512.Create();
            var encoding = new ASCIIEncoding();
            var array = encoding.GetBytes(pwd);

            array = hash.ComputeHash(array);

            var strHexa = new StringBuilder();

            foreach (var item in array)
            {
                strHexa.Append(item.ToString("x2"));
            }

            return strHexa.ToString();
        }
    }
}
