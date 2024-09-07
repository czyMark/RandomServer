using Microsoft.AspNetCore.Mvc;
using System;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// ��������
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
        /// IP��ַ
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IpAddr")]
        public string IpAddr()
        {
            return ToolFun.GetIp();
        }
        /// <summary>
        /// ���ip��ַ
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
        /// ���֤��
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IDCodeNumber")]
        public string IDCodeNumber()
        {
            return ToolFun.IDCodeNumber();
        }
        /// <summary>
        /// ������֤��
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
        /// ������ͨ����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IDPostCodeNumber")]
        public string IDPostCodeNumber()
        {
            return ToolFun.IDPostCodeNumber();
        }
        /// <summary>
        /// ��� ������ͨ����
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
        /// ������
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IDSEPostCodeNumber")]
        public string IDSEPostCodeNumber()
        {
            return ToolFun.IDPostCodeNumber("SE");
        }
        /// <summary>
        /// ���������
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
        /// �⽻����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "IDDEPostCodeNumber")]
        public string IDDEPostCodeNumber()
        {
            return ToolFun.IDPostCodeNumber("DE");
        }
        /// <summary>
        /// ��� �⽻����
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
        ///  ״̬
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "StateData")]
        public string StateData()
        {
            return ToolFun.StateData().ToString();
        }


        /// <summary>
        /// ���  ״̬
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
        ///  ��������� ����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "RectanglePoint")]
        public int[] RectanglePoint(int x1, int x2, int y1, int y2)
        {
            return ToolFun.RectanglePoint(x1, x2, y1, y2);
        }



        /// <summary>
        ///  ��� ��������� ����
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
        ///  �������ַ���
        /// </summary>
        /// <param name="length">����������</param>
        /// <returns></returns>
        [HttpGet(Name = "ZHCN")]
        public string ZHCN(int length)
        {
            return ToolFun.GetChinese(length);
        }

        /// <summary>
        /// ��� �������ַ���
        /// </summary>
        /// <param name="length">����������</param>
        /// <param name="num">����</param>
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
        ///  ������
        /// </summary>
        /// <param name="length">����������</param>
        /// <returns></returns>
        [HttpGet(Name = "FrequentlyZHCN")]
        public string FrequentlyZHCN(int length)
        {
            return ToolCore.GetVcodeNum(length, RandomData.Instance.FrequentlyZHCN);
        }


        /// <summary>
        /// ��� ������
        /// </summary>
        /// <param name="length">����������</param>
        /// <param name="num">����</param>
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
        ///  ����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "Idiom")]
        public string Idiom()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Idioms);
        }


        /// <summary>
        /// ��� ����
        /// </summary>
        /// <param name="num">����</param>
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
        ///  ���ֳ���
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "IdiomFour")]
        public string IdiomFour()
        {
            return idiom4();
        }
        /// <summary>
        /// ��ʱ��֯
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
        /// ��� ���ֳ���
        /// </summary>
        /// <param name="num">����</param>
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
