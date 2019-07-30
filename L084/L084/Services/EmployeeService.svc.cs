using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using L084.DataModels;

namespace L084.Services
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“EmployeeService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 EmployeeService.svc 或 EmployeeService.svc.cs，然后开始调试。
    public class EmployeeService : IEmployeeService
    {
        //public void DoWork()
        //{
        //}
        private static List<Employee> m_employees = new List<Employee>();

        public Employee GetEmployeeByID(string employeeID)
        {
            //throw new NotImplementedException();
            return m_employees.First(emp=>emp.ID.Equals(employeeID));
        }

        public List<Employee> GetEmployees()
        {
            //throw new NotImplementedException();
            return m_employees;
        }

        public void InsertEmployee(Employee employee)
        {
            //throw new NotImplementedException();
            m_employees.Add(employee);
        }
    }
}
