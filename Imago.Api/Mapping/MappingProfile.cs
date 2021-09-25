using AutoMapper;
using Imago.BusinessCore.DomainModels;
using Imago.Thrash;
using Imago.Thrash.Dto;

namespace Imago.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>();
        }
    }
}