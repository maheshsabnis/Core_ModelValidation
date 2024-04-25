using System.ComponentModel.DataAnnotations;

namespace Core_ModelValidation.Models
{

    

    public class Employee  
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? DeptName { get; set; }
        public string? Designation { get; set; }
        public int Salary { get; set; }
    }
}
