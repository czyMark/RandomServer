using Microsoft.AspNetCore.Mvc;
using System;

namespace RandomServer.Controllers
{
    /// <summary>
    /// ����
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
        ///  ������
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNName")]
        public string CNName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.AllSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames);
        }


        /// <summary>
        /// ���  ������
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
        ///  ������-����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSName")]
        public string CNSName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames);
        }


        /// <summary>
        /// ���  ������-����
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
        ///  ������-����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMName")]
        public string CNMName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.FashionNames);
        }


        /// <summary>
        /// ���  ������-����
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
        ///  ������-����-��
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSManName")]
        public string CNSManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.ManNames);
        }


        /// <summary>
        /// ���  ������-����-��
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
        ///  ������-����-��
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMManName")]
        public string CNMManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.ManNames);
        }


        /// <summary>
        /// ���  ������-����-��
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
        ///  ������-����-Ů
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNSWoManName")]
        public string CNSWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.SingleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNames);
        }


        /// <summary>
        /// ���  ������-����-Ů
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
        ///  ������-����-Ů
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "CNMWoManName")]
        public string CNMWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.DoubleSurname) + ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNames);
        }


        /// <summary>
        /// ���  ������-����-Ů
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
        ///  Ӣ����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENName")]
        public string ENName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.EnglishNames);
        }


        /// <summary>
        /// ��� Ӣ����
        /// </summary>
        /// <param name="num">����</param>
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
        ///  Ӣ����-����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENManName")]
        public string ENManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManEnglishNames);
        }


        /// <summary>
        /// ��� Ӣ����-����
        /// </summary>
        /// <param name="num">����</param>
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
        ///  Ӣ����-Ů��
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENWoManName")]
        public string ENWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManEnglishNames);
        }


        /// <summary>
        /// ��� Ӣ����-Ů��
        /// </summary>
        /// <param name="num">����</param>
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
        ///  �����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENCHName")]
        public string ENCHName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.EnglishChinaNames);
        }


        /// <summary>
        /// ��� �����
        /// </summary>
        /// <param name="num">����</param>
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
        ///  �����-����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENManCHName")]
        public string ENManCHName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManEnglishChinaNames);
        }


        /// <summary>
        /// ��� �����--����
        /// </summary>
        /// <param name="num">����</param>
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
        ///  �����-Ů��
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "ENWoManCHName")]
        public string ENWoManCHName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManEnglishChinaNames);
        }


        /// <summary>
        /// ��� �����-Ů��
        /// </summary>
        /// <param name="num">����</param>
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
        ///  �ձ���
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanName")]
        public string JapanName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.JapanNames);
        }


        /// <summary>
        /// ���  �ձ���
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
        ///  �ձ���-����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanManName")]
        public string JapanManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManJapanNames);
        }


        /// <summary>
        /// ���  �ձ���-����
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
        ///  �ձ���-Ů��
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "JapanWoManName")]
        public string JapanWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManJapanNames);
        }


        /// <summary>
        /// ���  �ձ���-Ů��
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
        ///  ������
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaName")]
        public string KoreaName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.KoreaNames);
        }


        /// <summary>
        /// ���  ������
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
        ///  ������-����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaManName")]
        public string KoreaManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManKoreaNames);
        }


        /// <summary>
        /// ���  ������-����
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
        ///  ������-Ů��
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "KoreaWoManName")]
        public string KoreaWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManKoreaNames);
        }


        /// <summary>
        /// ���  ������-Ů��
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
        ///  ������
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkName")]
        public string NetWorkName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.NetWorkNames);
        }


        /// <summary>
        /// ���  ������
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
        ///  ������-����
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkManName")]
        public string NetWorkManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ManNetWorkNames);
        }


        /// <summary>
        /// ���  ������-����
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
        ///  ������-Ů��
        /// </summary> 
        /// <returns></returns>
        [HttpGet(Name = "NetWorkWoManName")]
        public string NetWorkWoManName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.WoManNetWorkNames);
        }


        /// <summary>
        /// ���  ������-Ů��
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
