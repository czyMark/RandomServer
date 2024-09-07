using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using RandomServer.Helper;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// �ļ�����
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
        /// ��֤��ͼƬ
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
        /// ͼƬ
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Image")]
        public IActionResult Image()
        {
            //��ȡͼƬ��
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
        /// ��Ƶ
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Video")]
        public IActionResult Video()
        {
            //��ȡ��
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
        /// ��Ƶ -�羰
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "VideoView")]
        public IActionResult VideoView()
        {
            //��ȡ��
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
        /// ��Ƶ - ��·
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "VideoRoad")]
        public IActionResult VideoRoad()
        {
            //��ȡ��
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
        /// �ĵ�
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Doc")]
        public IActionResult Doc()
        {
            //��ȡͼƬ��
            string file = "\\Data\\Document\\Doc\\" + ToolCore.GetSimpNum(1, 10) + ".docx";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            //return File(fs, "application/msword"); //doc
            return File(fs, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
        /// <summary>
        /// ����ĵ�
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Excel")]
        public IActionResult Excel()
        {
            //��ȡͼƬ��
            string file = "\\Data\\Document\\Excel\\" + ToolCore.GetSimpNum(1, 6) + ".xlsx";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            //application/vnd.ms-excel
            return File(fs, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");//������ļ���ʽ����
        }


        /// <summary>
        /// PDF�ĵ�
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Pdf")]
        public IActionResult Pdf()
        {
            //��ȡͼƬ��
            string file = "\\Data\\Document\\pdf\\" + ToolCore.GetSimpNum(1, 8) + ".pdf";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            return File(fs, "application/pdf");//������ļ���ʽ����
        }

        /// <summary>
        /// PPT
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "PPT")]
        public IActionResult PPT()
        {
            //��ȡͼƬ��
            string file = "\\Data\\Document\\ppt\\" + ToolCore.GetSimpNum(1, 6) + ".pptx";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            //application/vnd.ms-powerpoint
            return File(fs, "application/vnd.openxmlformats-officedocument.presentationml.presentation");//������ļ���ʽ����
        }

        /// <summary>
        /// Rar
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Rar")]
        public IActionResult Rar()
        {
            //��ȡ��
            string file = "\\Data\\Document\\rar\\" + ToolCore.GetSimpNum(1, 11) + ".rar";
            string localpath = GlobalContext.HostingEnvironment.ContentRootPath + file;

            FileStream fs = new FileStream(localpath, FileMode.Open);
            return File(fs, "application/x-rar-compressed");//������ļ���ʽ����
        }

    }
}
