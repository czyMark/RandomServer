using Microsoft.AspNetCore.Mvc;
using System;
using System.IO.Pipelines;

namespace WebApplication4.Controllers
{
    /// <summary>
    /// ���� ����ַ
    /// </summary> 
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class RegionController : ControllerBase
    {
        private readonly ILogger<RegionController> _logger;

        public RegionController(ILogger<RegionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "RegionCode")]
        public string RegionCode()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.RegionCode);
        }
        /// <summary>
        /// ��� ��������
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "RegionCodes")]
        public IEnumerable<string> RegionCodes(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.RegionCode)}");
            }
            return items;
        }



        /// <summary>
        /// ����  ��������,��������,��������,���ϵ���,���ϵ���,��������,�۰�̨����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Region")]
        public string Region()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Region);
        }
        /// <summary>
        /// ��� ����
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "Regions")]
        public IEnumerable<string> Regions(int num)
        {
            List<string> items = new List<string>();
            for (int i = 0; i <= num; i++)
            {
                items.Add($"{ToolCore.GetVcodeNum(1, RandomData.Instance.Region)}");
            }
            return items;
        }




        /// <summary>
        /// ʡ
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Province")]
        public string Province()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Province)[0][0];
        }
        /// <summary>
        /// ��� ʡ
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "Provinces")]
        public IEnumerable<string> Provinces(int num)
        {
            var temp = ToolCore.GetVcodeNum(num, RandomData.Instance.Province);
            List<string> items = new List<string>();
            foreach (var item in temp)
            {
                items.Add($"{item[0]}");
            }
            return items;
        }



        /// <summary>
        /// ʡ+����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "ProvinceCity")]
        public string ProvinceCity()
        {
            var pitem = ToolCore.GetVcodeNum(1, RandomData.Instance.Province)[0][0];
            var citem = RandomData.Instance.City.Where(d => d.Value == pitem).Select(d => d.Key).ToArray();
            return pitem + ToolCore.GetVcodeNum(1, citem);
        }
        /// <summary>
        /// ��� ʡ+����
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "ProvinceCitys")]
        public IEnumerable<string> ProvinceCitys(int num)
        {
            var temp = ToolCore.GetVcodeNum(num, RandomData.Instance.Province);
            List<string> items = new List<string>();
            foreach (var item in temp)
            {
                var citem = RandomData.Instance.City.Where(d => d.Value == item[0]).Select(d => d.Key).ToArray();
                if (citem == null)
                    continue; 
                items.Add($"{item[0] + ToolCore.GetVcodeNum(1, citem)}");
            }
            return items;
        }



        /// <summary>
        /// ʡ+����+��
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "ProvinceCityCounty")]
        public string ProvinceCityCounty()
        {
            var pitem = ToolCore.GetVcodeNum(1, RandomData.Instance.Province)[0][0];
            var cityitem = ToolCore.GetVcodeNum(1, RandomData.Instance.City.Where(d => d.Value == pitem).Select(d => d.Key).ToArray());
            var countyitem = RandomData.Instance.County.Where(d => d.Value == cityitem).Select(d => d.Key).ToArray();
            return pitem + cityitem + ToolCore.GetVcodeNum(1, countyitem);
        }
        /// <summary>
        /// ��� ʡ+����+��
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "ProvinceCityCountys")]
        public IEnumerable<string> ProvinceCityCountys(int num)
        {
            var temp = ToolCore.GetVcodeNum(num, RandomData.Instance.Province);
            List<string> items = new List<string>();
            foreach (var item in temp)
            {
                var citem = RandomData.Instance.City.Where(d => d.Value == item[0]).Select(d => d.Key).ToArray();
                if (citem == null)
                    continue;
                var cityitem= $"{ToolCore.GetVcodeNum(1, citem)}";
                var countyitem = RandomData.Instance.County.Where(d => d.Value == cityitem).Select(d => d.Key).ToArray();
                items.Add(item[0] + cityitem + ToolCore.GetVcodeNum(1, countyitem));
            }
            return items;
        }


        /// <summary>
        /// ��ϸ��ַ
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Addr")]
        public string Addr()
        {
            var pitem = ToolCore.GetVcodeNum(1, RandomData.Instance.Province)[0][0];
            var cityitem = ToolCore.GetVcodeNum(1, RandomData.Instance.City.Where(d => d.Value == pitem).Select(d => d.Key).ToArray());
            var countyitem = RandomData.Instance.County.Where(d => d.Value == cityitem).Select(d => d.Key).ToArray();
            return pitem + cityitem + ToolCore.GetVcodeNum(1, countyitem)+ ToolCore.GetVcodeNum(1, RandomData.Instance.Road) + ToolCore.GetVcodeNum(1, RandomData.Instance.Home) + ToolCore.GetSimpNum(1,10)+"��¥"+ToolCore.GetSimpNum(1, 5) + "��Ԫ" + ToolCore.GetSimpNum(1, 6) +"��" + ToolCore.GetSimpNum(1, 5) + "��";
        }
        /// <summary>
        /// ��� ��ϸ��ַ
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet(Name = "Addrs")]
        public IEnumerable<string> Addrs(int num)
        {
            var temp = ToolCore.GetVcodeNum(num, RandomData.Instance.Province);
            List<string> items = new List<string>();
            foreach (var item in temp)
            {
                var citem = RandomData.Instance.City.Where(d => d.Value == item[0]).Select(d => d.Key).ToArray();
                if (citem == null)
                    continue;
                var cityitem = $"{ToolCore.GetVcodeNum(1, citem)}";
                var countyitem = RandomData.Instance.County.Where(d => d.Value == cityitem).Select(d => d.Key).ToArray();
                items.Add(item[0] + cityitem + ToolCore.GetVcodeNum(1, countyitem) + ToolCore.GetVcodeNum(1, RandomData.Instance.Road) + ToolCore.GetVcodeNum(1, RandomData.Instance.Home) + ToolCore.GetSimpNum(1, 10) + "��¥" + ToolCore.GetSimpNum(1, 5) + "��Ԫ" + ToolCore.GetSimpNum(1, 6) + "��" + ToolCore.GetSimpNum(1, 5) + "��");
            }
            return items;
        }
    }
}
