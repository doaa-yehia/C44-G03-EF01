using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.AirLineModel
{
    internal class Aircraft
    {
        public int Id { get; set; }
        public int Capacity {  get; set; }
        public string? Model {  get; set; }
        public string? Maj_Pilot { get; set; }
        public string? Assistant { get; set; }
        public string Host01 {  get; set; }
        public string Host02 {  get; set; }

        [ForeignKey (nameof(AL_Aircraft))]
        public int AL_Id { get; set; }

        [InverseProperty (nameof(Airline.Aircrafts))]
        public Airline AL_Aircraft { get; set; } = null!;
    }
}
