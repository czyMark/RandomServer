using Microsoft.AspNetCore.Mvc;
using System;

namespace RandomServer.Controllers
{
    /// <summary>
    /// 名字
    /// </summary> 
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class NameController : ControllerBase
    {
        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }







        /// <summary>
        ///  中文名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNName")]
        public string CNName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.AllSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames);
        }


        /// <summary>
        /// 多个  中文名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNNames")]
        public IEnumerable<string> CNNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.AllSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames)}");
            }
            return items;
        }




        /// <summary>
        ///  中文名-单姓
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSName")]
        public string CNSName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames);
        }


        /// <summary>
        /// 多个  中文名-单姓
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSNames")]
        public IEnumerable<string> CNSNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames)}");
            }
            return items;
        }




        /// <summary>
        ///  中文名-复姓
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMName")]
        public string CNMName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames);
        }


        /// <summary>
        /// 多个  中文名-复姓
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMNames")]
        public IEnumerable<string> CNMNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames)}");
            }
            return items;
        }






        /// <summary>
        ///  中文名-单姓-男
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSManName")]
        public string CNSManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.ManNames);
        }


        /// <summary>
        /// 多个  中文名-单姓-男
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSManNames")]
        public IEnumerable<string> CNSManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.ManNames)}");
            }
            return items;
        }




        /// <summary>
        ///  中文名-复姓-男
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMManName")]
        public string CNMManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.ManNames);
        }


        /// <summary>
        /// 多个  中文名-复姓-男
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMManNames")]
        public IEnumerable<string> CNMManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.ManNames)}");
            }
            return items;
        }





        /// <summary>
        ///  中文名-单姓-女
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSWoManName")]
        public string CNSWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNames);
        }


        /// <summary>
        /// 多个  中文名-单姓-女
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSWoManNames")]
        public IEnumerable<string> CNSWoManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNames)}");
            }
            return items;
        }




        /// <summary>
        ///  中文名-复姓-女
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMWoManName")]
        public string CNMWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNames);
        }


        /// <summary>
        /// 多个  中文名-复姓-女
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMWoManNames")]
        public IEnumerable<string> CNMWoManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNames)}");
            }
            return items;
        }






        /// <summary>
        ///  英文名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENName")]
        public string ENName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.EnglishNames);
        }


        /// <summary>
        /// 多个 英文名
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "ENNames")]
        public IEnumerable<string> ENNames(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.EnglishNames)}");
            }
            return items;
        }


        /// <summary>
        ///  英文名-男性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENManName")]
        public string ENManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManEnglishNames);
        }


        /// <summary>
        /// 多个 英文名-男性
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "ENManNames")]
        public IEnumerable<string> ENManNames(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.ManEnglishNames)}");
            }
            return items;
        }



        /// <summary>
        ///  英文名-女性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENWoManName")]
        public string ENWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManEnglishNames);
        }


        /// <summary>
        /// 多个 英文名-女性
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "ENWoManNames")]
        public IEnumerable<string> ENWoManNames(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.WoManEnglishNames)}");
            }
            return items;
        }

        /// <summary>
        ///  外国名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENCHName")]
        public string ENCHName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.EnglishChinaNames);
        }


        /// <summary>
        /// 多个 外国名
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "ENCHNames")]
        public IEnumerable<string> ENCHNames(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.EnglishChinaNames)}");
            }
            return items;
        }




        /// <summary>
        ///  外国名-男性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENManCHName")]
        public string ENManCHName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManEnglishChinaNames);
        }


        /// <summary>
        /// 多个 外国名--男性
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "ENManCHNames")]
        public IEnumerable<string> ENManCHNames(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.ManEnglishChinaNames)}");
            }
            return items;
        }


        /// <summary>
        ///  外国名-女性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENWoManCHName")]
        public string ENWoManCHName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManEnglishChinaNames);
        }


        /// <summary>
        /// 多个 外国名-女性
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "ENWoManCHNames")]
        public IEnumerable<string> ENWoManCHNames(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.WoManEnglishChinaNames)}");
            }
            return items;
        }




        /// <summary>
        ///  日本名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanName")]
        public string JapanName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.JapanNames);
        }


        /// <summary>
        /// 多个  日本名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanNames")]
        public IEnumerable<string> JapanNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.JapanNames)}");
            }
            return items;
        }



        /// <summary>
        ///  日本名-男性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanManName")]
        public string JapanManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManJapanNames);
        }


        /// <summary>
        /// 多个  日本名-男性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanManNames")]
        public IEnumerable<string> JapanManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.ManJapanNames)}");
            }
            return items;
        }





        /// <summary>
        ///  日本名-女性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanWoManName")]
        public string JapanWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManJapanNames);
        }


        /// <summary>
        /// 多个  日本名-女性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanWoManNames")]
        public IEnumerable<string> JapanWoManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.WoManJapanNames)}");
            }
            return items;
        }




        /// <summary>
        ///  韩国名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaName")]
        public string KoreaName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.KoreaNames);
        }


        /// <summary>
        /// 多个  韩国名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaNames")]
        public IEnumerable<string> KoreaNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.KoreaNames)}");
            }
            return items;
        }



        /// <summary>
        ///  韩国名-男性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaManName")]
        public string KoreaManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManKoreaNames);
        }


        /// <summary>
        /// 多个  韩国名-男性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaManNames")]
        public IEnumerable<string> KoreaManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.ManKoreaNames)}");
            }
            return items;
        }





        /// <summary>
        ///  韩国名-女性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaWoManName")]
        public string KoreaWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManKoreaNames);
        }


        /// <summary>
        /// 多个  韩国名-女性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaWoManNames")]
        public IEnumerable<string> KoreaWoManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.WoManKoreaNames)}");
            }
            return items;
        }







        /// <summary>
        ///  网络名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkName")]
        public string NetWorkName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.NetWorkNames);
        }


        /// <summary>
        /// 多个  网络名
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkNames")]
        public IEnumerable<string> NetWorkNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.NetWorkNames)}");
            }
            return items;
        }



        /// <summary>
        ///  网络名-男性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkManName")]
        public string NetWorkManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManNetWorkNames);
        }


        /// <summary>
        /// 多个  网络名-男性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkManNames")]
        public IEnumerable<string> NetWorkManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.ManNetWorkNames)}");
            }
            return items;
        }





        /// <summary>
        ///  网络名-女性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkWoManName")]
        public string NetWorkWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNetWorkNames);
        }


        /// <summary>
        /// 多个  网络名-女性
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkWoManNames")]
        public IEnumerable<string> NetWorkWoManNames(int num)
        {

            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNetWorkNames)}");
            }
            return items;
        }

    }
}
