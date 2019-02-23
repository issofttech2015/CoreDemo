using CoreDemoModels.DomainModels;
using CoreDemoService.Context;
using CoreDemoService.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CoreDemoService.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CoreDemoDbContext _context;
        public DepartmentRepository(CoreDemoDbContext coreDemoDbContext)
        {
            _context = coreDemoDbContext;
        }

        Task<Depertment> IRepository<Depertment>.Add(Depertment entity)
        {
            throw new NotImplementedException();
        }

        Task<Depertment> IRepository<Depertment>.AddRange(Depertment entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository<Depertment>.Delete(Depertment entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Depertment>> GetAll()
        {
            try
            {
                return await _context.Depertments.DefaultIfEmpty().ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<Depertment>();
            }
        }

        Task<Depertment> IRepository<Depertment>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task<Depertment> IRepository<Depertment>.Update(Depertment entity)
        {
            throw new NotImplementedException();
        }

        Task<Depertment> IRepository<Depertment>.UpdateRange(Depertment entity)
        {
            throw new NotImplementedException();
        }
    }
}
