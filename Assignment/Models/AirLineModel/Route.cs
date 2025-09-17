using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.AirLineModel
{
    internal class Route
    {
        public int Id{get; set;}

        [Column(TypeName ="decimal(10,4)")]
        public decimal Distance{get; set;}
        public string? Distination { get; set;}
        public string? Origin {  get; set;}
        public string? Classification {  get; set; } //can created using Enum But I don't Know Every type of Classification 

        public ICollection<Aircraft_Route> A_Aircrafts { get; set; } = new HashSet<Aircraft_Route>();
    }
}
