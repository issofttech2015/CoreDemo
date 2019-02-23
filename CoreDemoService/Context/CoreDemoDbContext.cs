using CoreDemoModels.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemoService.Context
{
    public class CoreDemoDbContext : DbContext
    {
        public CoreDemoDbContext(DbContextOptions<CoreDemoDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Depertment> Depertments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
