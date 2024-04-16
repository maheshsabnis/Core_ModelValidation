using System.ComponentModel.DataAnnotations;

namespace Core_ModelValidation.Models
{

    public abstract class BaseModel { }

    public class Employee : BaseModel
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? DeptName { get; set; }
        public string? Designation { get; set; }
        public int Salary { get; set; }
    }
}
