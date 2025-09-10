using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.AirLineModel
{
    internal class Aircraft_Route
    {
        public int AC_ID {  get; set; }
        public int Route_Id {  get; set; }
        public DateTime Departure {  get; set; }
        public int Num_Of_Pass {  get; set; }

        [Column(TypeName ="decimal(10,2)")]
        public decimal Price {  get; set; }

        public DateTime Arrival { get; set; }

        [NotMapped]
        public string TimeSpend =>(Arrival-Departure).ToString();


    }
}
