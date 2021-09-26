using System;
using Imago.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imago.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("{userId}")]
        public IActionResult GetAllHiredForUser(Guid userId)
        {
            if (!ModelState.IsValid)
                BadRequest();
            
            return Ok(_employeeService.GetAllHiredForUser(userId));
        }
        
        [HttpGet("{userId}")]
        public IActionResult GetAllEmployableForUser(Guid userId)
        {
            if (!ModelState.IsValid)
                BadRequest();
            
            return Ok(_employeeService.GetAllEmployableForUser(userId));
        }
    }
}