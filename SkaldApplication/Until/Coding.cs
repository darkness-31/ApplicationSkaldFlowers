using System;
using System.Security.Cryptography;
using System.Text;

namespace SkaldApplication.Until
{
    internal class Coding
    {
        protected private static byte[] _Key =
        {
        0x38, 0xc5, 0x54, 0xd2, 0x96, 0x76,
        0xf0, 0x98, 0xfa, 0x65, 0xec, 0xe5,
        0x6e, 0x3b, 0x37, 0x52, 0xf0, 0x86,
        0x43, 0x0c, 0xd7, 0xdc, 0x48, 0x53,
        0x63, 0x0c, 0x91, 0x5d, 0x37, 0x04,
        0x3d, 0x29, 0x0b, 0x66, 0x82, 0x01,
        0x9d, 0x13, 0x3f, 0x70, 0xc0, 0xcd,
        0x99, 0xed, 0xba, 0xd7, 0x2b, 0xfa,
        0xe4
        };

        protected private static Aes ConfigAES(out byte[] key, out byte[] iv)
        {
            MD5 md5 = MD5.Create();
            SHA256 sha256 = SHA256.Create();
            Aes aes = Aes.Create();

            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            var md5Message = md5.ComputeHash(_Key);
            aes.IV = md5Message;
            var sha256md5Message = sha256.ComputeHash(md5Message);
            aes.Key = sha256md5Message;

            key = sha256md5Message;
            iv = md5Message;
            return aes;
        }
        public static string Encryption(string text)
        {

            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] key;
            byte[] iv;
            var encptAes = ConfigAES(out key, out iv).CreateEncryptor(key, iv);
            return Convert.ToBase64String(encptAes.TransformFinalBlock(bytes, 0, bytes.Length));
        }
        public static string Decryption(string bytes)
        {
            byte[] key;
            byte[] iv;
            var cryptAes = ConfigAES(out key, out iv).CreateDecryptor(key, iv);
            var buff = Convert.FromBase64String(bytes);
            var crypt = cryptAes.TransformFinalBlock(buff, 0, buff.Length);

            return Encoding.UTF8.GetString(crypt);
        }
    }
}
