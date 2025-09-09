using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    [Table("EmployeeTable")]
    internal class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Column(name:"EmployeeName",TypeName ="varchar")]
        [MaxLength(50,ErrorMessage ="Name Can't Exceed 50 char")]
        [MinLength(3,ErrorMessage ="Name Must Be At Least 3 char")]
        public string? Name { get; set; }
        [Column(TypeName="decimal(10,2)")]
        //[Precision(10,2)]
        public decimal Sallary {  get; set; }
        [Range(22,30)]
        [AllowedValues(24,27,29,31)]
        [DeniedValues(25,27,29,31)]
        public int Age { get; set; }

        [Required]
        [EmailAddress] 
        [DataType(DataType.EmailAddress)]
        public string Email {  get; set; }

        [DataType(DataType.Password)]
        public string? password {  get; set; }

        [NotMapped]
        public string userName { get => Email.Split('@')[0]; }
    }
}
