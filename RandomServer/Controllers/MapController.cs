using Microsoft.AspNetCore.Mvc;
using System;
using System.IO.Pipelines;

namespace WebApplication4.Controllers
{
    /// <summary>
    /// 地图数据
    /// </summary> 
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class MapController : ControllerBase
    {
        private readonly ILogger<MapController> _logger;

        public MapController(ILogger<MapController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 常用JS地图轮廓数据 world-世界  china-中国  province-各省拼音 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "MapJs")]
        public IActionResult MapJs(string MapName)
        {
            try
            {
                //读取流
                string file = "\\Data\\Map\\jsmap\\" + MapName + ".js";
                string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

                FileStream fs = new FileStream(localpath, FileMode.Open);
                return File(fs, "text/javascript");//最后以文件形式返回 
            }
            catch (Exception ex)
            {
                //读取流
                string file = "\\Data\\Map\\jsmap\\china.js";
                string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

                FileStream fs = new FileStream(localpath, FileMode.Open);
                return File(fs, "text/javascript");//最后以文件形式返回 
            }
        }
        /// <summary>
        /// 常用Shp地图轮廓数据  直接通常是本地配置，所以直接下载用于使用
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "MapShp")]
        public IActionResult MapShp()
        {
            //读取流
            string file = "\\Data\\Map\\shpmap.rar";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            return File(fs, "application/x-rar-compressed");//最后以文件形式返回
        }
        /// <summary>
        /// 三维切片数据  直接通常是本地配置，所以直接下载用于使用
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "MapSmwu")]
        public IActionResult MapSmwu()
        {
            //读取流
            string file = "\\Data\\Map\\Smwu.rar";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            return File(fs, "application/x-rar-compressed");//最后以文件形式返回
        }

    }
}
