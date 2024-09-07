using Microsoft.AspNetCore.Mvc;
using System;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// 常用数据
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// IP地址
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IpAddr")]
        public string IpAddr()
        {
            return ToolFun.GetIp();
        }
        /// <summary>
        /// 多个ip地址
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "IpAddrs")]
        public IEnumerable<string> IpAddrs(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.GetIp());
            }
            return items;
        }



         

        /// <summary>
        /// 身份证号
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IDCodeNumber")]
        public string IDCodeNumber()
        {
            return ToolFun.IDCodeNumber();
        }
        /// <summary>
        /// 多个身份证号
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "IDCodeNumbers")]
        public IEnumerable<string> IDCodeNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.IDCodeNumber());
            }
            return items;
        }




        /// <summary>
        /// 公务普通护照
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IDPostCodeNumber")]
        public string IDPostCodeNumber()
        {
            return ToolFun.IDPostCodeNumber();
        }
        /// <summary>
        /// 多个 公务普通护照
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "IDPostCodeNumbers")]
        public IEnumerable<string> IDPostCodeNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.IDPostCodeNumber());
            }
            return items;
        }

        /// <summary>
        /// 公务护照
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IDSEPostCodeNumber")]
        public string IDSEPostCodeNumber()
        {
            return ToolFun.IDPostCodeNumber("SE");
        }
        /// <summary>
        /// 多个公务护照
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "IDSEPostCodeNumbers")]
        public IEnumerable<string> IDSEPostCodeNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.IDPostCodeNumber("SE"));
            }
            return items;
        }


        /// <summary>
        /// 外交护照
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IDDEPostCodeNumber")]
        public string IDDEPostCodeNumber()
        {
            return ToolFun.IDPostCodeNumber("DE");
        }
        /// <summary>
        /// 多个 外交护照
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "IDDEPostCodeNumbers")]
        public IEnumerable<string> IDDEPostCodeNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.IDPostCodeNumber("DE"));
            }
            return items;
        }

        /// <summary>
        ///  状态
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "StateData")]
        public string StateData()
        {
            return ToolFun.StateData().ToString();
        }


        /// <summary>
        /// 多个  状态
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "StateDatas")]
        public IEnumerable<string> StateDatas(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolFun.StateData().ToString()}");
            }
            return items; 
        }


        /// <summary>
        ///  正方形随机 坐标
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "RectanglePoint")]
        public int[] RectanglePoint(int x1, int x2, int y1, int y2)
        {
            return ToolFun.RectanglePoint(x1, x2, y1, y2);
        }



        /// <summary>
        ///  多个 正方形随机 坐标
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "RectanglePoints")]
        public List<List<int>> RectanglePoints(int x1, int x2, int y1, int y2,int num)
        {
            var items=new List<List<int>>();
            for (int i = 0; i < num; i++)
            {
                items.Add(ToolFun.RectanglePoint(x1, x2, y1, y2).ToList());
            }
            return items;
        }

        /// <summary>
        ///  中文字字符串
        /// </summary>
        /// <param name="length">中文字字数</param>
        /// <returns></returns>
        [HttpGet(Name = "ZHCN")]
        public string ZHCN(int length)
        {
            return ToolFun.GetChinese(length);
        }

        /// <summary>
        /// 多个 中文字字符串
        /// </summary>
        /// <param name="length">中文字字数</param>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "ZHCNS")]
        public IEnumerable<string> ZHCNS(int length, int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolFun.GetChinese(length)}");
            }
            return items;
        }


        /// <summary>
        ///  常用字
        /// </summary>
        /// <param name="length">中文字字数</param>
        /// <returns></returns>
        [HttpGet(Name = "FrequentlyZHCN")]
        public string FrequentlyZHCN(int length)
        {
            return ToolCore.GetVcodeNum(length, RandomData.Instance.FrequentlyZHCN);
        }


        /// <summary>
        /// 多个 常用字
        /// </summary>
        /// <param name="length">中文字字数</param>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "FrequentlyZHCNS")]
        public IEnumerable<string> FrequentlyZHCNS(int length, int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(length, RandomData.Instance.FrequentlyZHCN)}");
            }
            return items;
        }


        /// <summary>
        ///  成语
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "Idiom")]
        public string Idiom()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Idioms);
        }


        /// <summary>
        /// 多个 成语
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "Idioms")]
        public IEnumerable<string> Idioms(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.Idioms)}");
            }
            return items;
        }




        /// <summary>
        ///  四字成语
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "IdiomFour")]
        public string IdiomFour()
        {
            return idiom4();
        }
        /// <summary>
        /// 临时组织
        /// </summary>
        /// <returns></returns>
        private string idiom4()
        {
            var temp = ToolCore.GetVcodeNum(1, RandomData.Instance.Idioms);
            if (temp.Length > 4)
            {
                temp = idiom4();
            }
            return temp;
        }

        /// <summary>
        /// 多个 四字成语
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        [HttpGet(Name = "IdiomFours")]
        public IEnumerable<string> IdiomFours(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{idiom4()}");
            }
            return items;
        }



    }
}
