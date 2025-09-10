using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.AirLineModel
{
    internal class Transaction
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        [Column(TypeName ="decimal(12,4)")]
        public decimal Amount { get; set; }
        public DateTime Date {  get; set; }
        public int AL_Id {  get; set; }


    }
}
