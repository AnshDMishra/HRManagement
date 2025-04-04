﻿using HRManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Data
{
    public class HRManagementDbContext : DbContext
    {
        public HRManagementDbContext(DbContextOptions options) :base(options)
        {
                
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
