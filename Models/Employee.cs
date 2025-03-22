using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRManagement.Models
{
    public class Employee
    {
        [Key]
        [System.ComponentModel.DisplayName("Emp ID")]
        public int Emp_ID { get; set; }
        
        [Required,StringLength(200)]
        [System.ComponentModel.DisplayName("Name")]
        public string Emp_Name { get; set; }

        [Required, Range(18,99)]
        [System.ComponentModel.DisplayName("Age")]
        public int Emp_Age { get; set; }

        [Required]
        [System.ComponentModel.DisplayName("Gender")]
        public string Emp_Gender { get; set; }

        [Required, StringLength(50)]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mobile number must be 10 digits and numeric.")]
        [System.ComponentModel.DisplayName("MobileNo")]
        public string Emp_Mobile{ get; set; }

        [Required, Range(0,int.MaxValue)]
        [System.ComponentModel.DisplayName("Salary")]
        public int Emp_Salary { get; set; }

        [System.ComponentModel.DisplayName("Status")]
        public bool Emp_Status { get; set; }

        [ForeignKey("Department")]    
        [Required(ErrorMessage ="Please select a department")]
        public int Dept_Id { get; set; }
        public Department? Department { get; set; }

    }
}
