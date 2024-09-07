using Microsoft.AspNetCore.Mvc;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// ����
    /// </summary> 
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class InstitutionController : ControllerBase
    {
        private readonly ILogger<InstitutionController> _logger;

        public InstitutionController(ILogger<InstitutionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// ���Ÿ�λ
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "ITPosition")]
        public string ITPosition()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ITPosition);
        }
        /// <summary>
        /// ��� ���Ÿ�λ
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "ITPositions")]
        public IEnumerable<string> ITPositions(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.ITPosition));
            }
            return items;
        }


        /// <summary>
        /// ��֯�ܹ�
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "DepertmentName")]
        public string DepertmentName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.DepertmentNames);
        }
        /// <summary>
        /// ��� ��֯�ܹ�
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "DepertmentNames")]
        public IEnumerable<string> DepertmentNames(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.DepertmentNames));
            }
            return items;
        }


        /// <summary>
        /// ��˾����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Company")]
        public string Company()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Company);
        }
        /// <summary>
        /// ��� ��˾����
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "Companys")]
        public IEnumerable<string> Companys(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.Company));
            }
            return items;
        }
        
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Receipt")]
        public string Receipt()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Receipts);
        }
        /// <summary>
        /// ��� ��������
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "Receipts")]
        public IEnumerable<string> Receipts(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.Receipts));
            }
            return items;
        }


        /// <summary>
        /// ���벿�Ż���
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "CentralGovInstitution")]
        public string CentralGovInstitution()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.CentralGovInstitution);
        }
        /// <summary>
        /// ��� ���벿�Ż���
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "CentralGovInstitutions")]
        public IEnumerable<string> CentralGovInstitutions(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.CentralGovInstitution));
            }
            return items;
        }


         

    }
}
