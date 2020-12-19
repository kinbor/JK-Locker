using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace JK_Locker
{
    public static class Extensions
    {
        public static bool IsNotNullEmptyWhiteSpace(this string str)
        {
            return !string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str);
        }
        public static bool IsNullOrEmptyOrWhiteSpace(this string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }
        public static string ToStingSafe(this object obj)
        {
            return obj == null ? null : obj.ToString();
        }
        public static bool IsEquals(this string str, string str2, StringComparison sc = StringComparison.OrdinalIgnoreCase)
        {
            return str.Equals(str2, sc);
        }

        /// <summary>
        /// 数字格式：数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string str)
        {
            return Regex.IsMatch(str, @"^[+-]?\d*[.]?\d*$");
        }
        /// <summary>
        /// 数字格式：0和整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsInt(this string str)
        {
            return Regex.IsMatch(str, @"^[-]?[1-9]{1}\d*$|^[0]{1}$");
        }

        /// <summary>
        /// IPv4地址
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsIPv4(this string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 7 || str.Length > 15) return false;
            return Regex.IsMatch(str, @"^d{1,3}[.]d{1,3}[.]d{1,3}[.]d{1,3}$", RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// IPv6地址
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsIPv6(this string str)
        {
            return Regex.IsMatch(str, @"^([\da-fA-F]{1,4}:){6}((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$");
        }

        /// <summary>
        /// 用户名称：字母开头，允许5-16字节，允许字母数字下划线
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsUserName(this string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z][a-zA-Z0-9_]{4,15}$");
        }
        /// <summary>
        /// 密码格式：大写字母，小写字母，数字，特殊符号必须四选三
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPasswordForcePlus8_32(this string str)
        {
            return Regex.IsMatch(str, @"^(?![a-zA-Z]+$)(?![A-Z0-9]+$)(?![A-Z\W_]+$)(?![a-z0-9]+$)(?![a-z\W_]+$)(?![0-9\W_]+$)[a-zA-Z0-9\W_]{8,32}$");
        }
        /// <summary>
        /// 密码格式：必须包含大小写字母和数字的组合，不能使用特殊字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPasswordForce8_32(this string str)
        {
            return Regex.IsMatch(str, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,32}$");
        }
        /// <summary>
        /// 密码格式：数字和字母必须同时存在
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPasswordNumChar8_32(this string str)
        {
            return Regex.IsMatch(str, @"^(?![0-9]+$)(?![a-zA-Z]+$)[0-9A-Za-z]{8,32}$");
        }
        /// <summary>
        /// 密码格式：必须为纯数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPasswordNumber6_6(this string str)
        {
            return Regex.IsMatch(str, @"^[0-9]{6,6}$");
        }

        /// <summary>
        /// 手机号码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsMobilePhone(this string str)
        {
            return Regex.IsMatch(str, @"^([1][3,4,5,6,7,8,9])\d{9}$");
        }
        /// <summary>
        /// 固话号码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsTelePhone(this string str)
        {
            return Regex.IsMatch(str, @"^(\(\d{3,4}-)|\d{3.4}-)?\d{7,8}$");
        }
        /// <summary>
        /// 电子邮箱地址
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsEmail(this string str)
        {
            return Regex.IsMatch(str, @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// 身份证格式：15位，18位，17位+x|X
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsIDCard(this string str)
        {
            return Regex.IsMatch(str, @"(^\d{15}$)|(^\d{18}$)|(^\d{17}(\d|X|x)$)");
        }
        /// <summary>
        /// 域名网址
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsHttpHttps(this string str)
        {
            return Regex.IsMatch(str, @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 转换科学记数法为数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal FEToNumber(this string str)
        {
            decimal dData = 0.0M;
            if (str.Contains("E"))
            {
                dData = decimal.Parse(str, System.Globalization.NumberStyles.Float);
            }
            else
            {
                dData = Convert.ToDecimal(str);
            }
            return dData;
        }
        /// <summary>
        /// 判断请求者是否为手机浏览器
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        public static bool IsMobileBrowser(this string userAgent)
        {
            var result1 = Regex.IsMatch(userAgent, @"^(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|ipad|iris|kindle|Android|Silk|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino$", RegexOptions.IgnoreCase);
            if (!result1)
            {
                if (userAgent.IsNotNullEmptyWhiteSpace() && userAgent.Length > 4)
                {
                    return Regex.IsMatch(userAgent.Substring(0, 4), @"^1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-$", RegexOptions.IgnoreCase);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return result1;
            }
        }

        /// <summary>
        /// 生成长整型随机数
        /// </summary>
        /// <param name="rand">对象</param>
        /// <param name="minValue">最小值（包含）</param>
        /// <param name="maxValue">最大值（不包含）</param>
        /// <returns></returns>
        public static long NextLong(this Random rand, long minValue, long maxValue)
        {
            if (maxValue <= minValue)
            {
                throw new Exception("minValue must be less than maxValue.");
            }

            var buf = new byte[8];
            rand.NextBytes(buf);
            var longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (maxValue - minValue)) + minValue);
        }
    }
}
