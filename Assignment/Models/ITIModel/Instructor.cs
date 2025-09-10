using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ITIModel
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Address { get; set; }

        [Column(TypeName ="decimal(10,2)")]
        public decimal Bonus {  get; set; }

        [Column(TypeName ="decimal(10,2)")]
        public decimal Salary {  get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Hour_Rate { get; set; }

        public int Dept_Id {  get; set; }

    }
}
