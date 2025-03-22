using System.ComponentModel.DataAnnotations;

namespace HRManagement.Models
{
    public class Department
    {
        [Key]
        [System.ComponentModel.DisplayName ("Dept ID")]
        public int Dept_Id { get; set; }
        [Required, StringLength(100)]
        [System.ComponentModel.DisplayName("Department Name")]
        public string? DepartmentName { get; set; } 

    }
}
