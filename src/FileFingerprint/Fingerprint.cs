using System.Text;
using System.Security.Cryptography;

namespace FileFingerprint
{
    public static class Fingerprint
    {
        public static string GetHash(byte[] data)
        {
            using (SHA256 sha = SHA256.Create())
            {
                StringBuilder sb = new StringBuilder();
                byte[] hash = sha.ComputeHash(data);
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
