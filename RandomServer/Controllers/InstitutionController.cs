using Microsoft.AspNetCore.Mvc;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// 机构
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
        /// 部门岗位
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "ITPosition")]
        public string ITPosition()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.ITPosition);
        }
        /// <summary>
        /// 多个 部门岗位
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
        /// 组织架构
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "DepertmentName")]
        public string DepertmentName()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.DepertmentNames);
        }
        /// <summary>
        /// 多个 组织架构
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
        /// 公司名称
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Company")]
        public string Company()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Company);
        }
        /// <summary>
        /// 多个 公司名称
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
        /// 单据名称
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Receipt")]
        public string Receipt()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Receipts);
        }
        /// <summary>
        /// 多个 单据名称
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
        /// 中央部门机构
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "CentralGovInstitution")]
        public string CentralGovInstitution()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.CentralGovInstitution);
        }
        /// <summary>
        /// 多个 中央部门机构
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
