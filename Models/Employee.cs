using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Core.Models
{
    //Model-entuty-Domain Model -POCO Class
    // properties Only
    [Table("Employees")]
    internal class Employee
    {
        #region By Convention
        //public int Id { get; set; }
        //public string  EmpName { get; set; }
        //public decimal Salary { get; set; }
        //public int Age { get; set; }
        #endregion
        #region Data Annotation
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("EmployeeName",TypeName ="varchar" )]
        [MaxLength(50,ErrorMessage ="Name Of Employee Must be lessThan 51 char")]
        [MinLength(3, ErrorMessage = "Name Of Employee Must be lessThan 3 char")]
        
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        [Range(20,30)]
        public int Age { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        #endregion
    }
}
