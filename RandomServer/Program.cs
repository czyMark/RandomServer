using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Reflection;
using RandomServer;
using RandomServer.Extentions.Swagger;

var builder = WebApplication.CreateBuilder(args);


// 加载配置
var configuration = builder.Configuration;

// 设置端口
//var portConfig = configuration["Kestrel:Endpoints:Http:Port"];
//int port = 5000;
//if (!string.IsNullOrEmpty(portConfig))
//{ 
//    port= int.Parse(portConfig);
//}


//var urlConfig = configuration["Kestrel:Endpoints:Http:Url"];
//string addr = "localhost";
//if (!string.IsNullOrEmpty(urlConfig))
//{
//    addr = urlConfig; 
//}
//builder.WebHost.UseUrls("http://10.0.8.16:9800" );


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
 
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "翼思数据-软件快速开发-欢迎联系18515262695", Version = "v1" });
    c.DocInclusionPredicate((docName, apiDes) =>
    {
        if (!apiDes.TryGetMethodInfo(out MethodInfo method))
            return false;

        var version = method.DeclaringType.GetCustomAttributes(true).OfType<ApiExplorerSettingsAttribute>().Select(m => m.GroupName);
        if (docName == "v1" && !version.Any())
            return true;
        var actionVersion = method.GetCustomAttributes(true).OfType<ApiExplorerSettingsAttribute>().Select(m => m.GroupName);
        if (actionVersion.Any())
            return actionVersion.Any(v => v == docName);
        return version.Any(v => v == docName);
    });
    c.MapType<TimeSpan>(() => new OpenApiSchema
    {
        Type = "string",
        Example = new OpenApiString("00:00:00")
    });
    c.MapType<DateTime>(() => new OpenApiSchema
    {
        Type = "string"
    }); 
    //获取xml文件名
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    // 获取xml文件路径
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    // 添加控制器层注释，true表示显示控制器注释
    c.IncludeXmlComments(xmlPath, true);
     
    c.DocumentFilter<SwaggerDocTag>();
});
//跨域
builder.Services.AddCors(options =>
{
    options.AddPolicy("cors",
        builder => builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()
    );
});

var app = builder.Build();
GlobalContext.HostingEnvironment = app.Environment;
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "前端使用的随机数据"); 
        c.RoutePrefix = "swagger";
        c.DocExpansion(DocExpansion.None);
        c.DefaultModelsExpandDepth(-1);
    });
    app.UseCors("cors");
//}

app.UseHttpsRedirection();

app.UseAuthorization(); 

app.MapControllers();

app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "/swagger/index.html" }
});

app.Run();


var temp=RandomData.Instance;