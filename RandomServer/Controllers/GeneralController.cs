using Microsoft.AspNetCore.Mvc;
using System;
using RandomServer.Random;

namespace RandomServer.Controllers
{
    /// <summary>
    /// ͨ������
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class GeneralController : ControllerBase
    {
        private readonly ILogger<GeneralController> _logger;

        public GeneralController(ILogger<GeneralController> logger)
        {
            _logger = logger;
        }

        //���ݷ��͹����Ĳ��� ��֯��Ӧ������
        //���� 10�����ݣ�1��id,2�����֣�3�����֤�ţ�4�е�ַ��5�����֣�7�� 6��״̬��8�о��� 9��ά�ȡ�10����ֵ 10���ڡ�
        //���ص�����C1 C2 C3 ....C10


        //���ݽӿ�Ĭ��ʾ��Ϊ��
        //����һ��ͨ��ͼ�������
        //������Դ ���� ���ݷ�������  ���ͱ���-001003001 ����
        //����:AName �������� SName ϵ������ V1ֵ1 V2ֵ2 V3ֵ3 V4ֵ4 Lat[X] Lon-[Y]


        //����ʾ�����б�
    }
}
