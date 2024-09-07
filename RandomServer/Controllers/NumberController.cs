using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    /// <summary>
    /// ����
    /// </summary> 
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class NumberController : ControllerBase
    {
        private readonly ILogger<NumberController> _logger;

        public NumberController(ILogger<NumberController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// ָ����������
        /// </summary>
        /// <param name="length">����</param>
        /// <returns></returns>
        [HttpGet(Name = "Num")]
        public string Num(int length)
        {
            return ToolCore.GetNum(length);
        }

        /// <summary>
        /// ��� ָ����������
        /// </summary>
        /// <param name="length">����</param>
        /// <param name="num">����</param>
        /// <returns></returns>
        [HttpGet(Name = "Nums")]
        public IEnumerable<string> Nums(int length, int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetNum(length)}");
            }
            return items;
        }
        /// <summary>
        /// ָ��λ��С��
        /// </summary>
        /// <param name="length">С����ǰ����</param>
        /// <param name="decimallength">С����󳤶�</param>
        /// <returns></returns>
        [HttpGet(Name = "NumDecimal")]
        public string NumDecimal(int length, int decimallength)
        {

            return ToolCore.GetNum(length, decimallength);
        }

        /// <summary>
        /// ָ��λ��С�� .����
        /// </summary>
        /// <param name="length">С����ǰ����</param>
        /// <param name="decimallength">С����󳤶�</param>
        /// <param name="num">����</param>
        /// <returns></returns>
        [HttpGet(Name = "NumDecimals")]
        public IEnumerable<string> NumDecimals(int length, int decimallength, int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetNum(length, decimallength, ToolCore.RandomNumFormat.Point)}");
            }
            return items;
        }

        /// <summary>
        /// ָ��λ��С�� .����
        /// </summary>
        /// <param name="length">С����ǰ����</param>
        /// <param name="decimallength">С����󳤶�</param> 
        /// <returns></returns>
        [HttpGet(Name = "NumDecimalPoint")]
        public string NumDecimalPoint(int length, int decimallength)
        {

            return ToolCore.GetNum(length, decimallength, ToolCore.RandomNumFormat.Point);
        }

        /// <summary>
        /// ָ��λ��С�� .����
        /// </summary>
        /// <param name="length">С����ǰ����</param>
        /// <param name="decimallength">С����󳤶�</param>
        /// <param name="num">����</param>
        /// <returns></returns>
        [HttpGet(Name = "NumDecimalPoints")]
        public IEnumerable<string> NumDecimalPoints(int length, int decimallength, int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetNum(length, decimallength, ToolCore.RandomNumFormat.Point)}");
            }
            return items;
        }


        /// <summary>
        /// ָ��λ��С�� ,����
        /// </summary>
        /// <param name="length">С����ǰ����</param>
        /// <param name="decimallength">С����󳤶�</param> 
        /// <returns></returns>
        [HttpGet(Name = "NumDecimalCommat")]
        public string NumDecimalCommat(int length, int decimallength)
        {

            return ToolCore.GetNum(length, decimallength, ToolCore.RandomNumFormat.Comma);
        }

        /// <summary>
        /// ָ��λ��С�� ,����
        /// </summary>
        /// <param name="length">С����ǰ����</param>
        /// <param name="decimallength">С����󳤶�</param>
        /// <param name="num">����</param>
        /// <returns></returns>
        [HttpGet(Name = "NumDecimalCommats")]
        public IEnumerable<string> NumDecimalCommats(int length, int decimallength, int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetNum(length, decimallength, ToolCore.RandomNumFormat.Comma)}");
            }
            return items;
        }

        /// <summary>
        /// ָ��λ��С�� /����
        /// </summary>
        /// <param name="length">С����ǰ����</param>
        /// <param name="decimallength">С����󳤶�</param> 
        /// <returns></returns>
        [HttpGet(Name = "NumDecimalSlasht")]
        public string NumDecimalSlasht(int length, int decimallength)
        {

            return ToolCore.GetNum(length, decimallength, ToolCore.RandomNumFormat.Slash);
        }


        /// <summary>
        /// ָ��λ��С�� /����
        /// </summary>
        /// <param name="length">С����ǰ����</param>
        /// <param name="decimallength">С����󳤶�</param>
        /// <param name="num">����</param>
        /// <returns></returns>
        [HttpGet(Name = "NumDecimalSlashts")]
        public IEnumerable<string> NumDecimalSlashts(int length, int decimallength, int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                items.Add($"{ToolCore.GetNum(length, decimallength, ToolCore.RandomNumFormat.Slash)}");
            }
            return items;
        }

    }
}
