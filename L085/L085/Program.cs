using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Services;

namespace L085
{
    class Program
    {
        private static Uri serviceUri = new Uri("http://localhost:51841/Services/EmployeeService.svc");
        static void Main(string[] args)
        {
            using (var serviceHost = new ServiceHost(typeof(EmployeeService), serviceUri))
            {
                serviceHost.AddServiceEndpoint(typeof(IEmployeeService), new BasicHttpBinding(), "");
                serviceHost.Description.Behaviors.Add(
                    new ServiceMetadataBehavior
                    {
                        HttpGetEnabled = true
                    }
                );

                serviceHost.Open();
                Console.WriteLine("当前时间:" + DateTime.Now.ToString()) ;
                Console.WriteLine("服务执行中...");
                Console.WriteLine("按回车停止服");
                Console.ReadLine();
                serviceHost.Close();
            }
        }
    }
}
