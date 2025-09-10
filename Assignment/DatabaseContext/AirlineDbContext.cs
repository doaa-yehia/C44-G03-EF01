using Assignment.Models.AirLineModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DatabaseContext
{
    internal class AirlineDbContext: DbContext
    {
        public AirlineDbContext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AirlineEF; Trusted_Connection = true;TrustServerCertificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airline_Phone>().HasKey(AP => new { AP.AL_Id, AP.Phone });
            modelBuilder.Entity<Emp_Qualification>().HasKey(EQ => new { EQ.Emp_Id, EQ.Qualifications });
            modelBuilder.Entity<Aircraft_Route>().HasKey(AR => new { AR.AC_ID, AR.Route_Id,AR.Departure });
        }
        public DbSet<Aircraft> Aircrafts {  get; set; }
        public DbSet<Aircraft_Route> Aircraft_Routes {  get; set; }
        public DbSet<Airline> Airlines {  get; set; }
        public DbSet<Airline_Phone> airline_Phones {  get; set; }
        public DbSet<Emp_Qualification> Emp_Qualifications {  get; set; }
        public DbSet<Employee> Employees {  get; set; }
        public DbSet<Route> Routes {  get; set; }
        public DbSet<Transaction> Transactions {  get; set; }
    }
}
