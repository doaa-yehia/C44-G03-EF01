using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.AirLineModel
{
    [PrimaryKey (nameof(AC_ID),nameof(Route_Id))]
    internal class Aircraft_Route
    {
        
        public DateTime Departure {  get; set; }
        public int Num_Of_Pass {  get; set; }

        [Column(TypeName ="decimal(10,2)")]
        public decimal Price {  get; set; }

        public DateTime Arrival { get; set; }

        [NotMapped]
        public string TimeSpend =>(Arrival-Departure).ToString();
        
        [ForeignKey (nameof(Aircraft))]
        public int AC_ID { get; set; }

        [InverseProperty (nameof(Aircraft.ARoutes))]
        public Aircraft Aircraft { get; set; } = null!;

        [ForeignKey (nameof(Route))]
        public int Route_Id { get; set; }
        [InverseProperty (nameof(Route.A_Aircrafts))]
        public Route Route { get; set; } = null!;
    }
}
