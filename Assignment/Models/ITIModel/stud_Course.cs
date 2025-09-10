using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ITIModel
{
    internal class stud_Course
    {
        
        public int stud_Id {  get; set; }
        public int Course_Id {  get; set; }

        [Column(TypeName ="decimal(5,2)")]
        public decimal Grade {  get; set; }
    }
}
