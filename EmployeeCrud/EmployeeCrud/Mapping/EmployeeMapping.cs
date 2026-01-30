using AutoMapper;
using EmployeeCrud.Models;
using EmployeeCrud.DTO;
namespace EmployeeCrud.Mapping
{
    public class EmployeeMapping : Profile
    {
        public EmployeeMapping()
        {
            CreateMap<EmployeeInfo, EmployeeRead>();
            CreateMap<EmployeeCreate, EmployeeInfo>();
            CreateMap<EmployeeUpdate, EmployeeInfo>();
        }
    }
}