using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Database
{
    public class Security
    {
        private static string mKey = "wqdj~yriu!@*k0_^fa7431%p$#=@hd+&";
        private static string mSalt = "mnbvcxzasdfghjklpoiuytrewq";

        private static SymmetricAlgorithm mCryptoService;

        private static void SetLegalIV()
        {
            mCryptoService.IV = new byte[] { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9 };
        }

        private static byte[] GetLegalKey()
        {
            mCryptoService = new DESCryptoServiceProvider();
            mCryptoService.Mode = CipherMode.CBC;
            // Adjust key if necessary, and return a valid key
            if (mCryptoService.LegalKeySizes.Length > 0)
            {
                // Key sizes in bits
                int keySize = mKey.Length * 8;
                int minSize = mCryptoService.LegalKeySizes[0].MinSize;
                int maxSize = mCryptoService.LegalKeySizes[0].MaxSize;
                int skipSize = mCryptoService.LegalKeySizes[0].SkipSize;

                if (keySize > maxSize)
                {
                    // Extract maximum size allowed
                    mKey = mKey.Substring(0, maxSize / 8);
                }
                else if (keySize < maxSize)
                {
                    // Set valid size
                    int validSize = (keySize <= minSize) ? minSize :
                        (keySize - keySize % skipSize) + skipSize;
                    if (keySize < validSize)
                    {
                        // Pad the key with asterisk to make up the size
                        mKey = mKey.PadRight(validSize / 8, '*');
                    }
                }
            }
            PasswordDeriveBytes key = new PasswordDeriveBytes(mKey, ASCIIEncoding.ASCII.GetBytes(mSalt));
            return key.GetBytes(mKey.Length);
        }
        /// <summary>
        /// Hàm mã hóa dữ liệu
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string EncryptData(string plainText)
        {
            mCryptoService = new DESCryptoServiceProvider();
            mCryptoService.Mode = CipherMode.CBC;
            byte[] plainByte = ASCIIEncoding.ASCII.GetBytes(plainText);
            byte[] keyByte = GetLegalKey();

            // Set private key
            mCryptoService.Key = keyByte;
            SetLegalIV();

            // Encryptor object
            ICryptoTransform cryptoTransform = mCryptoService.CreateEncryptor();

            // Memory stream object
            MemoryStream ms = new MemoryStream();

            // Crpto stream object
            CryptoStream cs = new CryptoStream(ms, cryptoTransform,
                CryptoStreamMode.Write);

            // Write encrypted byte to memory stream
            cs.Write(plainByte, 0, plainByte.Length);
            cs.FlushFinalBlock();

            // Get the encrypted byte length
            byte[] cryptoByte = ms.ToArray();

            // Convert into base 64 to enable result to be used in Xml
            return Convert.ToBase64String(cryptoByte, 0, cryptoByte.GetLength(0));
        }
        /// <summary>
        /// Giải mã dữ liệu
        /// </summary>
        /// <param name="cryptoText"></param>
        /// <returns></returns>
        public static string DecryptData(string cryptoText)
        {
            // Convert from base 64 string to bytes
            try
            {
                byte[] cryptoByte = Convert.FromBase64String(cryptoText);

                byte[] keyByte = GetLegalKey();

                // Set private key
                mCryptoService.Key = keyByte;
                SetLegalIV();

                // Decryptor object
                ICryptoTransform cryptoTransform = mCryptoService.CreateDecryptor();
                // Memory stream object
                MemoryStream ms = new MemoryStream(cryptoByte, 0, cryptoByte.Length);

                // Crpto stream object
                CryptoStream cs = new CryptoStream(ms, cryptoTransform,
                    CryptoStreamMode.Read);

                // Get the result from the Crypto stream
                StreamReader sr = new StreamReader(cs);
                return sr.ReadToEnd();
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Mã hóa mật khẩu truy cập
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string EncryptPassword(string plainText)
        {
            //Convert the string into a byte[]
            byte[] unicodeByte = Encoding.Unicode.GetBytes(plainText);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] arrHashValue = md5.ComputeHash(unicodeByte);

            string strHashData = BitConverter.ToString(arrHashValue).ToLower();
            strHashData = strHashData.Replace("-", "");
            strHashData = strHashData.Replace("b", "a");
            strHashData = strHashData.Replace("t", "g");
            strHashData = strHashData.Replace("l", "h");
            strHashData = strHashData.Replace("m", "l");

            return strHashData;
        }
    }
}