using System;
using System.Collections.Generic;
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
        public int AL_Id { get; set; }

    }
}
