﻿using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataBase_Context
{
    internal class CompanyDbContext : DbContext
    {
        public CompanyDbContext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyG03; Trusted_Connection = true;TrustServerCertificate = true");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        

    }
}
