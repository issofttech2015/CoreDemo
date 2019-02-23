using System;
using System.Collections.Generic;
using System.Text;
using CoreDemoService.Context;
using CoreDemoService.IRepositories;
using CoreDemoService.Repository;

namespace CoreDemoService.SDI
{
    public class SDICoreDemo : ISDICoreDemo
    {
        private readonly CoreDemoDbContext _context;
        public IEmployeeRepository Employees { get; set; }
        public IDepartmentRepository Departments { get; set; }
        public SDICoreDemo()
        {
            Employees = new EmployeeRepository(_context);
            Departments = new DepartmentRepository(_context);
        }

    }
}
