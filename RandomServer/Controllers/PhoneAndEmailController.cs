using Microsoft.AspNetCore.Mvc;
using WebApplication4.Random;

namespace WebApplication4.Controllers
{
    /// <summary>
    /// �ֻ��� ������
    /// </summary> 
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class PhoneAndEmailController : ControllerBase
    {
        private readonly ILogger<PhoneAndEmailController> _logger;

        public PhoneAndEmailController(ILogger<PhoneAndEmailController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// �ƶ��ֻ���
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "PhoneNumber")]
        public string PhoneNumber()
        {
            return ToolFun.PhoneNumber();
        }
        /// <summary>
        /// ��� �ƶ��ֻ���
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "PhoneNumbers")]
        public IEnumerable<string> PhoneNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.PhoneNumber());
            }
            return items;
        }


        /// <summary>
        /// �����ֻ���
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "CTCNumber")]
        public string CTCNumber()
        {
            return ToolFun.CTCNumber();
        }
        /// <summary>
        /// ��� �����ֻ���
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "CTCNumbers")]
        public IEnumerable<string> CTCNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.CTCNumber());
            }
            return items;
        }


        /// <summary>
        /// ��ͨ�ֻ���
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "CUCCNumber")]
        public string CUCCNumber()
        {
            return ToolFun.CUCCNumber();
        }
        /// <summary>
        /// ��� ��ͨ�ֻ���
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "CUCCNumbers")]
        public IEnumerable<string> CUCCNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.CUCCNumber());
            }
            return items;
        }


        /// <summary>
        /// �ƶ��ֻ���
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "CMCCNumber")]
        public string CMCCNumber()
        {
            return ToolFun.CMCCNumber();
        }
        /// <summary>
        /// ��� �ƶ��ֻ���
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "CMCCNumbers")]
        public IEnumerable<string> CMCCNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.CMCCNumber());
            }
            return items;
        }


        /// <summary>
        /// Ӣ������
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "EnglishNameEmailNumber")]
        public string EnglishNameEmailNumber()
        {
            return ToolFun.EnglishNameEmailNumber();
        }
        /// <summary>
        /// ��� Ӣ������
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "EnglishNameEmailNumbers")]
        public IEnumerable<string> EnglishNameEmailNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.EnglishNameEmailNumber());
            }
            return items;
        }




        /// <summary>
        /// �ֻ�������
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "PhoneEmailNumber")]
        public string PhoneEmailNumber()
        {
            return ToolFun.PhoneEmailNumber();
        }
        /// <summary>
        /// ��� �ֻ�������
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "PhoneEmailNumbers")]
        public IEnumerable<string> PhoneEmailNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.PhoneEmailNumber());
            }
            return items;
        }




        /// <summary>
        /// �ַ�����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "CharEmailNumber")]
        public string CharEmailNumber()
        {
            return ToolFun.CharEmailNumber();
        }
        /// <summary>
        /// ��� �ַ�����
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "CharEmailNumbers")]
        public IEnumerable<string> CharEmailNumbers(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolFun.CharEmailNumber());
            }
            return items;
        }

    }
}
