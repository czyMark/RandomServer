using Microsoft.AspNetCore.Mvc;
using System;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// ��ͨ����
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class TransportationsController : ControllerBase
    {
        private readonly ILogger<TransportationsController> _logger;

        public TransportationsController(ILogger<TransportationsController> logger)
        {
            _logger = logger;
        }




        /// <summary>
        /// ����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Car")]
        public string Car()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Car);
        }
        /// <summary>
        /// ��� ����
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "Cars")]
        public IEnumerable<string> Cars(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.Car));
            }
            return items;
        }


        /// <summary>
        /// ��ͨ����-��
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "TransportationsCar")]
        public string TransportationsCar()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Transportations);
        }
        /// <summary>
        /// ��� ��ͨ����-��
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "TransportationsCars")]
        public IEnumerable<string> TransportationsCars(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.Transportations));
            }
            return items;
        }

        /// <summary>
        /// ��ͨ����-�ִ�
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "TransportationsShip")]
        public string TransportationsShip()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Ships);
        }
        /// <summary>
        /// ��� ��ͨ����-�ִ�
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "TransportationsShips")]
        public IEnumerable<string> TransportationsShips(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.Ships));
            }
            return items;
        }


        /// <summary>
        /// ��ͨ����-�ɻ�
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "TransportationsAir")]
        public string TransportationsAir()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.AirPlanes);
        }
        /// <summary>
        /// ��� ��ͨ����-�ɻ�
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "TransportationsAirs")]
        public IEnumerable<string> TransportationsAirs(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.AirPlanes));
            }
            return items;
        }

        /// <summary>
        /// ��ͨ����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Transportation")]
        public string Transportation()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.AllTransportations);
        }
        /// <summary>
        /// ��� ��ͨ����
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "Transportations")]
        public IEnumerable<string> Transportations(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add(ToolCore.GetVcodeNum(1, RandomData.Instance.AllTransportations));
            }
            return items;
        } 


    }
}
