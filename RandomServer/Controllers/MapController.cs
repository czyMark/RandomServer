using Microsoft.AspNetCore.Mvc;
using System;
using System.IO.Pipelines;

namespace WebApplication4.Controllers
{
    /// <summary>
    /// ��ͼ����
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
        /// ����JS��ͼ�������� world-����  china-�й�  province-��ʡƴ�� 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "MapJs")]
        public IActionResult MapJs(string MapName)
        {
            try
            {
                //��ȡ��
                string file = "\\Data\\Map\\jsmap\\" + MapName + ".js";
                string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

                FileStream fs = new FileStream(localpath, FileMode.Open);
                return File(fs, "text/javascript");//������ļ���ʽ���� 
            }
            catch (Exception ex)
            {
                //��ȡ��
                string file = "\\Data\\Map\\jsmap\\china.js";
                string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

                FileStream fs = new FileStream(localpath, FileMode.Open);
                return File(fs, "text/javascript");//������ļ���ʽ���� 
            }
        }
        /// <summary>
        /// ����Shp��ͼ��������  ֱ��ͨ���Ǳ������ã�����ֱ����������ʹ��
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "MapShp")]
        public IActionResult MapShp()
        {
            //��ȡ��
            string file = "\\Data\\Map\\shpmap.rar";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            return File(fs, "application/x-rar-compressed");//������ļ���ʽ����
        }
        /// <summary>
        /// ��ά��Ƭ����  ֱ��ͨ���Ǳ������ã�����ֱ����������ʹ��
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "MapSmwu")]
        public IActionResult MapSmwu()
        {
            //��ȡ��
            string file = "\\Data\\Map\\Smwu.rar";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            return File(fs, "application/x-rar-compressed");//������ļ���ʽ����
        }

    }
}
