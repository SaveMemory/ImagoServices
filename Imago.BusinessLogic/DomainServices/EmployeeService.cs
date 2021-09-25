using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Imago.BusinessLogic.Interfaces;
using Imago.DataAccess.Interfaces;
using Imago.Thrash.Dto;

namespace Imago.BusinessLogic.DomainServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<EmployeeDto>> GetAllHiredForUser(Guid userId)
        {
            var hiredEmployees = await _employeeRepository.GetAllHiredForUser(userId);
            return _mapper.Map<IEnumerable<EmployeeDto>>(hiredEmployees);
        }
    }
}