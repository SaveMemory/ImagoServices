using System;
using System.Threading.Tasks;
using Imago.BusinessLogic.Employee.Read.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Imago.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeReadService _employeeService;

        public EmployeesController(IEmployeeReadService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAllEmployeesForUserAsync(Guid userId)
        {
            var employees = await _employeeService.GetAllEmployeesForUserAsync(userId);

            return Ok(employees);
        }
    }
}