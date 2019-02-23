using CoreDemoService.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemoService.SDI
{
    public interface ISDICoreDemo
    {
        IEmployeeRepository Employees { get; set; }
        IDepartmentRepository Departments { get; set; }
    }
}
