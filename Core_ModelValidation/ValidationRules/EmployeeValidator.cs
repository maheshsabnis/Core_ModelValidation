using Core_ModelValidation.Models;
using FluentValidation;

namespace Core_ModelValidation.ValidationRules
{
    public class EmployeeValidator: AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.EmpName).NotEmpty().WithMessage("EmpName must not be empty");
            RuleFor(p => p.DeptName).NotEmpty().WithMessage("DeptName must not be empty");
            RuleFor(p => p.Designation).NotEmpty().WithMessage("Designation must not be empty");
        }
    }


    
}
