using System.Text.RegularExpressions;

namespace WebApplication4.Random
{
    public static class ToolFun
    {

        /// <summary>
        /// 随机返回中文字符
        /// </summary>
        /// <returns></returns>
        public static char GetChinese()
        {
            // Unicode编码范围为0x4E00到0x9FA5之间（包括这两个值）
            int startRange = 0x4e00;
            int endRange = 0x9fa5;

            int unicodeValue = ToolCore.GetSimpNum(startRange, endRange + 1);

            return Convert.ToChar(unicodeValue);
        }

        /// <summary>
        /// 随机返回指定数量的中文
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetChinese(int count, bool repeat = false)
        {
            // Unicode编码范围为0x4E00到0x9FA5之间（包括这两个值）
            int startRange = 0x4e00;
            int endRange = 0x9fa5;

            string str = string.Empty;
            if (repeat)
            {
                for (int i = 0; i < count; i++)
                {
                    int unicodeValue = ToolCore.GetSimpNum(startRange, endRange + 1);
                    str += Convert.ToChar(unicodeValue);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    int unicodeValue = ToolCore.GetSimpNum(startRange, endRange + 1);
                    char c = Convert.ToChar(unicodeValue);
                    if (str.Contains(c))
                    {
                        count--;
                    }
                    else
                    {
                        str += Convert.ToChar(unicodeValue);
                    }
                }
            }
            return str;
        }

        /// <summary>
        /// 获取ip地址
        /// </summary>
        /// <returns></returns>
        public static string GetIp()
        {
            var s = "";
            for (int i = 0; i <= 3; i++)
            {
                var q = ToolCore.GetSimpNum(0, 255).ToString();
                if (i < 3)
                {
                    s += (q + ".").ToString();
                }
                else
                {
                    s += q.ToString();
                }
            }
            var zz = Regex.IsMatch(s, "^((25[0-5]|2[0-4]\\d|((1\\d{2})|([1-9]?\\d)))\\.){3}(25[0-5]|2[0-4]\\d|((1\\d{2})|([1-9]?\\d)))$");
            if (zz == true)
            {
                return s;
            }
            else
            {
                return "";
            }
        }
        #region 手机号

        public static string CTCNumber()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.CTC) + ToolCore.GetNum(9);
        }

        public static string CUCCNumber()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.CUCC) + ToolCore.GetNum(9);
        }

        public static string CMCCNumber()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.CMCC) + ToolCore.GetNum(9);
        }

        public static string PhoneNumber()
        {
            int i = ToolCore.GetSimpNum(1, 10);
            if (i % 3 == 0)
            {
                return ToolCore.GetVcodeNum(1, RandomData.Instance.CMCC) + ToolCore.GetNum(9);
            }
            else if (i % 2 == 0)
            {
                return ToolCore.GetVcodeNum(1, RandomData.Instance.CUCC) + ToolCore.GetNum(9);
            }
            else
            {
                return ToolCore.GetVcodeNum(1, RandomData.Instance.CTC) + ToolCore.GetNum(9);
            }
        } 
        #endregion

        public static string PhoneEmailNumber()
        {
            return PhoneNumber() + ToolCore.GetVcodeNum(1, RandomData.Instance.EMail);
        }

        public static string CharEmailNumber()
        {
            return ToolCore.GetVcodeNum(8) + ToolCore.GetVcodeNum(1, RandomData.Instance.EMail);
        }
        public static string EnglishNameEmailNumber()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.EnglishNames).Replace(" ","") + ToolCore.GetVcodeNum(1, RandomData.Instance.EMail);
        }


        /// <summary>
        /// 身份证号
        /// </summary>
        /// <returns></returns>
        public static string IDCodeNumber()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.RegionCode) + YearNumber() + MonthNumber() + ToolCore.GetNum(4);
        }
        /// <summary>
        /// 获取护照号
        /// 公务护照号码的格式为：SE+7 位数字编码（以S开头的护照是代表公务护照）。
        /// 外交护照号码的格式为：DE+7 位数字编码（以D开头的护照是代表外交护照）。
        /// 公务普通护照号码的格式为：PE+7 位数字编码（以P开头的护照是代表公务普通护照）。
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string IDPostCodeNumber(string format = "PE")
        {
            return format + ToolCore.GetNum(7);
        }

        /// <summary>
        /// 随机True,False
        /// </summary> 
        /// <returns></returns>
        public static bool StateData()
        {
            int t = ToolCore.GetSimpNum(1, 9999);
            return t % 2 == 0;
        }

        /// <summary>
        /// 矩形内随机一个点
        /// </summary>
        /// <param name="x1">X坐标最小</param>
        /// <param name="x2">X坐标最大</param>
        /// <param name="y1">Y坐标最小</param>
        /// <param name="y2">Y坐标最大</param>
        /// <returns></returns>
        public static int[] RectanglePoint(int x1, int x2, int y1, int y2)
        {
            return new int[] { ToolCore.GetSimpNum(x1, x2), ToolCore.GetSimpNum(y1, y2) };
        }

        public static string YearNumber()
        {
            return ToolCore.GetNum(DateTime.MinValue.Year, DateTime.Now.AddYears(-18).Year);
        }

        public static string MonthNumber()
        {
            return ToolCore.GetNum(1, 12).PadLeft(2, '0');
        }

        public static string DayNumber()
        {
            return ToolCore.GetNum(1, 31).PadLeft(2, '0');
        }


        /// <summary>
        /// 随机增加天数
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public static DateTime DayNumber(int day)
        {
            return DateTime.Now.AddDays(ToolCore.GetSimpNum(1, day) * -1);
        }

    }
}
