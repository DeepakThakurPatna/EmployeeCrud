using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class NewEmployeeModel
    {
        [Key]
        public int Empid { get; set; }


        [Required(ErrorMessage = "Enter Employee Name")]
        [Display(Name = "Employee Name")]
        public string Empname { get; set; }


        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Employee Age")]
        [Display(Name = "Age")]
        [Range(20, 50)]
        public int Age { get; set; }


        [Required(ErrorMessage = "Enter Employee Salary")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
