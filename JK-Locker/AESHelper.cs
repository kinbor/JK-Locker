using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JK_Locker
{
    public class AESHelper
    {
        public enum AESEncodeType
        {
            HEX,
            Base64
        }
        public static KeyValuePair<bool, string> AesEncrypt(string aesKey, string data, AESEncodeType encodeType = AESEncodeType.Base64)
        {
            return AesEncrypt(aesKey, Encoding.UTF8.GetBytes(data), encodeType);
        }
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static KeyValuePair<bool, string> AesEncrypt(string aesKey, byte[] data, AESEncodeType encodeType = AESEncodeType.Base64)
        {
            try
            {
                aesKey = Encoding.UTF8.GetString(HexHelper.GetByteArray(aesKey));
                var keyArray = aesKey.Split('|');

                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Convert.ToInt32(keyArray[0]);

                var key = HexHelper.GetByteArray(keyArray[1]);
                var iv = HexHelper.GetByteArray(keyArray[2]);
                ICryptoTransform transform = provider.CreateEncryptor(key, iv);

                var edata = "";
                using (MemoryStream estream = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(estream, transform, CryptoStreamMode.Write))
                    {
                        using (MemoryStream ostream = new MemoryStream(data))
                        {
                            int length = 0;
                            byte[] buffer = new byte[1024];
                            while ((length = ostream.Read(buffer, 0, 1024)) > 0)
                            {
                                cs.Write(buffer, 0, length);
                            }
                            cs.FlushFinalBlock();//Don't Forget

                            switch (encodeType)
                            {
                                case AESEncodeType.HEX:
                                    edata = HexHelper.GetHexString(estream.ToArray());
                                    break;
                                case AESEncodeType.Base64:
                                default:
                                    edata = Convert.ToBase64String(estream.ToArray());
                                    break;
                            }
                        }
                    }
                }
                return new KeyValuePair<bool, string>(true, edata);
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message + "|" + ex.StackTrace);
            }
        }
        public static KeyValuePair<bool, string> AesDecrypt(string aesKey, string data, AESEncodeType encodeType = AESEncodeType.Base64)
        {
            byte[] byteData = null;
            switch (encodeType)
            {
                case AESEncodeType.HEX:
                    byteData = HexHelper.GetByteArray(data);
                    break;
                case AESEncodeType.Base64:
                default:
                    byteData = Convert.FromBase64String(data);
                    break;
            }
            return AesDecrypt(aesKey, byteData);
        }
        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static KeyValuePair<bool, string> AesDecrypt(string aesKey, byte[] data)
        {
            try
            {
                aesKey = Encoding.UTF8.GetString(HexHelper.GetByteArray(aesKey));
                var keyArray = aesKey.Split('|');

                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Convert.ToInt32(keyArray[0]);

                var key = HexHelper.GetByteArray(keyArray[1]);
                var iv = HexHelper.GetByteArray(keyArray[2]);
                ICryptoTransform transform = provider.CreateDecryptor(key, iv);

                var ddata = "";
                using (MemoryStream estream = new MemoryStream(data))
                {
                    using (CryptoStream cs = new CryptoStream(estream, transform, CryptoStreamMode.Read))
                    {
                        using (MemoryStream ostream = new MemoryStream())
                        {
                            int length;
                            byte[] buffer = new byte[1024];
                            while ((length = cs.Read(buffer, 0, 1024)) > 0)
                            {
                                ostream.Write(buffer, 0, length);
                            }

                            ddata = Encoding.UTF8.GetString(ostream.ToArray());
                        }
                    }
                }
                return new KeyValuePair<bool, string>(true, ddata);
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message + "|" + ex.StackTrace);
            }
        }
        /// <summary>
        /// 创建Key
        /// </summary>
        /// <param name="numBytes">128|192|256</param>
        /// <returns></returns>
        public static string CreateAESKey(int numBytes = 128)
        {
            AesCryptoServiceProvider crypt = new AesCryptoServiceProvider();
            crypt.KeySize = numBytes;
            crypt.GenerateKey();
            crypt.GenerateIV();
            var keyBytes = crypt.Key;
            var ivBytes = crypt.IV;
            return HexHelper.GetHexString(Encoding.UTF8.GetBytes(numBytes + "|" + HexHelper.GetHexString(keyBytes) + "|" + HexHelper.GetHexString(ivBytes)));
        }
        /// <summary>
        /// 创建Key
        /// </summary>
        /// <param name="key">加密密码</param>
        /// <param name="numBytes">128|192|256</param>
        /// <returns></returns>
        public static string CreateAESKey(string key, int numBytes = 256)
        {
            var shaKey = HashHelper.SHA256Encrypt(key);
            var ivBytes = Encoding.UTF8.GetBytes(shaKey.Substring(0, 16));
            if (numBytes == 128)
            {
                var keyBytes = Encoding.UTF8.GetBytes(shaKey.Substring(0, 16));
                return HexHelper.GetHexString(Encoding.UTF8.GetBytes(numBytes + "|" + HexHelper.GetHexString(keyBytes) + "|" + HexHelper.GetHexString(ivBytes)));
            }
            else if (numBytes == 192)
            {
                var keyBytes = Encoding.UTF8.GetBytes(shaKey.Substring(0, 24));
                return HexHelper.GetHexString(Encoding.UTF8.GetBytes(numBytes + "|" + HexHelper.GetHexString(keyBytes) + "|" + HexHelper.GetHexString(ivBytes)));
            }
            else
            {
                var keyBytes = Encoding.UTF8.GetBytes(shaKey.Substring(0, 32));
                return HexHelper.GetHexString(Encoding.UTF8.GetBytes(numBytes + "|" + HexHelper.GetHexString(keyBytes) + "|" + HexHelper.GetHexString(ivBytes)));
            }
        }
    }
}
