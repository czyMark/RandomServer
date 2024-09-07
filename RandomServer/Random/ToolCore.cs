using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WebApplication4
{
    public static class ToolCore
    {
        public enum RandomNumFormat
        {
            /// <summary>
            /// .
            /// </summary>
            Point,
            /// <summary>
            /// ,
            /// </summary>
            Comma,
            /// <summary>
            /// /
            /// </summary>
            Slash
        }

        private static System.Random random = new System.Random(Guid.NewGuid().GetHashCode());
        public static double NextDouble() => random.NextDouble();
        public static int Next() => random.Next();
        public static int Next(int max) => random.Next(max);
        public static int Next(int min, int max) => random.Next(min, max);
        private static double oldNum;

        #region 随机获取集合中的值

        /// <summary>
        /// 获取集合中的随机值
        /// </summary>
        /// <typeparam name="T">值类型</typeparam>
        /// <param name="source">值的集合</param>
        /// <returns></returns>
        public static T GetRandomValue<T>(this IEnumerable<T> source)
        {
            return source.ToList()[GetSimpNum(0, source.Count())];
        }

        /// <summary>
        /// 获取不重复的随机值的集合
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="count">数量</param>
        /// <returns></returns>
        public static List<T> GetRandomValue<T>(this IEnumerable<T> source, int count)
        {
            if (source.Count() < count)
                throw new Exception("选择数量不能大于集合数量!");

            var _source = new List<T>(source).Distinct().ToList();
            List<T> resList = new List<T>();
            for (int i = 0; i < count; i++)
            {
                resList.Add(GetNewValue());
            }
            return resList;
            T GetNewValue()
            {
                while (true)
                {
                    var theValue = GetRandomValue(_source);
                    //todo:需要验证值是否一样
                    if (!resList.Any(x => x.GetHashCode() == theValue.GetHashCode()))
                    {
                        _source.Remove(theValue);

                        return theValue;
                    }
                }
            }
        }

        #endregion





        /// <summary>
        /// 生成指定位数的随机数
        /// </summary>
        /// <param name="count">随机数的位数</param>
        /// <returns>返回字符串的数字</returns>
        public static string GetNum(int count)
        {
            double temp = random.NextDouble();


            if (temp == oldNum)
            {
                return GetNum(count);
            }
            else
            {
                oldNum = temp;
            }

            if (count > 15)
            {
                return temp.ToString().Substring(2, 15) + GetNum(count - 15);
            }
            else
            {
                return temp.ToString().Substring(2, count);
            }
        }
         
        /// <summary>
        /// 生成某个区间的整数
        /// </summary>
        /// <param name="min">最小数</param>
        /// <param name="max">最大数</param>
        /// <returns>返回整数</returns>
        public static int GetSimpNum(int min, int max)
        {
            int temp = random.Next(min, max);

            if (temp == oldNum)
            {
                return GetSimpNum(min, max);
            }
            else
            {
                oldNum = temp;
            }
            return temp;
        }

        /// <summary>
        /// 生成指定位数的随机带小数点的小数
        /// </summary>
        /// <param name="count">随机数的位数</param>
        /// <returns>返回字符串的数字</returns>
        public static string GetNum(int count, int decimalCount, RandomNumFormat randomNumFormat = RandomNumFormat.Point)
        {
            switch (randomNumFormat)
            {
                case RandomNumFormat.Point:
                    return $"{GetNum(count)}.{GetNum(decimalCount)}";
                case RandomNumFormat.Comma:
                    return $"{GetNum(count)},{GetNum(decimalCount)}";
                case RandomNumFormat.Slash:
                    return $"{GetNum(count)}/{GetNum(decimalCount)}";
                default:
                    return $"{GetNum(count)}.{GetNum(decimalCount)}";
            }
        }
        /// <summary>

        /// 使用默认的字符集合生成 生成指定位数的随机字符数字和字母
        /// </summary>
        /// <param name="VcodeNum">随机数的位数</param>
        /// <returns>返回一个随机数字符串</returns>
        public static string GetVcodeNum(int VcodeNum)
        {
            //验证码可以显示的字符集合
            string Vchar = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] VcArray = Vchar.Split(new Char[] { ',' });//拆分成数组
            string code = "";//产生的随机数
            int temp = -1;//记录上次随机数值，尽量避避免生产几个一样的随机数
             
            //采用一个简单的算法以保证生成随机数的不同
            for (int i = 1; i < VcodeNum + 1; i++)
            { 
                int t = random.Next(VcArray.Length);//获取随机数
                if (temp != -1 && temp == t)
                {
                    return GetVcodeNum(VcodeNum);//如果获取的随机数重复，则递归调用
                }
                temp = t;//把本次产生的随机数记录起来
                code += VcArray[t];//随机数的位数加一
            }
            return code;
        }

        /// <summary>
        /// 使用指定的字符集合 生成指定位数的随机字符
        /// </summary>
        /// <param name="VcodeNum">随机数的位数</param>
        /// <param name="VcArray">指定字符集合</param>
        /// <returns>返回一个随机数字符串</returns>
        public static List<List<string>> GetVcodeNum(int VcodeNum, Dictionary<string, string> VcArray)
        {

            List<List<string>> code = new List<List<string>>();//产生的随机数
            int temp = -1;//记录上次随机数值，尽量避避免生产几个一样的随机数

            System.Random rand = new System.Random();
            //采用一个简单的算法以保证生成随机数的不同
            for (int i = 1; i < VcodeNum + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new System.Random(i * temp * unchecked((int)DateTime.Now.Ticks));//初始化随机类
                }
                int t = rand.Next(VcArray.Count);//获取随机数
                if (temp != -1 && temp == t)
                {
                    return GetVcodeNum(VcodeNum, VcArray);//如果获取的随机数重复，则递归调用
                }
                temp = t;//把本次产生的随机数记录起来
                code.Add(new List<string>() { VcArray.ElementAt(t).Key, VcArray.ElementAt(t).Value });//随机数的位数加一
            }
            return code;
        }




        /// <summary>
        /// 使用指定的字符集合 生成指定位数的随机字符
        /// </summary>
        /// <param name="VcodeNum">随机数的位数</param>
        /// <param name="VcArray">指定字符集合</param>
        /// <returns>返回一个随机数字符串</returns>
        public static string GetVcodeNum(int VcodeNum, Char[] VcArray)
        {
            if (VcArray == null || VcArray.Length == 0)
                return "";

            string code = "";//产生的随机数
            int temp = -1;//记录上次随机数值，尽量避避免生产几个一样的随机数

            System.Random rand = new System.Random();
            //采用一个简单的算法以保证生成随机数的不同
            for (int i = 1; i < VcodeNum + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new System.Random(i * temp * unchecked((int)DateTime.Now.Ticks));//初始化随机类
                }
                int t = rand.Next(VcArray.Length);//获取随机数
                if (temp != -1 && temp == t)
                {
                    return GetVcodeNum(VcodeNum, VcArray);//如果获取的随机数重复，则递归调用
                }
                temp = t;//把本次产生的随机数记录起来
                code += VcArray[t];//随机数的位数加一
            }
            return code;
        }

        /// <summary>
        /// 使用指定的字符串集合 生成指定位数的随机字符
        /// </summary>
        /// <param name="VcodeNum">随机数的位数</param>
        /// <param name="VcArray">指定字符串集合</param>
        /// <returns>返回一个随机数字符串</returns>
        public static string GetVcodeNum(int VcodeNum, string[] VcArray)
        {

            if (VcArray == null || VcArray.Length == 0)
                return "";
            string code = "";//产生的随机数
            int temp = -1;//记录上次随机数值，尽量避避免生产几个一样的随机数

            System.Random rand = new System.Random();
            //采用一个简单的算法以保证生成随机数的不同
            for (int i = 1; i < VcodeNum + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new System.Random(i * temp * unchecked((int)DateTime.Now.Ticks));//初始化随机类
                }
                int t = rand.Next(VcArray.Length);//获取随机数
                if (temp != -1 && temp == t)
                {
                    return GetVcodeNum(VcodeNum, VcArray);//如果获取的随机数重复，则递归调用
                }
                temp = t;//把本次产生的随机数记录起来
                code += VcArray[t];//随机数的位数加一
            }
            return code;
        }



        public static string GetEnglishSurname()
        {
            string name = string.Empty;
            string[] currentConsonant;
            string[] vowels = "a,a,a,a,a,e,e,e,e,e,e,e,e,e,e,e,i,i,i,o,o,o,u,y,ee,ee,ea,ea,ey,eau,eigh,oa,oo,ou,ough,ay".Split(',');
            string[] commonConsonants = "s,s,s,s,t,t,t,t,t,n,n,r,l,d,sm,sl,sh,sh,th,th,th".Split(',');
            string[] averageConsonants = "sh,sh,st,st,b,c,f,g,h,k,l,m,p,p,ph,wh".Split(',');
            string[] middleConsonants = "x,ss,ss,ch,ch,ck,ck,dd,kn,rt,gh,mm,nd,nd,nn,pp,ps,tt,ff,rr,rk,mp,ll".Split(','); //Can't start
            string[] rareConsonants = "j,j,j,v,v,w,w,w,z,qu,qu".Split(',');
            int[] lengthArray = new int[] { 2, 2, 2, 2, 2, 2, 3, 3, 3, 4 }; //Favor shorter names but allow longer ones
            int length = lengthArray[random.Next(lengthArray.Length)];
            for (int i = 0; i < length; i++)
            {
                int letterType = random.Next(1000);
                if (letterType < 775) currentConsonant = commonConsonants;
                else if (letterType < 875 && i > 0) currentConsonant = middleConsonants;
                else if (letterType < 985) currentConsonant = averageConsonants;
                else currentConsonant = rareConsonants;
                name += currentConsonant[random.Next(currentConsonant.Length)];
                name += vowels[random.Next(vowels.Length)];
                if (name.Length > 4 && random.Next(1000) < 800) break; //Getting long, must roll to save
                if (name.Length > 6 && random.Next(1000) < 950) break; //Really long, roll again to save
                if (name.Length > 7) break; //Probably ridiculous, stop building and add ending
            }
            int endingType = random.Next(1000);
            if (name.Length > 6)
                endingType -= (name.Length * 25); //Don't add long endings if already long
            else
                endingType += (name.Length * 10); //Favor long endings if short
            if (endingType < 400) { } // Ends with vowel
            else if (endingType < 775) name += commonConsonants[random.Next(commonConsonants.Length)];
            else if (endingType < 825) name += averageConsonants[random.Next(averageConsonants.Length)];
            else if (endingType < 840) name += "ski";
            else if (endingType < 860) name += "son";
            else if (Regex.IsMatch(name, "(.+)(ay|e|ee|ea|oo)$") || name.Length < 5)
            {
                name = "Mc" + name.Substring(0, 1).ToUpper() + name.Substring(1);
                return name;
            }
            else name += "ez";
            name = name.Substring(0, 1).ToUpper() + name.Substring(1); //Capitalize first letter
            return name;
        }
    }
}
