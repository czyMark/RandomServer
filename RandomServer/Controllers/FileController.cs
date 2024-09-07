using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using RandomServer.Helper;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// 文件数据
    /// </summary> 
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 验证码图片
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "CaptchaImage")]
        public IActionResult CaptchaImage()
        {
            string sessionId = new Guid().ToString("d");

            Tuple<string, int> captchaCode = CaptchaHelper.GetCaptchaCode();
            byte[] bytes = CaptchaHelper.CreateCaptchaImage(captchaCode.Item1);
            return File(bytes, @"image/jpeg");
        }

        /// <summary>
        /// 图片
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Image")]
        public IActionResult Image()
        {
            //读取图片流
            string file = "\\Data\\Image\\" + ToolCore.GetSimpNum(1, 36) + ".jpg";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            byte[] bytes;
            using (FileStream fs = new FileStream(localpath, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
            }
            return File(bytes, @"image/jpeg");
        }

        /// <summary>
        /// 视频
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Video")]
        public IActionResult Video()
        {
            //读取流
            string file = "\\Data\\Video\\" + ToolCore.GetSimpNum(1, 10) + ".mp4";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            byte[] bytes;
            using (FileStream fs = new FileStream(localpath, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
            }
            return File(bytes, @"video/mp4");
        }



        /// <summary>
        /// 视频 -风景
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "VideoView")]
        public IActionResult VideoView()
        {
            //读取流
            string file = "\\Data\\Video\\View\\" + ToolCore.GetSimpNum(1, 6) + ".mp4";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            byte[] bytes;
            using (FileStream fs = new FileStream(localpath, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
            }
            return File(bytes, @"video/mp4");
        }
        /// <summary>
        /// 视频 - 道路
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "VideoRoad")]
        public IActionResult VideoRoad()
        {
            //读取流
            string file = "\\Data\\Video\\Road\\" + ToolCore.GetSimpNum(1, 10) + ".mp4";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            byte[] bytes;
            using (FileStream fs = new FileStream(localpath, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
            }
            return File(bytes, @"video/mp4");
        }




        /// <summary>
        /// 文档
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Doc")]
        public IActionResult Doc()
        {
            //读取图片流
            string file = "\\Data\\Document\\Doc\\" + ToolCore.GetSimpNum(1, 10) + ".docx";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            //return File(fs, "application/msword"); //doc
            return File(fs, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
        /// <summary>
        /// 表格文档
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Excel")]
        public IActionResult Excel()
        {
            //读取图片流
            string file = "\\Data\\Document\\Excel\\" + ToolCore.GetSimpNum(1, 6) + ".xlsx";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            //application/vnd.ms-excel
            return File(fs, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");//最后以文件形式返回
        }


        /// <summary>
        /// PDF文档
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Pdf")]
        public IActionResult Pdf()
        {
            //读取图片流
            string file = "\\Data\\Document\\pdf\\" + ToolCore.GetSimpNum(1, 8) + ".pdf";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            return File(fs, "application/pdf");//最后以文件形式返回
        }

        /// <summary>
        /// PPT
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "PPT")]
        public IActionResult PPT()
        {
            //读取图片流
            string file = "\\Data\\Document\\ppt\\" + ToolCore.GetSimpNum(1, 6) + ".pptx";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            //application/vnd.ms-powerpoint
            return File(fs, "application/vnd.openxmlformats-officedocument.presentationml.presentation");//最后以文件形式返回
        }

        /// <summary>
        /// Rar
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Rar")]
        public IActionResult Rar()
        {
            //读取流
            string file = "\\Data\\Document\\rar\\" + ToolCore.GetSimpNum(1, 11) + ".rar";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            return File(fs, "application/x-rar-compressed");//最后以文件形式返回
        }

    }
}
