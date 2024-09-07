using Microsoft.AspNetCore.Mvc;
using System;
using System.IO.Pipelines;

namespace WebApplication4.Controllers
{
    /// <summary>
    /// 地区 及地址
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
        /// 地区编码
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "RegionCode")]
        public string RegionCode()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.RegionCode);
        }
        /// <summary>
        /// 多个 地区编码
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
        /// 地区  东北地区,华北地区,华东地区,中南地区,西南地区,西北地区,港澳台地区
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Region")]
        public string Region()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Region);
        }
        /// <summary>
        /// 多个 地区
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
        /// 省
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Province")]
        public string Province()
        {
            return ToolCore.GetVcodeNum(1, RandomData.Instance.Province)[0][0];
        }
        /// <summary>
        /// 多个 省
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
        /// 省+城市
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
        /// 多个 省+城市
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
        /// 省+城市+县
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
        /// 多个 省+城市+县
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
        /// 详细地址
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Addr")]
        public string Addr()
        {
            var pitem = ToolCore.GetVcodeNum(1, RandomData.Instance.Province)[0][0];
            var cityitem = ToolCore.GetVcodeNum(1, RandomData.Instance.City.Where(d => d.Value == pitem).Select(d => d.Key).ToArray());
            var countyitem = RandomData.Instance.County.Where(d => d.Value == cityitem).Select(d => d.Key).ToArray();
            return pitem + cityitem + ToolCore.GetVcodeNum(1, countyitem)+ ToolCore.GetVcodeNum(1, RandomData.Instance.Road) + ToolCore.GetVcodeNum(1, RandomData.Instance.Home) + ToolCore.GetSimpNum(1,10)+"号楼"+ToolCore.GetSimpNum(1, 5) + "单元" + ToolCore.GetSimpNum(1, 6) +"层" + ToolCore.GetSimpNum(1, 5) + "室";
        }
        /// <summary>
        /// 多个 详细地址
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
                items.Add(item[0] + cityitem + ToolCore.GetVcodeNum(1, countyitem) + ToolCore.GetVcodeNum(1, RandomData.Instance.Road) + ToolCore.GetVcodeNum(1, RandomData.Instance.Home) + ToolCore.GetSimpNum(1, 10) + "号楼" + ToolCore.GetSimpNum(1, 5) + "单元" + ToolCore.GetSimpNum(1, 6) + "层" + ToolCore.GetSimpNum(1, 5) + "室");
            }
            return items;
        }
    }
}
