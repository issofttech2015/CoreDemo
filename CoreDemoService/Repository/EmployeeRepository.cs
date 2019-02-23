using CoreDemoModels.DomainModels;
using CoreDemoService.Context;
using CoreDemoService.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CoreDemoService.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CoreDemoDbContext _context;
        public EmployeeRepository(CoreDemoDbContext coreDemoDbContext)
        {
            _context = coreDemoDbContext;
        }

        public Task<Employee> Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> AddRange(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateRange(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
