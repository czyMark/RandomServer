using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication4.Extentions.Swagger
{
    public class SwaggerAuthTokenHeader : IOperationFilter
    {

        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            //MemberAuthorizeAttribute 自定义的身份验证特性标记
            var isAuthor = operation != null && context != null;
            if (isAuthor)
            {
                //in query header 
                operation.Parameters.Add(new OpenApiParameter()
                {
                    Name = "userId",
                    Description = "用户id",
                    In = ParameterLocation.Header,
                    Required = false,
                });
                //in query header 
                operation.Parameters.Add(new OpenApiParameter()
                {
                    Name = "appId",
                    Description = "应用id",
                    In = ParameterLocation.Header,
                    Required = false,
                });

                operation.Parameters.Add(new OpenApiParameter()
                {
                    Name = "time",
                    Description = "调用时间",
                    In = ParameterLocation.Header,
                    Required = false,
                });

                operation.Parameters.Add(new OpenApiParameter()
                {
                    Name = "guid",
                    Description = "唯一码",
                    In = ParameterLocation.Header,
                    Required = false,
                });

                operation.Parameters.Add(new OpenApiParameter()
                {
                    Name = "sign",
                    Description = "签名",
                    In = ParameterLocation.Header,
                    Required = false,
                });
            }
        }
    }
}
