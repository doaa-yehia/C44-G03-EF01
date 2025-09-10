using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.AirLineModel
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Address { get; set; }

        [NotMapped]
        public Gender GenderCode { get; set; }

        [Column("GenderCode")]
        [MaxLength(1)]
        public string GenderEmp {
            get => GenderCode == Gender.Male ? "m" : "f";
            set=> GenderCode = value == "m" ? Gender.Male : Gender.Female; 
        }
        public string? Position { get; set; }
        public DateTime BD_Year {  get; set; }
        public DateTime BD_Month {  get; set; }
        public DateTime BD_Day {  get; set; }
        public int AL_Id {  get; set; }

    }
}
