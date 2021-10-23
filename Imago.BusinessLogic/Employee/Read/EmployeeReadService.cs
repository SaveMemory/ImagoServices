using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Imago.BusinessLogic.Employee.Read.Abstract;
using Imago.DataAccess.Repositories.Read.Abstract;
using Imago.Thrash.Dto;

namespace Imago.BusinessLogic.Employee.Read
{
    public class EmployeeReadService : IEmployeeReadService
    {
        private readonly IEmployeeReadRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeReadService(IEmployeeReadRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesForUserAsync(Guid userId)
        {
            var hiredEmployees = await _employeeRepository.GetAllEmployeesForUserAsync(userId);
            return _mapper.Map<IEnumerable<EmployeeDto>>(hiredEmployees);
        }
    }
}