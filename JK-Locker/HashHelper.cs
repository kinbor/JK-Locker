using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JK_Locker
{
    public class HashHelper
    {
        #region MD5
        public static string MD5Encrypt(Stream fs)
        {
            try
            {
                var buffer = (new MD5CryptoServiceProvider()).ComputeHash(fs);
                return HexHelper.GetHexString(buffer);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string MD5Encrypt(byte[] bytes)
        {
            try
            {
                var buffer = (new MD5CryptoServiceProvider()).ComputeHash(bytes);
                return HexHelper.GetHexString(buffer);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string MD5Encrypt(string data)
        {
            return MD5Encrypt(Encoding.UTF8.GetBytes(data));
        }
        public static string MD5EncryptBigFile(string filePath)
        {
            try
            {
                var hashString = "";
                int bufferSize = 1024 * 16;//自定义缓冲区大小16K
                byte[] buffer = new byte[bufferSize];
                using (var inputStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var hashAlgorithm = new MD5CryptoServiceProvider();
                    int readLength = 0;//每次读取长度
                    var output = new byte[bufferSize];
                    while ((readLength = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        hashAlgorithm.TransformBlock(buffer, 0, readLength, output, 0);
                    }
                    //完成最后计算，必须调用(由于上一部循环已经完成所有运算，所以调用此方法时后面的两个参数都为0)
                    hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
                    hashString = HexHelper.GetHexString(hashAlgorithm.Hash);

                    hashAlgorithm.Clear();
                }
                return hashString;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region SHA1
        public static string SHA1Encrypt(Stream fs)
        {
            try
            {
                var buffer = (new SHA1CryptoServiceProvider()).ComputeHash(fs);
                return HexHelper.GetHexString(buffer);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string SHA1Encrypt(byte[] bytes)
        {
            try
            {
                var buffer = (new SHA1CryptoServiceProvider()).ComputeHash(bytes);
                return HexHelper.GetHexString(buffer);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string SHA1Encrypt(string data)
        {
            return SHA1Encrypt(Encoding.UTF8.GetBytes(data));
        }
        public static string SHA1EncryptBigFile(string filePath)
        {
            try
            {
                var hashString = "";
                int bufferSize = 1024 * 16;//自定义缓冲区大小16K
                byte[] buffer = new byte[bufferSize];
                using (var inputStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var hashAlgorithm = new SHA1CryptoServiceProvider();
                    int readLength = 0;//每次读取长度
                    var output = new byte[bufferSize];
                    while ((readLength = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        hashAlgorithm.TransformBlock(buffer, 0, readLength, output, 0);
                    }
                    //完成最后计算，必须调用(由于上一部循环已经完成所有运算，所以调用此方法时后面的两个参数都为0)
                    hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
                    hashString = HexHelper.GetHexString(hashAlgorithm.Hash);

                    hashAlgorithm.Clear();
                }
                return hashString;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region SHA256
        public static string SHA256Encrypt(Stream fs)
        {
            try
            {
                var buffer = (new SHA256CryptoServiceProvider()).ComputeHash(fs);
                return HexHelper.GetHexString(buffer);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string SHA256Encrypt(byte[] bytes)
        {
            try
            {
                var buffer = (new SHA256CryptoServiceProvider()).ComputeHash(bytes);
                return HexHelper.GetHexString(buffer);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string SHA256Encrypt(string data)
        {
            return SHA256Encrypt(Encoding.UTF8.GetBytes(data));
        }
        public static string SHA256EncryptBigFile(string filePath)
        {
            try
            {
                var hashString = "";
                int bufferSize = 1024 * 16;//自定义缓冲区大小16K
                byte[] buffer = new byte[bufferSize];
                using (var inputStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var hashAlgorithm = new SHA256CryptoServiceProvider();
                    int readLength = 0;//每次读取长度
                    var output = new byte[bufferSize];
                    while ((readLength = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        hashAlgorithm.TransformBlock(buffer, 0, readLength, output, 0);
                    }
                    //完成最后计算，必须调用(由于上一部循环已经完成所有运算，所以调用此方法时后面的两个参数都为0)
                    hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
                    hashString = HexHelper.GetHexString(hashAlgorithm.Hash);

                    hashAlgorithm.Clear();
                }
                return hashString;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region SHA512
        public static string SHA512Encrypt(Stream fs)
        {
            try
            {
                var buffer = (new SHA512CryptoServiceProvider()).ComputeHash(fs);
                return HexHelper.GetHexString(buffer);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string SHA512Encrypt(byte[] bytes)
        {
            try
            {
                var buffer = (new SHA512CryptoServiceProvider()).ComputeHash(bytes);
                return HexHelper.GetHexString(buffer);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string SHA512Encrypt(string data)
        {
            return SHA512Encrypt(Encoding.UTF8.GetBytes(data));
        }
        public static string SHA512EncryptBigFile(string filePath)
        {
            try
            {
                var hashString = "";
                int bufferSize = 1024 * 16;//自定义缓冲区大小16K
                byte[] buffer = new byte[bufferSize];
                using (var inputStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var hashAlgorithm = new SHA512CryptoServiceProvider();
                    int readLength = 0;//每次读取长度
                    var output = new byte[bufferSize];
                    while ((readLength = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        hashAlgorithm.TransformBlock(buffer, 0, readLength, output, 0);
                    }
                    //完成最后计算，必须调用(由于上一部循环已经完成所有运算，所以调用此方法时后面的两个参数都为0)
                    hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
                    hashString = HexHelper.GetHexString(hashAlgorithm.Hash);

                    hashAlgorithm.Clear();
                }
                return hashString;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}
