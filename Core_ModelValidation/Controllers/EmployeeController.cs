using Core_ModelValidation.CustomFilters;
using Core_ModelValidation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_ModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpPost]
        [ValidatorFilter(ModelName ="Employee")]
        public IActionResult Post(Employee employee)
        {
            return Ok(employee);
        }
    }
}
