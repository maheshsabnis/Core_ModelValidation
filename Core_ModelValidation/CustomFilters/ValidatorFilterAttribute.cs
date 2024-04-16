using Core_ModelValidation.Models;
using Core_ModelValidation.ValidationRules;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Reflection;
using System.Security.Cryptography.Xml;

namespace Core_ModelValidation.CustomFilters
{
    public class ValidatorFilterAttribute : ActionFilterAttribute
    {
        public string? ModelName { get; set; } = null!;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid) 
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }

            var modelValidator = new EmployeeValidator();

            var model = (Employee)context.ActionArguments[ModelName!]!;
            var validationErrors = modelValidator.Validate(model);
            if (!validationErrors.IsValid)
            {
                validationErrors.Errors.ForEach(err=> 
                {
                    context.ModelState.Remove(err.PropertyName);
                    context.ModelState.AddModelError(err.PropertyName, err.ErrorMessage);
                });
            }
            context.Result = new BadRequestObjectResult(context.ModelState);
        }
    }
}
