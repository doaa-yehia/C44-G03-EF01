using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.AirLineModel
{
    internal class Airline_Phone
    {

        [ForeignKey (nameof(AL_Phons))]
        public int AL_Id {  get; set; }
        public string? Phone { get; set; }

        [InverseProperty (nameof(Airline.Airline_Phones))]
        public Airline AL_Phons { get; set; } = null!;
    }
}
