using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JK_Locker
{
    public class HexHelper
    {
        public static string GetHexString(byte[] barray)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < barray.Length; i++)
            {
                sb.Append(barray[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public static byte[] GetByteArray(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
            return returnBytes;
        }
    }
}
