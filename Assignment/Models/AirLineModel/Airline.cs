using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.AirLineModel
{
    internal class Airline
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Cont_Person {  get; set; }

        [InverseProperty (nameof(Employee.EmpAirline))]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        [InverseProperty (nameof(Transaction.TransAirline))]
        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
        
        [InverseProperty (nameof(Aircraft.AL_Aircraft))]
        public ICollection<Aircraft> Aircrafts { get; set; } = new HashSet<Aircraft>();

        public ICollection<Airline_Phone> Airline_Phones { get; set; } = new HashSet<Airline_Phone>();
    }
}
