using Microsoft.AspNetCore.Mvc;
using System;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// 通用数据
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class GeneralController : ControllerBase
    {
        private readonly ILogger<GeneralController> _logger;

        public GeneralController(ILogger<GeneralController> logger)
        {
            _logger = logger;
        }

        //根据发送过来的参数 组织对应的数据
        //例如 10行数据，1列id,2列文字，3列身份证号，4列地址，5列名字，7列 6个状态，8列经度 9列维度、10列数值 10以内。
        //返回的列名C1 C2 C3 ....C10


        //根据接口默认示例为：
        //返回一个通用图表的数据
        //数据来源 标题 数据发布日期  类型编码-001003001 数据
        //数据:AName 分类名称 SName 系列名称 V1值1 V2值2 V3值3 V4值4 Lat[X] Lon-[Y]


        //增加示例：列表
    }
}
