using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RedisCacheExample
{
    public static class Extensions
    {
        public static string ToMd5(this string stringToHash)
        {
            var md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.UTF8.GetBytes(stringToHash));
            var stringBuilder = new StringBuilder();
            md5.Hash.ToList().ForEach(h => { stringBuilder.Append(h.ToString("x2")); });
            return stringBuilder.ToString();
        }
    }
}
