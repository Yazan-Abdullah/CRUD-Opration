using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCrudOperation.Models
{
    [Table("Employees", Schema = "HR")]
    public class Employee
    {
        [Key]
        [Display(Name = "Id")]
        public int? EmployeeId { get; set; }

        [Display(Name ="Name")]
        [Column(TypeName ="varchar(250)")]
        public string EmployeeName { get; set; } = string.Empty;

        [Display(Name ="Image User")]
        [Column(TypeName ="varchar(250)")]
        public string? ImageUser { get; set; }

        [Display(Name ="Birth Data")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name ="Salary")]
        [Column(TypeName ="decimal(12,2)")]
        public decimal Salary { get; set; }

        [Display(Name = "Hiring Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
              ApplyFormatInEditMode = true)]
        public DateTime HiringDate { get; set; }

        //[Display(Name ="Hiring Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString ="{dd-MM-yyyy")]
        //public DateTime HiringDate { get; set; }

        [Required]
        [Display(Name ="National Id")]
        [MaxLength(10)]
        [MinLength(10)]
        [Column(TypeName ="varchar(10)")]
        public string NationalId { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
    }
}
