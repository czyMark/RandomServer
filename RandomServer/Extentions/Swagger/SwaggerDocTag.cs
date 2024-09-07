using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RandomServer.Extentions.Swagger
{
    public class SwaggerDocTag : IDocumentFilter
    {
        /// <summary>
        /// 添加附加注释
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            //swaggerDoc.Tags = new List<OpenApiTag>
            //{
            //    new OpenApiTag { Name = "AllFile", Description = "文件操作" },
            //    new OpenApiTag { Name = "RapidDevelopment", Description = "生成代码" },
            //    new OpenApiTag { Name = "BA_Bill", Description = "单据" },
            //    new OpenApiTag { Name = "Ba_Student", Description = "学生" },
            //    new OpenApiTag { Name = "Ba_TchTitle", Description = "教师职称" },
            //    new OpenApiTag { Name = "Ba_Teacher", Description = "教师" },
            //    new OpenApiTag { Name = "Ba_AdmitMode", Description = "授课模式" },
            //    new OpenApiTag { Name = "Ba_BillNum", Description = "单据号" },
            //    new OpenApiTag { Name = "Ba_Builder", Description = "建筑" },
            //    new OpenApiTag { Name = "Ba_BuilderLayer", Description = "楼层" },
            //    new OpenApiTag { Name = "Ba_Campus", Description = "校区" },
            //    new OpenApiTag { Name = "Ba_Discipline", Description = "学科" },
            //    new OpenApiTag { Name = "Ba_Faculty", Description = "院系" },
            //    new OpenApiTag { Name = "Ba_MajorClass", Description = "专业课" },
            //    new OpenApiTag { Name = "Ba_Major", Description = "专业" },
            //    new OpenApiTag { Name = "Ba_Room", Description = "房间" },
            //    new OpenApiTag { Name = "Ba_RoomState", Description = "房间状态" },
            //    new OpenApiTag { Name = "Ba_RoomType", Description = "房间类型" },
            //    new OpenApiTag { Name = "Ba_StatArea", Description = "开始区域" },
            //    new OpenApiTag { Name = "Gb_AcadCode", Description = "院士" },
            //    new OpenApiTag { Name = "Gb_Area", Description = "区域" },
            //    new OpenApiTag { Name = "Gb_FamRela", Description = "家庭关系" },
            //    new OpenApiTag { Name = "Gb_Health", Description = "健康状况" },
            //    new OpenApiTag { Name = "Gb_Marriage", Description = "婚姻状态" },
            //    new OpenApiTag { Name = "Gb_Nation", Description = "国家" },
            //    new OpenApiTag { Name = "Gb_Political", Description = "政治" },
            //    new OpenApiTag { Name = "Gb_Sexual", Description = "性别" },
            //    new OpenApiTag { Name = "Gb_TechPosition", Description = "职称" },
            //    new OpenApiTag { Name = "Sy_AppSecret", Description = "appid 注册表" },
            //    new OpenApiTag { Name = "Sy_DatabaseLink", Description = "数据库链接" },
            //    new OpenApiTag { Name = "Sy_Fun", Description = "目录" },
            //    new OpenApiTag { Name = "Sy_RoleFun", Description = "角色目录" },
            //    new OpenApiTag { Name = "Sy_Role", Description = "角色" },
            //    new OpenApiTag { Name = "Sy_UserLogin", Description = "用户登录" },
            //    new OpenApiTag { Name = "Sy_UserRole", Description = "用户角色" },
            //    new OpenApiTag { Name = "Sy_User", Description = "用户" },
            //    new OpenApiTag { Name = "WH_ConsApply", Description = "耗材采购申请单" },
            //    new OpenApiTag { Name = "WH_ConsBegin", Description = "耗材期初单" },
            //    new OpenApiTag { Name = "WH_Cons", Description = "耗材" },
            //    new OpenApiTag { Name = "WH_ConsInspect", Description = "耗材验收单" },
            //    new OpenApiTag { Name = "WH_ConsInStore", Description = "耗材入库单" },
            //    new OpenApiTag { Name = "WH_ConsNowQty", Description = "耗材现存量" },
            //    new OpenApiTag { Name = "WH_ConsOrder", Description = "耗材采购订单" },
            //    new OpenApiTag { Name = "WH_ConsOutStore", Description = "耗材出库单" },
            //    new OpenApiTag { Name = "WH_ConsType", Description = "耗材类型" },
            //    new OpenApiTag { Name = "WH_EqutApply", Description = "设备采购申请单" },
            //    new OpenApiTag { Name = "WH_EqutBegin", Description = "设备期初单" },
            //    new OpenApiTag { Name = "WH_Equt", Description = "设备" },
            //    new OpenApiTag { Name = "WH_EqutInspect", Description = "设备验收单" },
            //    new OpenApiTag { Name = "WH_EqutInStore", Description = "设备入库单" },
            //    new OpenApiTag { Name = "WH_EqutNowQty", Description = "设备现存量" },
            //    new OpenApiTag { Name = "WH_EqutOrder", Description = "设备采购订单" },
            //    new OpenApiTag { Name = "WH_EqutOutStore", Description = "设备出库单" },
            //    new OpenApiTag { Name = "WH_EqutType", Description = "设备类型" },
            //    new OpenApiTag { Name = "WH_Material", Description = "物资" },
            //    new OpenApiTag { Name = "WH_Store", Description = "库房管理" },
            //    new OpenApiTag { Name = "WH_Unit", Description = "计量单位" },
            //};
        }
    }
}
