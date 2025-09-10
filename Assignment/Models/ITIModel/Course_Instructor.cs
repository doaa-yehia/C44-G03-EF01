using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ITIModel
{
    internal class Course_Instructor
    {
        
        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }

        [Column(TypeName ="decimal(5,2)")]
        public decimal Evaluation {  get; set; }

    }
}
